using System.ComponentModel.DataAnnotations;

namespace MVC__Fluffy_Duffy_Munchkin_Cats.Models
{
    public class Cat
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Breed { get; set; }
        public string Img_Url { get; set; }
    }
}
