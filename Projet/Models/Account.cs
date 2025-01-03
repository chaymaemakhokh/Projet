using System.ComponentModel.DataAnnotations;

namespace Projet.Models
{
	public class Account
	{
		string username;
		string password;

		public Account()
		{
			username = "user";
			password = "";
		}
		//[Required(ErrorMessage = "le nom de l'utilisateur est obligatoire")]
		[StringLength(10, MinimumLength = 3)]
		public string Username
		{
			get => username; set => username = value;
		}

		//[DataType(DataType.Password)]
		public string? Password
		{
			get => password; set => password = value;
		}
	}
}
