using Ragnarock.Models;
using Ragnarock.Interfaces;

namespace Ragnarock.Services
{
    public class ArtistCatalog:IArtistRepository
    {
        private Dictionary<int, Artist> Artists { get; }

        public ArtistCatalog()
        {
            Artists = new Dictionary<int, Artist>();
            Artists.Add(1, new Artist() { Id = 1, Name = "Elvis", Description = "The King Of Rock and Roll", BirthYear = 1935,DeathYear=1977, ImageName = "Elvis.jfif" });
            Artists.Add(2, new Artist() { Id = 2, Name = "Elvis", Description = "The King Of Rock and Roll", BirthYear = 1935, DeathYear = 1977, ImageName = "Elvis.jfif" });
            Artists.Add(3, new Artist() { Id = 3, Name = "Elvis", Description = "The King Of Rock and Roll", BirthYear = 1935, DeathYear = 1977, ImageName = "Elvis.jfif" });
        }
        public Dictionary<int, Artist> AllArtist()
        {
            return Artists;
        }
        public void AddArtist(Artist artist)
        {
            if (!Artists.Keys.Contains(artist.Id))
                Artists.Add(artist.Id, artist);
        }
        public Dictionary<int, Artist> FilterArtist(string criteria)
        {
            Dictionary<int, Artist> myArtists = new Dictionary<int, Artist>();
            if (criteria != null)
            {
                foreach (var a in Artists.Values)
                {
                    if (a.Name.StartsWith(criteria))
                    {
                        myArtists.Add(a.Id, a);
                    }
                }
            }
            return myArtists;
        }
        public Artist GetArtist(int Id)
        {
            return Artists[Id];
        }
        public void UpdateArtist(Artist artist)
        {
            if (artist != null)
            {
                Artists[artist.Id] = artist;
            }
        }
        public void DeleteArtist(Artist artist)
        {
            if (artist != null)
            {
                Artists.Remove(artist.Id);
            }
        }

    }
}
