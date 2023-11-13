using System.ComponentModel.DataAnnotations;

namespace MVC_Cinema.Models
{
    public class Movie
    {
        [Key]
        public int ID { get; set; }
        public string Title { get; set; }
        public string Gener { get; set; }
        public List<Actor> Actors { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public double Rating { get; set; }
        public DataType PremiereWeek { get; set; }
        public double Price { get; set; }
        
    }
}
