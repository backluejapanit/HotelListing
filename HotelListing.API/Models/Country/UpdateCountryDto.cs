using HotelListing.API.Models;
using HotelListing.API.Models.Country;

namespace HotelListing.API.Models.Country
{
    public class UpdateCountryDto : BaseCountryDto, IBaseDto
    {
        public int Id { get; set; }
    }
}
