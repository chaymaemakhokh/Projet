using Projet.Models;

namespace Projet.Business
{
	public interface IAccountManager
	{
        void AddAccount(Account account);
        Account FindAccount(string username);
        void UpdateAccount(Account account);
        void DeleteAccount(string username);
        List<Account> GetAllAccounts();
    }
}
