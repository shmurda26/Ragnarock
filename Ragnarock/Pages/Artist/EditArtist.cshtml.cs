using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Ragnarock.Interfaces;
using Ragnarock.Models;

namespace Ragnarock.Pages.Artist
{
    public class EditArtistModel : PageModel
    {
        [BindProperty]
        public Models.Artist Artist { get; set; }
        private IArtistRepository catalog;
        public EditArtistModel(IArtistRepository repository)
        {
            catalog = repository;
        }
        public void OnGet(int id)
        {
            Artist = catalog.GetArtist(id);
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            catalog.UpdateArtist(Artist);
            return RedirectToPage("GetAllArtist");
        }
       
    }
}
