using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//string connection_string = @"
			//		Data Source=(localdb)\MSSQLLocalDB;
			//		Initial Catalog=LibraryPD_321;
			//		Integrated Security=True;
			//
			//		Connect Timeout=30;
			//		Encrypt=False;
			//		TrustServerCertificate=False;
			//		ApplicationIntent=ReadWrite;
			//		MultiSubnetFailover=False";
			Library library = new Library();
			library.InsertAuthor("Hanriksson", "Martin");
			library.SelectAuthors();

			library.SelectBooks("Cameron");
			library.InsertBook("Abercrombie", "The First Law", 1276, 170);
			library.SelectBooks();
		}
	}
}
