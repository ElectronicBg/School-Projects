using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Zoo_MVC.Models
{
    public class Food
    {
        [Key]
        public int FoodId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        public DateTime ExpiryDate { get; set; }

        public List<Animal> Animals { get; set; }
    }
}
