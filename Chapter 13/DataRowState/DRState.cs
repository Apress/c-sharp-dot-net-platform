namespace DataRowState
{
    using System;
	using System.Data;

    public class DRState
    {
		public static void Main()
		{	
			Console.WriteLine("Illustrating RowState property:");
			// Build a single column DataTable
			DataTable myTable = new DataTable("Employees");
			DataColumn colID = new DataColumn("empID", 
										 Type.GetType("System.Int32"));
			myTable.Columns.Add(colID);

			// The DataRow.
			DataRow myRow;
			
			// Create a new (detached) DataRow.
			myRow = myTable.NewRow();
			Console.WriteLine(myRow.RowState.ToString());

			// Now add it to table.
			myTable.Rows.Add(myRow);
			Console.WriteLine(myRow.RowState.ToString());

			// Trigger an accept.
			myTable.AcceptChanges();
			Console.WriteLine(myRow.RowState.ToString());

			// Modify it and see state.
			myRow["empID"] = 100;
			Console.WriteLine(myRow.RowState.ToString());

			// Now delete it.
			myRow.Delete();
			Console.WriteLine(myRow.RowState.ToString());
			myRow.AcceptChanges();

			// Reinsert it, and add another column to the table.
			myTable.Rows.Add(myRow);	
			DataColumn colFirstName = new DataColumn("FirstName",
									  Type.GetType("System.String"));
			myTable.Columns.Add(colFirstName);
			
			Console.WriteLine("\nIllustrating ItemArray property:");
			// Declare the array variable.
			object [] myVals = new object[2];
			DataRow dr;
			
			// Create some new rows and add to RowsCollection.
			for(int i = 0; i < 5; i++)
			{
				myVals[0] = i;
				myVals[1]= "Name " + i;
				dr = myTable.NewRow();
				dr.ItemArray = myVals;
				myTable.Rows.Add(dr);
			}

			// Now print each value.
			foreach(DataRow r in myTable.Rows)
			{
				foreach(DataColumn c in myTable.Columns)
				{
					Console.WriteLine(r[c]);
				}
			}   
		}
	}
}
