using System.ComponentModel.DataAnnotations.Schema;

namespace Zoo_MVC.Models
{
    public class EventZoo
    {
        [ForeignKey("Event")]
        public int EventId { get; set; }
        public Event Event { get; set; }

        [ForeignKey("Zoo")]
        public int ZooId { get; set; }
        public Zoo Zoo { get; set; }
    }
}
