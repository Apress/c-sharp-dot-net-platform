namespace UpdateRowsWithAdapter
{
	using System;
	using System.Data;
	using System.Data.SqlClient;

	/// <summary>
	///		Summary description for Class1.
	/// </summary>
	class Class1
	{
		public class MySqlDataAdapter
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
	
			public static void Main()
			{
				// Step 1: Create a connection and adapter.
				SqlConnection cn = new SqlConnection("server=(local);uid=sa;pwd=;database=Cars");
				SqlDataAdapter dAdapt = new SqlDataAdapter("Select * from Inventory", cn);

				// Step 2: Establish the UpdateCommand.
				dAdapt.UpdateCommand = new SqlCommand("UPDATE Inventory SET Make = @Make, Color = @Color, PetName = @PetName " +
					"WHERE CarID = @CarID" , cn);

				// Step 3: Build parameters for each column in Inventory table.
				SqlParameter workParam = null;
				workParam = dAdapt.UpdateCommand.Parameters.Add(new SqlParameter("@CarID", SqlDbType.Int));
				workParam.SourceColumn = "CarID";
				workParam.SourceVersion = DataRowVersion.Current;

				workParam = dAdapt.UpdateCommand.Parameters.Add(new SqlParameter("@Make", SqlDbType.VarChar));
				workParam.SourceColumn = "Make";
				workParam.SourceVersion = DataRowVersion.Current;

				workParam = dAdapt.UpdateCommand.Parameters.Add(new SqlParameter("@Color", SqlDbType.VarChar));
				workParam.SourceColumn = "Color";
				workParam.SourceVersion = DataRowVersion.Current;

				workParam = dAdapt.UpdateCommand.Parameters.Add(new SqlParameter("@PetName", SqlDbType.VarChar));
				workParam.SourceColumn = "PetName";
				workParam.SourceVersion = DataRowVersion.Current;

				// Step 4: Fill data set (with PK).
				DataSet myDS = new DataSet();
				dAdapt.Fill(myDS, "Inventory");
				PrintTable(myDS);

				// Step 5: Change row.
				DataRow changeRow = myDS.Tables["Inventory"].Rows[1];
				changeRow["Make"] = "FooFoo";
				changeRow["Color"] = "FooFoo";
				changeRow["PetName"] = "FooFoo";

				// Step 6: Send back to database and reprint.
				try
				{
					dAdapt.Update(myDS, "Inventory");
					myDS.Dispose();
					myDS = new DataSet();
					dAdapt.Fill(myDS, "Inventory");
					PrintTable(myDS);
				}
				catch(Exception e)
				{
					Console.Write(e.ToString());
				}			
			}
		}
	}
}
