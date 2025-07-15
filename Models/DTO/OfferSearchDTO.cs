namespace Offer_API.Models.DTO
{
    public class OfferSearchResultDto
    {
        public List<OfferDto> Offers { get; set; } = new List<OfferDto>();
        public int TotalCount { get; set; }
    }
}
