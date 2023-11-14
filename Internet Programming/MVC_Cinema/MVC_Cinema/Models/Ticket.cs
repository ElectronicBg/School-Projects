using System.ComponentModel.DataAnnotations;

namespace MVC_Cinema.Models
{
    public class Ticket
    {
        [Key]
        public int ID { get; set; }
        public int Number { get; set; }
        public int MovieID { get; set; }
        public Movie Movie { get; set; }
        public int VisitorID { get; set; }
        public Visitor Visitor { get; set; }
        public int PlaceID { get; set; }
        public Place Place { get; set; }
        public decimal Price { get; set; }
    }
}
