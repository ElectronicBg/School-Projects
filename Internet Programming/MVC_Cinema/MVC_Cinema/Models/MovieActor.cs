using System.ComponentModel.DataAnnotations;

namespace MVC_Cinema.Models
{
    public class MovieActor
    {
        [Key]
        public int MovieID { get; set; }
        public int ActorID { get; set; } 
    }
}
