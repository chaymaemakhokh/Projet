using Projet.Models;

namespace Projet.Data
{
	public interface IDataAccount
	{
        void AddAccount(Account account);
        Account FindAccount(string username);
        void UpdateAccount(Account account);
        void DeleteAccount(string username);
        List<Account> GetAllAccounts();
    }
}
