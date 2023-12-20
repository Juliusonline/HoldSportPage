using HoldSportPage.Model;
using HoldSportPage.services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text;

namespace HoldSportPage.Pages.Medlemmer
{
    public class DeleteKundeModel : PageModel
    {
        private IKundeRepository _repo;

        public DeleteKundeModel(IKundeRepository repo)
        {
            _repo = repo;
        }



        public Kunde Kunde { get; private set; }



        public IActionResult OnGet(int nummer)
        {
            Kunde = _repo.HentKunde(nummer);


            return Page();
        }

        public IActionResult OnPostDelete(int nummer)
        {
            _repo.Slet(nummer);

            return RedirectToPage("Index");
        }

        public IActionResult OnPostCancel()
        {
            return RedirectToPage("Index");
        }



    }
}

