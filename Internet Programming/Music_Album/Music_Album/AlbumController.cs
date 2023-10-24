using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Album
{
    public class AlbumController
    {
        private List<AlbumData> albums;
        private AlbumView albumView;
        
        public AlbumController(AlbumView albumView)
        {
            this.albums=new List<AlbumData>();
            this.albumView=albumView;
        }

        public void AddAlbum(int id, string name, string description, double price)
        {
            AlbumData album = new AlbumData()
            {
                ID = id,
                Name = name,
                Description = description,
                Price = price
            };
            albums.Add(album);
        }

        public void UpdateAlbum(int id,string name, string description, double price)
        {
            AlbumData updatedAlbum= albums.FirstOrDefault(a => a.ID == id);
            if (updatedAlbum != null)
            {
                updatedAlbum.Name = name;
                updatedAlbum.Description = description;
                updatedAlbum.Price = price;
            }
        }

        public void DeleteAlbum(int id)
        {
            AlbumData albumToRemove= albums.FirstOrDefault(a => a.ID == id);
            if(albumToRemove != null)
            {
                albums.Remove(albumToRemove);
            }
        }

        public void DisplayAllAlbums()
        {
            Console.WriteLine("All Albums");
            foreach (AlbumData album in albums)
            {
                albumView.DisplayAlbumInfo(album);
                Console.WriteLine();
            }
        }

    }
}
