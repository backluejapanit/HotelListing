using HotelListing.API.Models.Hotel;
using HotelListing.API.Models.Country;

namespace HotelListing.API.Models.Country
{
    public class CountryDto : BaseCountryDto, IBaseDto
    {
        public int Id { get; set; }

        public List<HotelDto> Hotels { get; set; }
    }
}
