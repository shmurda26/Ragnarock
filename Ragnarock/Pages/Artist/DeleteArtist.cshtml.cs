using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Ragnarock.Interfaces;
using Ragnarock.Models;

namespace Ragnarock.Pages.Artist
{
    public class DeleteArtistModel : PageModel
    {
        [BindProperty]
        public Models.Artist Artist { get; set; }
        private IArtistRepository catalog;
        public DeleteArtistModel(IArtistRepository repository)
        {
            catalog = repository;
        }
        public IActionResult OnGet(int id)
        {
            Artist = catalog.GetArtist(id);
            return Page();
        }

        public IActionResult OnPost()
        {
            catalog.DeleteArtist(Artist);
            return RedirectToPage("GetAllArtist");
        }
       
    }
}
