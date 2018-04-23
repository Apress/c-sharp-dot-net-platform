namespace CarLogApp
{
    using System;
    using System.Drawing;
    using System.Collections;
    using System.ComponentModel;
    using System.Windows.Forms;
    using System.Data;
	using System.IO;
	using System.Runtime.Serialization.Formatters.Binary;

	public class mainForm : System.Windows.Forms.Form
    {
        private System.ComponentModel.Container components;
		private System.Windows.Forms.MenuItem menuItemClear;
		private System.Windows.Forms.MenuItem menuItemOpen;
		private System.Windows.Forms.MenuItem menuItemSave;
		private System.Windows.Forms.MenuItem menuItemExit;
		private System.Windows.Forms.MenuItem menuItemNewCar;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MainMenu mainMenu;
		private System.Windows.Forms.DataGrid carDataGrid;

		// List for object serialization.
		private ArrayList arTheCars;

        public mainForm()
        {
            InitializeComponent();
			CenterToScreen();
			
			// Add some cars.
			arTheCars = new ArrayList();
			arTheCars.Add(new Car("Siddhartha", "BMW", "Silver"));
			arTheCars.Add(new Car("Chucky", "Caravan", "Pea Soup Green"));
			arTheCars.Add(new Car("Fred", "Audi TT", "Red"));
			UpdateGrid();
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


		#region Stuff we really don't care about...

		private void InitializeComponent()
		{
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.carDataGrid = new System.Windows.Forms.DataGrid();
			this.menuItemExit = new System.Windows.Forms.MenuItem();
			this.menuItemNewCar = new System.Windows.Forms.MenuItem();
			this.menuItemOpen = new System.Windows.Forms.MenuItem();
			this.menuItemSave = new System.Windows.Forms.MenuItem();
			this.mainMenu = new System.Windows.Forms.MainMenu();
			this.menuItemClear = new System.Windows.Forms.MenuItem();
			((System.ComponentModel.ISupportInitialize)(this.carDataGrid)).BeginInit();
			this.menuItem1.Index = 0;
			this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {this.menuItemNewCar,
																					  this.menuItemClear,
																					  this.menuItemOpen,
																					  this.menuItemSave,
																					  this.menuItemExit});
			this.menuItem1.Text = "&File";
			this.carDataGrid.AlternatingBackColor = System.Drawing.Color.White;
			this.carDataGrid.BackColor = System.Drawing.Color.White;
			this.carDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.carDataGrid.CaptionBackColor = System.Drawing.Color.Teal;
			this.carDataGrid.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
			this.carDataGrid.CaptionForeColor = System.Drawing.Color.White;
			this.carDataGrid.CaptionText = "Car Inventory";
			this.carDataGrid.DataMember = "";
			this.carDataGrid.FlatMode = true;
			this.carDataGrid.Font = new System.Drawing.Font("Tahoma", 8F);
			this.carDataGrid.ForeColor = System.Drawing.Color.Black;
			this.carDataGrid.GridLineColor = System.Drawing.Color.Silver;
			this.carDataGrid.HeaderBackColor = System.Drawing.Color.Black;
			this.carDataGrid.HeaderFont = new System.Drawing.Font("Tahoma", 8F);
			this.carDataGrid.HeaderForeColor = System.Drawing.Color.White;
			this.carDataGrid.LinkColor = System.Drawing.Color.Purple;
			this.carDataGrid.LinkHoverColor = System.Drawing.Color.Fuchsia;
			this.carDataGrid.Location = new System.Drawing.Point(8, 40);
			this.carDataGrid.ParentRowsBackColor = System.Drawing.Color.Gray;
			this.carDataGrid.ParentRowsForeColor = System.Drawing.Color.White;
			this.carDataGrid.SelectionBackColor = System.Drawing.Color.Maroon;
			this.carDataGrid.SelectionForeColor = System.Drawing.Color.White;
			this.carDataGrid.Size = new System.Drawing.Size(416, 144);
			this.carDataGrid.TabIndex = 0;
			this.menuItemExit.Index = 4;
			this.menuItemExit.Text = "E&xit";
			this.menuItemExit.Click += new System.EventHandler(this.menuItemExit_Click);
			this.menuItemNewCar.DefaultItem = true;
			this.menuItemNewCar.Index = 0;
			this.menuItemNewCar.Text = "&Make New Car";
			this.menuItemNewCar.Click += new System.EventHandler(this.menuItemNewCar_Click);
			this.menuItemOpen.Index = 2;
			this.menuItemOpen.Text = "&Open Car File";
			this.menuItemOpen.Click += new System.EventHandler(this.menuItemOpen_Click);
			this.menuItemSave.Index = 3;
			this.menuItemSave.Text = "&Save Car File";
			this.menuItemSave.Click += new System.EventHandler(this.menuItemSave_Click);
			this.mainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {this.menuItem1});
			this.menuItemClear.Index = 1;
			this.menuItemClear.Text = "&Clear All Cars";
			this.menuItemClear.Click += new System.EventHandler(this.menuItem2_Click);
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.ClientSize = new System.Drawing.Size(434, 195);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {this.carDataGrid});
			this.Menu = this.mainMenu;
			this.Text = "Car Logger Application";
			((System.ComponentModel.ISupportInitialize)(this.carDataGrid)).EndInit();

		}
		#endregion
		
		protected void menuItem2_Click (object sender, System.EventArgs e)
		{
			arTheCars.Clear();
			UpdateGrid();
		}

		protected void menuItemExit_Click (object sender, System.EventArgs e)
		{
			Application.Exit();
		}

		protected void menuItemSave_Click (object sender, System.EventArgs e)
		{
			// Configure look and feel of save dlg.
			SaveFileDialog mySaveFileDialog = new SaveFileDialog();
			mySaveFileDialog.InitialDirectory = ".";
			mySaveFileDialog.Filter = "car files (*.car)|*.car|All files (*.*)|*.*"  ;
			mySaveFileDialog.FilterIndex = 1 ;
			mySaveFileDialog.RestoreDirectory = true ;
			mySaveFileDialog.FileName = "carDoc";
			
			// Do we have a file?
			if(mySaveFileDialog.ShowDialog() == DialogResult.OK)
			{					
				Stream myStream = null;
				if((myStream = mySaveFileDialog.OpenFile()) != null)
				{
					// Save the cars!
					BinaryFormatter myBinaryFormat = new BinaryFormatter();
					myBinaryFormat.Serialize(myStream, arTheCars);
					myStream.Close();
				}  
			}
		}

		protected void menuItemOpen_Click (object sender, System.EventArgs e)
		{
			// Configure look and feel of open dlg.
			OpenFileDialog myOpenFileDialog = new OpenFileDialog();
			myOpenFileDialog.InitialDirectory = ".";
			myOpenFileDialog.Filter = "car files (*.car)|*.car|All files (*.*)|*.*"  ;
			myOpenFileDialog.FilterIndex = 1 ;
			myOpenFileDialog.RestoreDirectory = true ;

			// Do we have a file?
			if(myOpenFileDialog.ShowDialog() == DialogResult.OK)
			{
				// Clear list.
				arTheCars.Clear();
				Stream myStream = null;
				if((myStream = myOpenFileDialog.OpenFile()) != null)
				{					
					// Get the cars!
					BinaryFormatter myBinaryFormat = new BinaryFormatter();
					arTheCars = (ArrayList)myBinaryFormat.Deserialize(myStream);
					myStream.Close();
					UpdateGrid();
				}
			}
		}

		protected void menuItemNewCar_Click (object sender, System.EventArgs e)
		{
			AddCarDlg d = new AddCarDlg();
			if(d.ShowDialog() == DialogResult.OK)
			{
				// Add new car to arraylist.
				arTheCars.Add(d.theCar);
				UpdateGrid();
			}
		}

        public static void Main(string[] args) 
        {
            Application.Run(new mainForm());
        }

		private void UpdateGrid()
		{
			if(arTheCars != null)
			{
				// Make a DataTable object named Inventory.
				DataTable inventory = new DataTable("Inventory");
				
				// Create DataColumn objects.
				DataColumn make = new DataColumn("Car Make");
				DataColumn petName = new DataColumn("Pet Name");
				DataColumn color = new DataColumn("Car Color");
				
				// Add columns to data table.
				inventory.Columns.Add(petName);
				inventory.Columns.Add(make);
				inventory.Columns.Add(color);

				// Iterate over the array list to make rows.
				foreach(Car c in arTheCars)
				{
					DataRow newRow;
					newRow = inventory.NewRow();
					newRow["Pet Name"] = c.petName;
					newRow["Car Make"] = c.make;
					newRow["Car Color"] = c.color;
					inventory.Rows.Add(newRow);
				}

				// Now bind this data table to the grid.
				carDataGrid.DataSource = inventory;
			}
		}
    }
}
