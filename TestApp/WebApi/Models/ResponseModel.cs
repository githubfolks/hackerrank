using System.Collections.Generic;

namespace WebApi.Models
{
    public class ResponseModel
    {
        public int page { get; set; }
        public int per_page { get; set; }
        public int total { get; set; }
        public int total_pages { get; set; }
        public List<CityModel> data { get; set; }
    }
}
