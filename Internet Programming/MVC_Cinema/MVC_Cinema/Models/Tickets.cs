using System.ComponentModel.DataAnnotations;

namespace MVC_Cinema.Models
{
    public class Tickets
    {
        [Key]
        public int ID { get; set; }
        public Movie Movie { get; set; }
        public int PlaceNumber { get; set; }
    }
}
