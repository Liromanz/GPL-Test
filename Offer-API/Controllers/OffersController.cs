using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Offer_API.Models;
using Offer_API.Models.DTO;
using Offer_API.Repository;

namespace Offer_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OffersController : ControllerBase
    {
        private readonly OfferDbContext _context;

        public OffersController(OfferDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult<OfferDto>> OfferCreate(OfferDto offerDto)
        {
            var offer = new Offer
            {
                Brand = offerDto.Brand,
                Model = offerDto.Model,
                SupplierId = _context.Suppliers.Where(x => x.Name == offerDto.SupplierName)
                .FirstOrDefault()?.Id ?? 0,
                RegistrationDate = DateTime.Now
            };

            if (offer.SupplierId == 0)
            {
                return NotFound("Такого поставщика не существует.");
            }

            _context.Offers.Add(offer);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(OfferCreate), new { id = offer.Id }, offerDto);
        }

        [HttpGet("search")]
        public async Task<ActionResult<OfferSearchResultDto>> OfferSearch([FromQuery] string? searchTerm)
        {
            var query = _context.Offers
                .Include(o => o.Supplier)
                .AsQueryable();

            if (!string.IsNullOrEmpty(searchTerm))
            {
                searchTerm = searchTerm.ToLower();
                query = query.Where(o => o.Brand.ToLower().Contains(searchTerm) ||
                                         o.Model.ToLower().Contains(searchTerm) ||
                                         o.Supplier.Name.ToLower().Contains(searchTerm));
            }

            var offers = await query.Include(o => o.Supplier).Select(o => new OfferDto
            {
                Brand = o.Brand,
                Model = o.Model,
                SupplierName = o.Supplier.Name
            }).ToListAsync();
            var totalCount = await query.CountAsync();

            return new OfferSearchResultDto { Offers = offers, TotalCount = totalCount };
        }
    }
}
