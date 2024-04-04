using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Library2
{
	internal class Library
	{
		string connectionString;
		SqlConnection connection;
		public SqlCommand cmd { get; set; }
		public Library(string connectionString)
		{
			this.connectionString = connectionString;
			connection = new SqlConnection(connectionString);
		}
		~Library()
		{
			connection.Close();
		}
		public void InsertAuthor(string last_name, string first_name)
		{
			try
			{
				connection.Open();
				string command = $@"
					IF NOT EXISTS 
					(
						SELECT author_id FROM Authors 
						WHERE last_name='{last_name}' 
						AND first_name='{first_name}'
					)
					BEGIN
							INSERT INTO Authors
									(last_name, first_name)
							VALUES
									('{last_name}','{first_name}')
					END";
				cmd = new SqlCommand(command, connection);
				cmd.ExecuteNonQuery();
			}
			finally
			{
				if(connection!=null) connection.Close();
			}
		}
		public void SelectAuthors()
		{
			try
			{
				connection.Open();
				string command = "SELECT * FROM Authors";
				cmd = new SqlCommand(command, connection);
				SqlDataReader reader= cmd.ExecuteReader();
				Console.WriteLine($"{reader.GetName(0).PadRight(10)} {reader.GetName(1).PadRight(15)} {reader.GetName(2).PadRight(15)}");
				while (reader.Read())
				{
					Console.WriteLine($" {reader[0].ToString().PadRight(10)} {reader[1].ToString().PadRight(15)} {reader[2].ToString().PadRight(15)}");
				}
			}
			finally
			{ 
				if(connection!=null ) connection.Close();
			}
		}
		public void SelectBooks()
		{
			try
			{
				connection.Open();
				string command = $@"
					SELECT 
						title AS Title,
						[Author] = FORMATMESSAGE('%s %s', first_name, last_name)
					FROM Books 
					JOIN Authors ON author=author_id";
				cmd= new SqlCommand(command, connection);
				SqlDataReader reader = cmd.ExecuteReader();
				Console.WriteLine($"{reader.GetName(0).ToString().PadRight(32)} {reader.GetName(1).ToString().PadRight(32)}");
				while (reader.Read())
				{
					Console.WriteLine($"{reader[0].ToString().PadRight(32)} {reader[1].ToString().PadRight(32)}");
				}

			}
			finally
			{
				if(connection!=null ) connection.Close();
			}
		}
	}
}
