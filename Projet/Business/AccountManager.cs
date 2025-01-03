using Projet.Data;
using Projet.Models;

namespace Projet.Business
{
    public class AccountManager : IAccountManager
	{
		IDataAccount data = new DataAccount();

        public void AddAccount(Account account)
        {
            if (data.FindAccount(account.Username) == null)
                data.AddAccount(account);
            else
                throw new Exception("account already exist");
        }

        public void DeleteAccount(string username)
        {
            data.DeleteAccount(username);
        }

        public Account FindAccount(string username)
        {
            return data.FindAccount(username);
        }

        public List<Account> GetAllAccounts()
        {
            return data.GetAllAccounts();
        }

        public void UpdateAccount(Account account)
        {
            throw new NotImplementedException();
        }
    }

}
