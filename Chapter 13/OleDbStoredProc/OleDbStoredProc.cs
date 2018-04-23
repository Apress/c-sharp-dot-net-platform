namespace OleDbStoredProc
{
    using System;
	using System.Data;
	using System.Data.OleDb;

    public class OleDbStoredProc
    {
        public static int Main(string[] args)
        {
			// Open connection to data store.
			OleDbConnection cn = new OleDbConnection();
			cn.ConnectionString = "Provider=SQLOLEDB.1;" +
								  "Integrated Security=SSPI;" + 
								  "Persist Security Info=False;" + 
								  "Initial Catalog=Cars;" + 
								  "Data Source=(local);";         			
			cn.Open();
			
			// Make a command obj for the stored proc.
			OleDbCommand myCommand = new OleDbCommand("GetPetName", cn);
			myCommand.CommandType = CommandType.StoredProcedure;

			// Create the parameters for the call.
			OleDbParameter theParam = new OleDbParameter();
			
			// Input.
			theParam.ParameterName = "@carID";
			theParam.OleDbType = OleDbType.Integer;
			theParam.Direction = ParameterDirection.Input;
			theParam.Value = 1;		// Car ID = 1.
			myCommand.Parameters.Add(theParam);

			// Output.
			theParam = new OleDbParameter();
			theParam.ParameterName = "@petName";
			theParam.OleDbType = OleDbType.Char;
			theParam.Size = 20;
			theParam.Direction = ParameterDirection.Output;
			myCommand.Parameters.Add(theParam);

			// Execute the command!
			myCommand.ExecuteNonQuery();

			// Display the result.
			Console.WriteLine("Stored Proc Info:");
			Console.WriteLine("Car ID: " + myCommand.Parameters["@carID"].Value);
			Console.WriteLine("PetName: " + myCommand.Parameters["@petName"].Value);

            return 0;
        }
    }
}
