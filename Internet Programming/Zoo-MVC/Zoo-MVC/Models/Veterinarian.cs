using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Zoo_MVC.Models
{
    public class Veterinarian
    {
        [Key]
        public int VeterinarianId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }

        [Required]
        public string Gender { get; set; }

        public List<Animal> AnimalsTreated { get; set; }
    }

}
