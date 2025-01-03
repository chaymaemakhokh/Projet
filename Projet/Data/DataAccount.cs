using Microsoft.Data.SqlClient;
using Projet.Models;

namespace Projet.Data
{
    public class DataAccount : IDataAccount
	{
		SqlConnection connection;
        
        public DataAccount()
		{
			connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=db_projet;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=FalseData Source=(localdb)\MSSQLLocalDB;Initial Catalog=db_projet;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
			connection.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
		}


		public void AddAccount(Account account)
		{
			SqlCommand command = new SqlCommand();
			command.Connection = connection;
			command.CommandText = $"insert into Account values('{account.Username}','{account.Password}')";
			command.ExecuteNonQuery();
		}

        public void DeleteAccount(string username)
		{
			throw new NotImplementedException();
		}

        public Account FindAccount(string username)
		{
			SqlCommand command = new SqlCommand();
			command.Connection = connection;
			command.CommandText = $"select * from account where login='{username}'";
			SqlDataReader rs = command.ExecuteReader();
			if (rs.Read())
			{
				Account account = new Account { Username = (string)rs["login"], Password = (string)rs["password"] };
				rs.Close();
				return account;
			}
			rs.Close();
			return null;
		}

        public List<Account> GetAllAccounts()
        {
            throw new NotImplementedException();
        }

        public void UpdateAccount(Account account)
		{
			throw new NotImplementedException();
		}
	}
}
