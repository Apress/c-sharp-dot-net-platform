namespace FillDSOleDbAdapter
{
	using System;
	using System.Data;
	using System.Data.OleDb;

	public class MyOleDbDataAdapter
	{
		public static void PrintTable(DataSet ds)
		{
			// Print out results from table.
			Console.WriteLine("Here is what we have right now:\n");
			DataTable invTable = ds.Tables["Inventory"];

			// Print the Column names.
			for(int curCol= 0; curCol< invTable.Columns.Count; curCol++)
			{
				Console.Write(invTable.Columns[curCol].ColumnName.Trim() + "\t");
			}
			Console.WriteLine();

			// Print each cell.
			for(int curRow = 0; curRow < invTable.Rows.Count; curRow++)
			{
				for(int curCol= 0; curCol< invTable.Columns.Count; curCol++)					
				{
					Console.Write(invTable.Rows[curRow][curCol].ToString().Trim()+ "\t");				
				}
				Console.WriteLine();
			}
			Console.WriteLine();
		}

		public static int Main(string[] args)
		{
			// Step 1: Open a connection.			
			OleDbConnection cn = new OleDbConnection();
			cn.ConnectionString = "Provider=SQLOLEDB.1;" +
				"Integrated Security=SSPI;" + 
				"Persist Security Info=False;" + 
				"Initial Catalog=Cars;" + 
				"Data Source=.;";         			
			cn.Open();

			// Step 2: Create SELECT and UPDATE commands.
			// Create a SELECT command.
			OleDbCommand selectCmd = new OleDbCommand("SELECT * FROM Inventory", cn); 
	
			// Step 3: Make a data adapter & associate commands.
			OleDbDataAdapter dAdapt = new OleDbDataAdapter();
			dAdapt.SelectCommand = selectCmd;

			// Step 4: Create and fill the DataSet, close connection.
			DataSet myDS = new DataSet("CarsDataSet");
			try
			{
				dAdapt.Fill(myDS, "Inventory");
			}
			catch(Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
			finally
			{
				cn.Close();
			}
		
			PrintTable(myDS);
			return 0;
		}
	}
}
