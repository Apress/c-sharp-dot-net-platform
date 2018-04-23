namespace OleDbDataReader
{
	using System;
	using System.Data;
	using System.Data.OleDb;

	class OleDbDR
	{
		static void Main(string[] args)
		{
			OleDbConnection cn = new OleDbConnection();

			// Uncomment to use Acess (adjust path if needed).
			// cn.ConnectionString = "Provider=Microsoft.JET.OLEDB.4.0;" +
			//	 @"data source = D:\CSharpBook\Labs\Chapter 13\Access DB\cars.mdb";     

			cn.ConnectionString = "Provider=SQLOLEDB.1;" +
				"Integrated Security=SSPI;" + 
				"Persist Security Info=False;" + 
				"Initial Catalog=Cars;" + 
				"Data Source=(local);";         			
			cn.Open();

			// Create a SQL command.
			string strSQL = "SELECT Make FROM Inventory WHERE Color='Red'"; 
			OleDbCommand myCommand = new OleDbCommand(strSQL, cn);

			// Obtain a data reader ala ExecuteReader().
			OleDbDataReader myDataReader;
			myDataReader = myCommand.ExecuteReader();
			
			// Loop over the results.
			while (myDataReader.Read()) 
			{
				Console.WriteLine("Red car: {0}", myDataReader["Make"].ToString());
			}    
		
			myDataReader.Close();
			cn.Close();
		}
	}
}
