using Ragnarock.Models;

namespace Ragnarock.Interfaces
{
    public interface IArtistRepository
    {
        Dictionary<int, Artist> AllArtist();
        Dictionary<int, Artist> FilterArtist(string crtiteria);
        void DeleteArtist(Artist artist);
        void AddArtist(Artist artist);
        void UpdateArtist(Artist artist);
        Artist GetArtist(int id);
    }
}
