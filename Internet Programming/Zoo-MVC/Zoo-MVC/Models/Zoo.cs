using Microsoft.Extensions.Logging;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Zoo_MVC.Models
{
    public class Zoo
    {
        public Zoo()
        {
            Animals = new();
            Visits = new();
            EventZoos = new();
        }

        [Key]
        public int ZooId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Location { get; set; }

        [Required]
        public int FoundationYear { get; set; }

        public List<Animal> Animals { get; set; }
        public List<Visit> Visits { get; set; }
        public List<EventZoo> EventZoos { get; set; }

    }
}