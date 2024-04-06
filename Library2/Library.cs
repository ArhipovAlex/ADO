using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace Library2
{
	internal class Library
	{
		string connectionString;
		SqlConnection connection;
		public SqlCommand cmd { get; set; }
		public Library():this(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString)
		{
			//connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
			//connection = new SqlConnection(connectionString);
			Console.WriteLine(connectionString);
		}
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
						WHERE last_name=@paramLastName 
						AND first_name=@paramFirstName
					)
					BEGIN
							INSERT INTO Authors
									(last_name, first_name)
							VALUES
									(@paramLastName,@paramFirstName)
					END";
				cmd = new SqlCommand(command, connection);
				//SqlParameter parametrLastName = new SqlParameter("paramLastName", SqlDbType.NVarChar);
				//SqlParameter parametrFirstName = new SqlParameter("paramFirstName", SqlDbType.NVarChar);
				//parametrLastName.Value = last_name;
				//parametrFirstName.Value = first_name;
				//cmd.Parameters.Add(parametrLastName);
				//cmd.Parameters.Add(parametrFirstName);

				//SqlParameter[] values = new SqlParameter[]
				//{
				//	new SqlParameter("paramLastName", last_name),
				//	new SqlParameter("paramFirstName", first_name),
				//};
				//cmd.Parameters.AddRange(values);

				cmd.Parameters.AddWithValue("paramLastName", last_name);
				cmd.Parameters.AddWithValue("paramFirstName", first_name);
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
				Console.WriteLine();
			}
			finally
			{ 
				if(connection!=null ) connection.Close();
			}
		}
		public void SelectBooks(string author_last_name)
		{
			try
			{
				connection.Open();
				string command = $@"
					SELECT 
						title AS Title,
						[Author] = FORMATMESSAGE('%s %s', first_name, last_name)
					FROM Books 
					JOIN Authors ON author=author_id
					WHERE last_name='{author_last_name}'";
				cmd= new SqlCommand(command, connection);
				SqlDataReader reader = cmd.ExecuteReader();
				Console.WriteLine($"{reader.GetName(0).ToString().PadRight(32)} {reader.GetName(1).ToString().PadRight(32)}");
				while (reader.Read())
				{
					Console.WriteLine($"{reader[0].ToString().PadRight(32)} {reader[1].ToString().PadRight(32)}");
				}
				Console.WriteLine();
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
				cmd = new SqlCommand(command, connection);
				SqlDataReader reader = cmd.ExecuteReader();
				Console.WriteLine($"{reader.GetName(0).ToString().PadRight(32)} {reader.GetName(1).ToString().PadRight(32)}");
				while (reader.Read())
				{
					Console.WriteLine($"{reader[0].ToString().PadRight(32)} {reader[1].ToString().PadRight(32)}");
				}
				Console.WriteLine();
			}
			finally
			{
				if (connection != null) connection.Close();
			}
		}
		public void InsertBook(string author_last_name, string title, int pages, int price)
		{
			try
			{
				connection.Open();
				string command = $@"
					IF NOT EXISTS
					(
						SELECT book_id FROM Books
						WHERE	author=(SELECT author_id FROM Authors WHERE last_name='{author_last_name}')
							AND title='{title}'
					)
					BEGIN
						INSERT INTO Books
							(author, title, pages, price)
						VALUES
							((SELECT author_id FROM Authors WHERE last_name='{author_last_name}'), '{title}', {pages}, {price})
					END";
				cmd = new SqlCommand(command, connection);
				cmd.ExecuteNonQuery();
			}
			finally
			{
				if (connection != null) connection.Close();
			}
		}
	}
}
