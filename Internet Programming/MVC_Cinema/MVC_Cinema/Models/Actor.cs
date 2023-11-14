using System.ComponentModel.DataAnnotations;

namespace MVC_Cinema.Models
{
    public class Actor
    {
        [Key]
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDay { get; set; }
        public string Nationality { get; set; }
        public double IMDBRating { get; set; }
        public string Photo { get; set; }
        public List<MovieActor> MovieActors { get; set; }
    }
}
