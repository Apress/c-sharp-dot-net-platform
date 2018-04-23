namespace CarDataTable
{
    using System;
    using System.Drawing;
    using System.Collections;
    using System.ComponentModel;
    using System.Windows.Forms;
    using System.Data;

    public class CarDTForm : System.Windows.Forms.Form
    {
        private System.ComponentModel.Container components;
		private System.Windows.Forms.DataGrid ColtsViewGrid;
		private System.Windows.Forms.DataGrid RedCarViewGrid;
		private System.Windows.Forms.Button btnChange;
		private System.Windows.Forms.TextBox txtRemove;
		private System.Windows.Forms.Button btnRemoveRow;
		private System.Windows.Forms.TextBox txtMake;
		private System.Windows.Forms.Button btnGetMake;
		private System.Windows.Forms.DataGrid CarDataGrid;
		private System.Windows.Forms.Button btnMakeDataTable;
		
		// Our DataTable.
		private DataTable inventoryTable = new DataTable("Inventory");

		// Views of the DataTable.
		DataView redCarsView;
		DataView coltsView;

		// Our list of Cars.
		private ArrayList arTheCars = null;

        public CarDTForm()
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
			this.txtMake = new System.Windows.Forms.TextBox ();
			this.ColtsViewGrid = new System.Windows.Forms.DataGrid ();
			this.RedCarViewGrid = new System.Windows.Forms.DataGrid ();
			this.btnRemoveRow = new System.Windows.Forms.Button ();
			this.CarDataGrid = new System.Windows.Forms.DataGrid ();
			this.txtRemove = new System.Windows.Forms.TextBox ();
			this.btnGetMake = new System.Windows.Forms.Button ();
			this.btnChange = new System.Windows.Forms.Button ();
			this.btnMakeDataTable = new System.Windows.Forms.Button ();
			ColtsViewGrid.BeginInit ();
			RedCarViewGrid.BeginInit ();
			CarDataGrid.BeginInit ();
			//@this.TrayHeight = 0;
			//@this.TrayLargeIcon = false;
			//@this.TrayAutoArrange = true;
			txtMake.Location = new System.Drawing.Point (128, 72);
			txtMake.TabIndex = 3;
			txtMake.Size = new System.Drawing.Size (80, 20);
			ColtsViewGrid.Location = new System.Drawing.Point (16, 352);
			ColtsViewGrid.Size = new System.Drawing.Size (440, 72);
			ColtsViewGrid.DataMember = "";
			ColtsViewGrid.CaptionText = "Only Colts View";
			ColtsViewGrid.TabIndex = 8;
			ColtsViewGrid.CaptionFont = new System.Drawing.Font ("Microsoft Sans Serif", 10);
			RedCarViewGrid.Location = new System.Drawing.Point (16, 272);
			RedCarViewGrid.Size = new System.Drawing.Size (440, 72);
			RedCarViewGrid.DataMember = "";
			RedCarViewGrid.CaptionText = "Only Red Cars View";
			RedCarViewGrid.TabIndex = 7;
			RedCarViewGrid.CaptionFont = new System.Drawing.Font ("Microsoft Sans Serif", 10);
			btnRemoveRow.Location = new System.Drawing.Point (248, 64);
			btnRemoveRow.Size = new System.Drawing.Size (112, 32);
			btnRemoveRow.TabIndex = 4;
			btnRemoveRow.Text = "Remove row #";
			btnRemoveRow.Click += new System.EventHandler (this.btnRemoveRow_Click);
			CarDataGrid.Location = new System.Drawing.Point (16, 128);
			CarDataGrid.Size = new System.Drawing.Size (440, 136);
			CarDataGrid.DataMember = "";
			CarDataGrid.CaptionText = "All Cars (Default View)";
			CarDataGrid.TabIndex = 1;
			CarDataGrid.CaptionFont = new System.Drawing.Font ("Microsoft Sans Serif", 10);
			txtRemove.Location = new System.Drawing.Point (368, 72);
			txtRemove.TabIndex = 5;
			txtRemove.Size = new System.Drawing.Size (80, 20);
			btnGetMake.Location = new System.Drawing.Point (8, 64);
			btnGetMake.Size = new System.Drawing.Size (112, 32);
			btnGetMake.TabIndex = 2;
			btnGetMake.Text = "Get these makes:";
			btnGetMake.Click += new System.EventHandler (this.btnGetMakes_Click);
			btnChange.Location = new System.Drawing.Point (248, 16);
			btnChange.Size = new System.Drawing.Size (192, 32);
			btnChange.TabIndex = 6;
			btnChange.Text = "Change all Beemers to Colts";
			btnChange.Click += new System.EventHandler (this.btnChange_Click);
			btnMakeDataTable.Location = new System.Drawing.Point (8, 16);
			btnMakeDataTable.Size = new System.Drawing.Size (112, 32);
			btnMakeDataTable.TabIndex = 0;
			btnMakeDataTable.Text = "Make DataTable";
			btnMakeDataTable.Click += new System.EventHandler (this.btnMakeDataTable_Click);
			this.Text = "Car Data Table";
			this.AutoScaleBaseSize = new System.Drawing.Size (5, 13);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.ClientSize = new System.Drawing.Size (466, 439);
			this.Controls.Add (this.ColtsViewGrid);
			this.Controls.Add (this.RedCarViewGrid);
			this.Controls.Add (this.btnChange);
			this.Controls.Add (this.txtRemove);
			this.Controls.Add (this.btnRemoveRow);
			this.Controls.Add (this.txtMake);
			this.Controls.Add (this.btnGetMake);
			this.Controls.Add (this.CarDataGrid);
			this.Controls.Add (this.btnMakeDataTable);
			ColtsViewGrid.EndInit ();
			RedCarViewGrid.EndInit ();
			CarDataGrid.EndInit ();
		}

		protected void btnChange_Click (object sender, System.EventArgs e)
		{
			// Build a filter.
			string filterStr = "Make='BMW'";
			string strMake = null;
			// Find all rows matching the filter.
			DataRow[] makes = 
				inventoryTable.Select(filterStr);

			// Change all!
			for(int i = 0; i < makes.Length; i++)
			{
				DataRow temp = makes[i];
				strMake += temp["Make"] = "Colt";		
				makes[i] = temp;
			}
		}

		protected void btnRemoveRow_Click (object sender, System.EventArgs e)
		{
			try
			{				
				inventoryTable.Rows[(int.Parse(txtRemove.Text))].Delete();
				inventoryTable.AcceptChanges();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		protected void btnGetMakes_Click (object sender, System.EventArgs e)
		{
			// Build a filter based on user input.
			string filterStr = "Make='" + txtMake.Text + "'";
			string strMake = null;
			// Find all rows matching the filter.
			DataRow[] makes = 
				inventoryTable.Select(filterStr);

			// Show what we got!
			if(makes.Length == 0)
			{
				MessageBox.Show("Sorry, no cars...", "Selection error!");
			}
			else
			{						
				for(int i = 0; i < makes.Length; i++)
				{
					DataRow temp = makes[i];
					strMake += temp["PetName"].ToString() + "\n";
					
				}
				MessageBox.Show(strMake, txtMake.Text + " type(s):");
			}

			// Now show the petnames of all cars 
			// with carID greater than 1030.
			DataRow[] properIDs;
			string newFilterStr = "ID > '1030'";
			properIDs = inventoryTable.Select(newFilterStr);
			string strIDs = null;

			for(int i = 0; i < properIDs.Length; i++)
			{
				DataRow temp = properIDs[i];
				strIDs += temp["PetName"].ToString() 
					   + " is ID " + temp["ID"] + "\n";				
			}
			MessageBox.Show(strIDs, "Pet names of cars where ID > 1030");
		}

		protected void btnMakeDataTable_Click (object sender, System.EventArgs e)
		{
			// Make a data table.
			MakeTable();	

			// Make Views.
			CreateViews();

			// Done. Disable button.
			btnMakeDataTable.Enabled = false;
		}

        public static void Main(string[] args) 
        {
            Application.Run(new CarDTForm());
        }

		private void MakeTable()
		{			
			// DataColumn var.
			DataColumn myDataColumn;

			// Create ID column and add to table.
			myDataColumn = new DataColumn();
			myDataColumn.DataType = Type.GetType("System.Int32");
			myDataColumn.ColumnName = "ID";
			myDataColumn.ReadOnly = true;
			myDataColumn.AllowDBNull = false;
			myDataColumn.Unique = true;
			
			// Set the auto increment behavior.
			myDataColumn.AutoIncrement = true;
			myDataColumn.AutoIncrementSeed = 1000;
			myDataColumn.AutoIncrementStep = 10;
			
			inventoryTable.Columns.Add(myDataColumn);

			// Create Make column and add to table.    
			myDataColumn = new DataColumn();
			myDataColumn.DataType = Type.GetType("System.String");
			myDataColumn.ColumnName = "Make";
			inventoryTable.Columns.Add(myDataColumn);

			// Create Color column and add to table.
			myDataColumn = new DataColumn();
			myDataColumn.DataType = Type.GetType("System.String");
			myDataColumn.ColumnName = "Color";
			inventoryTable.Columns.Add(myDataColumn);
		   
			// Create PetName column and add to table.
			myDataColumn = new DataColumn();
			myDataColumn.DataType = Type.GetType("System.String");
			myDataColumn.ColumnName = "PetName";
			myDataColumn.AllowDBNull = true;
			inventoryTable.Columns.Add(myDataColumn);

			// Make the ID column the primary key column.
			DataColumn[] PK = new DataColumn[1];
			PK[0] = inventoryTable.Columns["ID"];
			inventoryTable.PrimaryKey = PK;

			// Iterate over the array list to make rows.
			foreach(Car c in arTheCars)
			{
				DataRow newRow;
				newRow = inventoryTable.NewRow();
				newRow["Make"] = c.make;
				newRow["Color"] = c.color;
				newRow["PetName"] = c.petName;
				inventoryTable.Rows.Add(newRow);
			}
			
			// Bind to grid.
			CarDataGrid.DataSource = inventoryTable;			
		}	
	
		private void CreateViews()
		{
			// Set the table which is used for these views.
			redCarsView = new DataView(inventoryTable);
			coltsView = new DataView(inventoryTable);

			// Now configure the views...
			redCarsView.RowFilter = "Color = 'red'";
			coltsView.RowFilter = "Make = 'colt'";

			// Bind to grids...
			RedCarViewGrid.DataSource = redCarsView;
			ColtsViewGrid.DataSource = coltsView;
		}
    }
}
