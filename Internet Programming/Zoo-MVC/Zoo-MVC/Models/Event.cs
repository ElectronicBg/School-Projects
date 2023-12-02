using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zoo_MVC.Models
{
    public class Event
    {
        public Event()
        {
            EventZoos = new();
        }

        [Key]
        public int EventId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public string Description { get; set; }
        public List<EventZoo> EventZoos { get; set; }
    }
}