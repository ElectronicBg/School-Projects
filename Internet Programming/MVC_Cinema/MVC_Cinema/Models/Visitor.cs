using System.ComponentModel.DataAnnotations;

namespace MVC_Cinema.Models
{
    public class Visitor
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
