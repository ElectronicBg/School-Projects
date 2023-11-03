using System.ComponentModel.DataAnnotations;

namespace MVC_Book.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public string Author { get; set; }
        public string CoverImage { get; set; }
    }
}
