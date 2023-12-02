using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Zoo_MVC.Models
{
    public class Enclosure
    {
        [Key]
        public int EnclosureId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Size { get; set; }

        [Required]
        public string Type { get; set; }

        [ForeignKey("Zoo")]
        public int ZooId { get; set; }
        public Zoo Zoo { get; set; }
    }
}