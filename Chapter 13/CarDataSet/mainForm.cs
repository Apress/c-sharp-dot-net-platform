namespace CarDataSet
{
    using System;
    using System.Drawing;
    using System.Collections;
    using System.ComponentModel;
    using System.Windows.Forms;
    using System.Data;
	using System.Xml;

    public class mainForm : System.Windows.Forms.Form
    {
        private System.ComponentModel.Container components;
		private System.Windows.Forms.Button btnReadXML;
		private System.Windows.Forms.Button btnGetChildRels;
		private System.Windows.Forms.TextBox txtCustID;
		private System.Windows.Forms.Button btnGetInfo;
		private System.Windows.Forms.Button btnToXML;
		private System.Windows.Forms.DataGrid CustomerDataGrid;
		private System.Windows.Forms.DataGrid CarDataGrid;
		
		// Inventory DataTable.
		private DataTable inventoryTable = new DataTable("Inventory");

		// Customers DataTable.
		private DataTable customersTable = new DataTable("Customers");

		// Orders DataTable.
		private DataTable ordersTable = new DataTable("Orders");

		// Our DataSet
		private DataSet carsDataSet = new DataSet("CarDataSet");

		// Our list of Cars & Customers.
		private ArrayList arTheCars, arTheCustomers;

        public mainForm()
        {        
            InitializeComponent();
			CenterToScreen();

			// Fill the array list with some cars.
			arTheCars = new ArrayList();
			arTheCars.Add(new Car("Chucky", "BMW", "Green"));
			arTheCars.Add(new Car("Tiny", "Yugo", "White"));
			arTheCars.Add(new Car("", "Jeep", "Tan"));
			arTheCars.Add(new Car("Pain Inducer", "Caravan", "Pink"));
			arTheCars.Add(new Car("Fred", "BMW", "Pea Soup Green"));
			arTheCars.Add(new Car("Buddha", "BMW", "Black"));
			arTheCars.Add(new Car("Mel", "Firebird", "Red"));
			arTheCars.Add(new Car("Sarah", "Colt", "Black"));

			// Fill the array list with some cars.
			arTheCustomers = new ArrayList();
			arTheCustomers.Add(new Customer("Dave", "Brenner", 1020));
			arTheCustomers.Add(new Customer("Mike", "Larson", 1040));
			arTheCustomers.Add(new Customer("Eric", "Hollnagle", 1010));

			// Make data tables.
			MakeInventoryTable();
			MakeCustomerTable();
			MakeOrderTable();

			// Add relation.
			BuildTableRelationship();

			// Add foreign key constraints.
			AddConstraints();

			// Bind to grids.
			CarDataGrid.SetDataBinding(carsDataSet, "Inventory");
			CustomerDataGrid.SetDataBinding(carsDataSet, "Customers");

			btnReadXML.Enabled = false;
        }

		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

        private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container ();
			this.btnGetChildRels = new System.Windows.Forms.Button ();
			this.btnGetInfo = new System.Windows.Forms.Button ();
			this.btnReadXML = new System.Windows.Forms.Button ();
			this.btnToXML = new System.Windows.Forms.Button ();
			this.txtCustID = new System.Windows.Forms.TextBox ();
			this.CarDataGrid = new System.Windows.Forms.DataGrid ();
			this.CustomerDataGrid = new System.Windows.Forms.DataGrid ();
			CarDataGrid.BeginInit ();
			CustomerDataGrid.BeginInit ();
			btnGetChildRels.Location = new System.Drawing.Point (200, 328);
			btnGetChildRels.Size = new System.Drawing.Size (88, 56);
			btnGetChildRels.TabIndex = 7;
			btnGetChildRels.Text = "Get Child Relations for Orders Table";
			btnGetChildRels.Click += new System.EventHandler (this.btnGetChildRels_Click);
			btnGetInfo.Location = new System.Drawing.Point (296, 328);
			btnGetInfo.Size = new System.Drawing.Size (88, 56);
			btnGetInfo.TabIndex = 5;
			btnGetInfo.Text = "Get Info for Cust ID:";
			btnGetInfo.Click += new System.EventHandler (this.btnGetInfo_Click);
			btnReadXML.Location = new System.Drawing.Point (112, 328);
			btnReadXML.Size = new System.Drawing.Size (80, 56);
			btnReadXML.TabIndex = 8;
			btnReadXML.Text = "Rebuild DataSet from XML";
			btnReadXML.Click += new System.EventHandler (this.btnReadXML_Click);
			btnToXML.Location = new System.Drawing.Point (16, 328);
			btnToXML.Size = new System.Drawing.Size (88, 56);
			btnToXML.TabIndex = 4;
			btnToXML.Text = "Write DataSet to XML";
			btnToXML.Click += new System.EventHandler (this.btnToXML_Click);
			txtCustID.Location = new System.Drawing.Point (392, 328);
			txtCustID.Text = "1";
			txtCustID.TabIndex = 6;
			txtCustID.Size = new System.Drawing.Size (64, 20);
			CarDataGrid.Location = new System.Drawing.Point (16, 16);
			CarDataGrid.Size = new System.Drawing.Size (440, 152);
			CarDataGrid.DataMember = "";
			CarDataGrid.CaptionText = "Inventory";
			CarDataGrid.Font = new System.Drawing.Font ("Microsoft Sans Serif", 8);
			CarDataGrid.TabIndex = 1;
			CarDataGrid.CaptionFont = new System.Drawing.Font ("Microsoft Sans Serif", 11, System.Drawing.FontStyle.Bold);
			CustomerDataGrid.Location = new System.Drawing.Point (16, 184);
			CustomerDataGrid.Size = new System.Drawing.Size (440, 120);
			CustomerDataGrid.DataMember = "";
			CustomerDataGrid.CaptionText = "Customers";
			CustomerDataGrid.TabIndex = 2;
			CustomerDataGrid.CaptionFont = new System.Drawing.Font ("Microsoft Sans Serif", 11, System.Drawing.FontStyle.Bold);
			this.Text = "Car Data Table";
			this.AutoScaleBaseSize = new System.Drawing.Size (5, 13);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.ClientSize = new System.Drawing.Size (466, 399);
			this.Controls.Add (this.btnReadXML);
			this.Controls.Add (this.btnGetChildRels);
			this.Controls.Add (this.txtCustID);
			this.Controls.Add (this.btnGetInfo);
			this.Controls.Add (this.btnToXML);
			this.Controls.Add (this.CustomerDataGrid);
			this.Controls.Add (this.CarDataGrid);
			CarDataGrid.EndInit ();
			CustomerDataGrid.EndInit ();
		}

		protected void btnReadXML_Click (object sender, System.EventArgs e)
		{
			// Kill current DataSet.
			carsDataSet.Clear();
			carsDataSet.Dispose();
			MessageBox.Show("Just cleared data set...");
			carsDataSet = new DataSet("CarDataSet");
			
			carsDataSet.ReadXml( "cars.xml" );

			MessageBox.Show("Reconstructed data set from XML file...");
			btnReadXML.Enabled = false;

			// Bind to grids.
			CarDataGrid.SetDataBinding(carsDataSet, "Inventory");
			CustomerDataGrid.SetDataBinding(carsDataSet, "Customers");
		}

		protected void btnGetChildRels_Click (object sender, System.EventArgs e)
		{
			// Ask the CarsDataSet for the child relations of the inv. table.
			DataRelationCollection relCol;
			DataRow[] arrRows;
			string info = "";   
			relCol = carsDataSet.Tables["inventory"].ChildRelations;

			info += "\tRelation is called: " + relCol[0].RelationName + "\n\n";
			
			// Now loop over each relation, and print out info.
			foreach(DataRelation dr in relCol)
			{
				foreach(DataRow r in inventoryTable.Rows)
				{
					arrRows = r.GetChildRows(dr);
					
					// Print out the value of each column in the row.
			        for (int i = 0; i < arrRows.Length; i++)
					{
						foreach(DataColumn dc in arrRows[i].Table.Columns )
						{
							info += "\t" + arrRows[i][dc];
						}
			            info += "\n";
			         }
			    }
				MessageBox.Show(info, "Data in Orders Table obtained by child relations");
			}
		}		

		protected void btnGetInfo_Click (object sender, System.EventArgs e)
		{
			string strInfo = "";
			DataRow drCust = null;
			DataRow[] drsOrder = null;

			// Get the specified CustID
			int theCust = int.Parse(this.txtCustID.Text);
			try
			{				
				// Now based on CustID, get the correct row. 
				drCust = carsDataSet.Tables["Customers"].Rows[theCust];
				strInfo += "Cust #" + drCust["CustID"].ToString() + "\n";
			
				// Navigate from customer table to order table.
				drsOrder = 
				drCust.GetChildRows(carsDataSet.Relations["CustomerOrder"]);
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

			// Get customer name.
			if(drsOrder != null)
			{				
				foreach(DataRow r in drsOrder)
				{					
					strInfo += "Order Number: " + r["OrderID"] + "\n";
				}
			}

			// Now navigate from order table to inventory table.
			if(drsOrder != null)
			{
				DataRow[] drsInv = 
					drsOrder[0].GetParentRows(carsDataSet.Relations["InventoryOrder"]);
			
				// Get customer name.
				if(drsInv.Length > 0)
				{				
					foreach(DataRow r in drsInv)
					{					
						strInfo += "Make: " + r["Make"] + "\n";
						strInfo += "Color: " + r["Color"] + "\n";
						strInfo += "Pet Name: " + r["PetName"] + "\n";
					}
					MessageBox.Show(strInfo, "Info based on cust ID");
				}
			}			
		}

		protected void btnToXML_Click (object sender, System.EventArgs e)
		{
			carsDataSet.WriteXml("cars.xml");
			MessageBox.Show("Wrote CarDataSet to XML file in app directory");
			btnReadXML.Enabled = true;
		}

        public static void Main(string[] args) 
        {
            Application.Run(new mainForm());
        }

		private void MakeInventoryTable()
		{			
			// Add to the DataSet...
			carsDataSet.Tables.Add(inventoryTable);

			// DataColumn var.
			DataColumn myDataColumn;

			// Create CarID column and add to table.
			myDataColumn = new DataColumn();
			myDataColumn.DataType = Type.GetType("System.Int32");
			myDataColumn.ColumnName = "CarID";
			myDataColumn.ReadOnly = true;
			myDataColumn.AllowDBNull = false;
			myDataColumn.Unique = true;

			// Set the auto increment behavior.
			myDataColumn.AutoIncrement = true;
			myDataColumn.AutoIncrementSeed = 1000;
			myDataColumn.AutoIncrementStep = 10;
			carsDataSet.Tables["Inventory"].Columns.Add(myDataColumn);

			// Create Make column and add to table.    
			myDataColumn = new DataColumn();
			myDataColumn.DataType = Type.GetType("System.String");
			myDataColumn.ColumnName = "Make";
			carsDataSet.Tables["Inventory"].Columns.Add(myDataColumn);

			// Create Color column and add to table.
			myDataColumn = new DataColumn();
			myDataColumn.DataType = Type.GetType("System.String");
			myDataColumn.ColumnName = "Color";
			carsDataSet.Tables["Inventory"].Columns.Add(myDataColumn);
		   
			// Create PetName column and add to table.
			myDataColumn = new DataColumn();
			myDataColumn.DataType = Type.GetType("System.String");
			myDataColumn.ColumnName = "PetName";
			myDataColumn.AllowDBNull = true;
			carsDataSet.Tables["Inventory"].Columns.Add(myDataColumn);

			// Make the CarID column the primary key column.
			DataColumn[] PK = new DataColumn[1];
			PK[0] = inventoryTable.Columns["CarID"];
			carsDataSet.Tables["Inventory"].PrimaryKey = PK;

			// Iterate over the array list to make rows.
			foreach(Car c in arTheCars)
			{
				DataRow newRow;
				newRow = inventoryTable.NewRow();
				newRow["Make"] = c.make;
				newRow["Color"] = c.color;
				newRow["PetName"] = c.petName;
				carsDataSet.Tables["Inventory"].Rows.Add(newRow);
			}		
		}	

		private void MakeOrderTable()
		{
			// Add to the DataSet...
			carsDataSet.Tables.Add(ordersTable);	

			// DataColumn var.
			DataColumn myDataColumn;
			
			// Create OrderID column and add to table.
			myDataColumn = new DataColumn();
			myDataColumn.DataType = Type.GetType("System.Int32");
			myDataColumn.ColumnName = "OrderID";
			myDataColumn.ReadOnly = true;
			myDataColumn.AllowDBNull = false;
			myDataColumn.Unique = true;
			myDataColumn.AutoIncrement = true;
			myDataColumn.AutoIncrementSeed = 0;
			myDataColumn.AutoIncrementStep = 1;

			carsDataSet.Tables["Orders"].Columns.Add(myDataColumn);

			// Create CustID column and add to table.
			myDataColumn = new DataColumn();
			myDataColumn.DataType = Type.GetType("System.Int32");
			myDataColumn.ColumnName = "CustID";
			carsDataSet.Tables["Orders"].Columns.Add(myDataColumn);

			// Create CarID column and add to table.
			myDataColumn = new DataColumn();
			myDataColumn.DataType = Type.GetType("System.Int32");
			myDataColumn.ColumnName = "CarID";
			carsDataSet.Tables["Orders"].Columns.Add(myDataColumn);

			// Make the ID column the primary key column.
			DataColumn[] PK = new DataColumn[1];
			PK[0] = customersTable.Columns["OrderID"];
			carsDataSet.Tables["Orders"].PrimaryKey = PK;
			
			// Add some orders.
			for(int i = 0; i < arTheCustomers.Count; i++)
			{
				DataRow newRow;
				newRow = ordersTable.NewRow();

				Customer c = (Customer)arTheCustomers[i];
				newRow["CustID"] = i;
				newRow["CarID"] = c.currCarOrder;
				carsDataSet.Tables["Orders"].Rows.Add(newRow);
			}
		}

		private void MakeCustomerTable()
		{
			// Add to the DataSet...
			carsDataSet.Tables.Add(customersTable);	

			// DataColumn var.
			DataColumn myDataColumn;
			
			// Create CustID column and add to table.
			myDataColumn = new DataColumn();
			myDataColumn.DataType = Type.GetType("System.Int32");
			myDataColumn.ColumnName = "CustID";
			myDataColumn.ReadOnly = true;
			myDataColumn.AllowDBNull = false;
			myDataColumn.Unique = true;
			myDataColumn.AutoIncrement = true;
			myDataColumn.AutoIncrementSeed = 0;
			myDataColumn.AutoIncrementStep = 1;

			carsDataSet.Tables["Customers"].Columns.Add(myDataColumn);

			// Create FirstName column and add to table.
			myDataColumn = new DataColumn();
			myDataColumn.DataType = Type.GetType("System.String");
			myDataColumn.ColumnName = "FirstName";
			carsDataSet.Tables["Customers"].Columns.Add(myDataColumn);
		   
			// Create LastName column and add to table.
			myDataColumn = new DataColumn();
			myDataColumn.DataType = Type.GetType("System.String");
			myDataColumn.ColumnName = "LastName";
			carsDataSet.Tables["Customers"].Columns.Add(myDataColumn);

			// Make the ID column the primary key column.
			DataColumn[] PK = new DataColumn[1];
			PK[0] = customersTable.Columns["CustID"];
			carsDataSet.Tables["Customers"].PrimaryKey = PK;
			
			// Iterate over the array list to make rows.
			foreach(Customer c in arTheCustomers)
			{
				DataRow newRow;
				newRow = customersTable.NewRow();
				newRow["FirstName"] = c.firstName;
				newRow["LastName"] = c.lastName;
				carsDataSet.Tables["Customers"].Rows.Add(newRow);
			}		
		}
		
		private void BuildTableRelationship()
		{
			// Create a DR obj.
			DataRelation dr 
				= new DataRelation("CustomerOrder", 
				carsDataSet.Tables["Customers"].Columns["CustID"],			
				carsDataSet.Tables["Orders"].Columns["CustID"]);
							
			// Add to the DataSet.
			try
			{
				carsDataSet.Relations.Add(dr);
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

			// Create another DR obj.
			dr = new DataRelation("InventoryOrder", 
				 carsDataSet.Tables["Inventory"].Columns["CarID"],
				 carsDataSet.Tables["Orders"].Columns["CarID"]);

			// Add to the DataSet.
			try
			{
				carsDataSet.Relations.Add(dr);
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void AddConstraints()
		{
			carsDataSet.EnforceConstraints = true;
		}
    }
}
