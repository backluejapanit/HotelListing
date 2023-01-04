using System.ComponentModel.DataAnnotations.Schema;
using HotelListing.API.Models.Country;

namespace HotelListing.API.Models.Country
{
    public class GetCountryDto : BaseCountryDto, IBaseDto
    {
        public int Id { get; set; }
    }
}
