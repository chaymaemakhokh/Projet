using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Projet.Business;
using Projet.GlobalServices;
using Projet.Models;

namespace Projet.Pages
{
    public class AdministratorModel : PageModel
    {
        List<Account> liste;

        public List<Account> Liste { get => liste; set => liste = value; }

        public void OnGet()
        {

            liste = ServicesPages.manager.GetAllAccounts();
        }
    }
}
