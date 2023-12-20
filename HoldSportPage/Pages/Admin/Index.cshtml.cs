using HoldSportPage.Model;
using HoldSportPage.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HoldSportPage.Pages.Admin
{
   
        public class IndexModel : PageModel
        {
            private IUserRepository _users;

            public User UserLoggedIn { get; private set; }

            public IndexModel(IUserRepository users)
            {
                _users = users;
            }

            public IActionResult OnGet()
            {
                if (_users is null || _users.UserLoggedIn is null || !_users.UserLoggedIn.IsAdmin)
                {
                    return RedirectToPage("/Login");
                }

                UserLoggedIn = _users.UserLoggedIn;

                return Page();
            }
        }
    }

