using System.ComponentModel.DataAnnotations.Schema;

namespace Zoo_MVC.Models
{
    public class Visit
    {
        [ForeignKey("Visitor")]
        public int VisitorId { get; set; }

        [ForeignKey("Zoo")]
        public int ZooId { get; set; }

        public Visitor Visitor { get; set; }
        public Zoo Zoo { get; set; }
    }
}
