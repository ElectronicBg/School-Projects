using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Zoo_MVC.Models
{
    public class Animal
    {
        [Key]
        public int AnimalId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Species { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }

        [Required]
        public double Weight { get; set; }

        [ForeignKey("Zoo")]
        public int ZooId { get; set; }
        public Zoo Zoo { get; set; }


    }
}

