using System.ComponentModel.DataAnnotations;

namespace MVC_Cinema.Models
{
    public class Movie
    {
        [Key]
        public int ID { get; set; }
        public string Title { get; set; }
        public int GenreID { get; set; }
        public Genre Genre { get; set; }
        public List<MovieActor> MovieActor { get; set; }
        public string Poster { get; set; }
        public string Plot { get; set; }
        public double VisitorRating { get; set; }
        public DataType ProjectionWeek { get; set; }
        public decimal Price { get; set; }
        public List<Ticket> Tickets { get; set; }
    }
}
