using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Zoo_MVC.Models
{
    public class Visitor
    {
        [Key]
        public int VisitorId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        public string PersonalIdentificationNumber { get; set; }

        public List<Zoo> ZoosVisited { get; set; }
        public List<Visit> Visits { get; set; }

    }
}