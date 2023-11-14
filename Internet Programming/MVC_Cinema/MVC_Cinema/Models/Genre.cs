using System.ComponentModel.DataAnnotations;

namespace MVC_Cinema.Models
{
    public class Genre
    {
        [Key]
        public int ID { get;set; }
        public string Name { get;set; }
        public List<Movie> Movies { get; set; }
    }
}
