using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Ragnarock.Interfaces;
using Ragnarock.Models;
namespace Ragnarock.Pages.Artist
{
    public class CreateArtistModel : PageModel
    {
        [BindProperty]
        public Models.Artist Artists { get; set; }
        private IArtistRepository catalog;
        public CreateArtistModel(IArtistRepository repository)
        {

            catalog = repository;
        }
        public IActionResult OnGet()
        {
            return Page();
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            catalog.AddArtist(Artists);
            return RedirectToPage("GetAllArtits");
        }
    }
  
    }
