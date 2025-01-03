using Projet.Business;

namespace Projet.GlobalServices
{
	public static class ServicesPages
	{
		public static IAccountManager manager;
		static ServicesPages()
		{
			manager = new AccountManager(); // on instancie le service
											//manager = new AccountManagerV2();

		}
	}
}
