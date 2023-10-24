using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Music_Album
{
   public class AlbumView
    {
        public void DisplayAlbumInfo(AlbumData albumData)
        {
            Console.WriteLine("Album Information: ");
            Console.WriteLine($"ID: {albumData.ID}");
            Console.WriteLine($"Name: {albumData.Name}");
            Console.WriteLine($"Description: {albumData.Description}");
            Console.WriteLine($"Price: {albumData.Price}");
        }
    }
}
