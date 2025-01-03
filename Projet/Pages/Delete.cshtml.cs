using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Projet.GlobalServices;
using Projet.Models;

namespace Projet.Pages
{
    public class DeleteModel : PageModel
    {
        Account compte;
        public Account Compte { get { return compte; } set { compte = value; } }
        public void OnGet(string id)
        {

            compte = ServicesPages.manager.FindAccount(id);
        }
        public void OnPost(Account Compte)
        {
            ServicesPages.manager.DeleteAccount(Compte.Username);
        }
    }
}
