using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Projet.GlobalServices;
using Projet.Models;

namespace Projet.Pages
{
    public class RegisterModel : PageModel
    {
        Account account;

        public Account Compte
        {
            get => account;
            set => account = value;
        }

        public void OnGet()
        {
        }
        public IActionResult OnPost(Account Compte)
        {

            //test de validation coté serveur:
            //....
            try
            {
                ServicesPages.manager.AddAccount(Compte);
                return RedirectToPage("/Authentication");
            }
            catch (Exception)
            {

                return Page();
            }

        }
    }
}
