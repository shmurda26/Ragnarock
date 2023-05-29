using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Ragnarock.Interfaces;
using Ragnarock.Models; 

namespace Ragnarock.Pages.Artist
{
    public class GetAllArtistModel : PageModel
    {
        private IArtistRepository catalog;
        public GetAllArtistModel (IArtistRepository repository)
        {
            catalog = repository;
        }
        public Dictionary<int, Models.Artist> Artist { get; private set; }

        [BindProperty(SupportsGet = true)]
        public string FilterCriteria { get; set; }

        public void OnGet()
        {
            Artist = catalog.AllArtist();

        }
        
    }
}
