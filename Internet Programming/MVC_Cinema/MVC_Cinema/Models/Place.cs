using System.ComponentModel.DataAnnotations;

namespace MVC_Cinema.Models
{
    public class Place
    {
        [Key]
        public int ID { get; set; }
        public int Number { get; set; }
        public decimal Price { get; set; }
        public List<Ticket> Tickets { get; set; }
    }
}
