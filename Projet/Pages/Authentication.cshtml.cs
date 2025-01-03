using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Projet.GlobalServices;
using Projet.Models;

namespace Projet.Pages
{
    public class AuthenticationModel : PageModel
    {
        Account account;
        string msgErr;
        public Account Compte
        {
            get => account;
            set => account = value;
        }
        public string MsgErr { get => msgErr; set => msgErr = value; }

        public void OnGet()
        {
        }
        public IActionResult OnPost(Account Compte)
        {
            Account x = ServicesPages.manager.FindAccount(Compte.Username);
            if (x != null && x.Password == Compte.Password)
            {
                if (Compte.Username == "Admin")
                    return RedirectToPage("/Administrator");
                return RedirectToPage("/Index");
            }
            else
            {
                MsgErr = "Username or password incorrect!";
                return Page();
            }
        }

    }
}
