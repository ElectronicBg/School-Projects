using System;

namespace Music_Album
{
    public class Program
    {
        static void Main(string[] args)
        {
            AlbumView albumView = new AlbumView();
            AlbumController albumController = new AlbumController(albumView);

            albumController.AddAlbum(1, "Album 1", "Hit Album", 10);
            albumController.AddAlbum(2, "Album 2", "Hit Album", 20);

            albumController.DisplayAllAlbums();


            albumController.UpdateAlbum(2, "Update Album 2", "Best Songs", 30);

            albumController.DisplayAllAlbums();
        }
    }
}
