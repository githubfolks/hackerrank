namespace WebApi.Models
{
    public class CityModel
    {
        public string City { get; set; }
        public string Name {  get; set; }
        public int Estimated_Cost {  get; set; }
        public UserRating User_Rating {  get; set; } 
        public string Id {  get; set; }

    }
    public class UserRating
    {
        public string Average_Rating { get; set; }
        public string Votes { get; set; }
    }
}
