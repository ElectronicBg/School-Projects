using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Zoo_MVC.Models
{
    public class Personnel
    {
        [Key]
        public int PersonnelId { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Position { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        public decimal Salary { get; set; }

        [ForeignKey("Zoo")]
        public int ZooId { get; set; }
        public Zoo Zoo { get; set; }
    }
}