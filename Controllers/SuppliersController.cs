using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Offer_API.Models.DTO;
using Offer_API.Repository;

namespace Offer_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuppliersController : ControllerBase
    {
        private readonly OfferDbContext _context;

        public SuppliersController(OfferDbContext context)
        {
            _context = context;
        }

        [HttpGet("popular")]
        public async Task<ActionResult<IEnumerable<SupplierDto>>> GetPopularSuppliers()
        {
            var popularSuppliers = await _context.Suppliers
                .Select(s => new SupplierDto
                {
                    Name = s.Name,
                    OfferCount = s.Offers.Count
                })
                .OrderByDescending(s => s.OfferCount)
                .Take(3)
                .ToListAsync();

            return Ok(popularSuppliers);
        }
    }
}
