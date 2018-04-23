namespace CarsWebService
{
	using System;
	using System.Collections;
	using System.ComponentModel;
	using System.Data;
	using System.Data.SqlClient;
	using System.Diagnostics;
	using System.Web;
	using System.Web.Services;
 
	public class Car
	{
		public string petName;
		public int currSpeed;
		public Car(){}
		public Car(string n, int sp)
		{ petName = n; currSpeed = sp;}
	}

	/// <summary>
	///    Summary description for Service1.
	/// </summary>
 
	public class CarService : System.Web.Services.WebService
	{
		private ArrayList carList = new ArrayList();
		public CarService()
		{
			//CODEGEN: This call is required by the ASP.NET Web Services Designer
			InitializeComponent();

			// Add cars.
			carList.Add(new Car("Zippy", 170));
			carList.Add(new Car("Fred", 80));
			carList.Add(new Car("Sally", 40));

		}

		#region Component Designer generated code
		private IComponent components = null;

		/// <summary>
		///    Required method for Designer support - do not modify
		///    the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
		}
		#endregion

		/// <summary>
		///    Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if(disposing && components != null)
			{
				components.Dispose();
			}
			base.Dispose(disposing);		
		}

		[WebMethod]
		public DataSet GetAllCars()
		{
			// Fill the DataGrid with the Inventory table.
			SqlConnection sqlConn = new SqlConnection();
			sqlConn.ConnectionString = "data source=.; initial catalog=Cars;" +  
				"user id=sa; password=";

			SqlDataAdapter dsc = 
				new SqlDataAdapter("Select * from Inventory", sqlConn);
			DataSet ds = new DataSet();
			dsc.Fill(ds, "Inventory");
			return ds;
		}

		// Return a given Car from the list.
		[WebMethod]
		public Car GetACarFromList(int carToGet)
		{
			if(carToGet <= carList.Count)
			{
				return (Car) carList[carToGet];	
			}
			throw new IndexOutOfRangeException();
		}

		// Return the entire list.
		[WebMethod]
		public ArrayList GetCarList()
		{
			return carList;
		}

	}
}
