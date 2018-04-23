namespace MultiTableDataSet
{
	using System;
	using System.Drawing;
	using System.Collections;
	using System.ComponentModel;
	using System.Windows.Forms;
	using System.Data;
	using System.Data.SqlClient;

	/// <summary>
	///		Summary description for Form1.
	/// </summary>
	public class mainForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.DataGrid custGrid;
		private System.Windows.Forms.DataGrid inventoryGrid;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.DataGrid OrdersGrid;
		private System.ComponentModel.Container components;

		// Here is the connection.
		private SqlConnection cn = new SqlConnection("server=(local);uid=sa;pwd=;database=Cars");

		// Our data adapters (for each table).
		private SqlDataAdapter invTableAdapter;
		private SqlDataAdapter custTableAdapter;
		private SqlDataAdapter ordersTableAdapter;

		// Command builders.
		private SqlCommandBuilder invBuilder = new SqlCommandBuilder(); 
		private SqlCommandBuilder orderBuilder = new SqlCommandBuilder(); 
		private SqlCommandBuilder custBuilder = new SqlCommandBuilder(); 

		// The dataset.
		DataSet carsDS = new DataSet();

		public mainForm()
		{
			InitializeComponent();
			
			// Create adapters.
			invTableAdapter = new SqlDataAdapter("Select * from Inventory", cn);
			custTableAdapter = new SqlDataAdapter("Select * from Customers", cn);
			ordersTableAdapter = new SqlDataAdapter("Select * from Orders", cn);

			// Auto gen commands.
			invBuilder = new SqlCommandBuilder(invTableAdapter);
			orderBuilder = new SqlCommandBuilder(ordersTableAdapter);
			custBuilder = new SqlCommandBuilder(custTableAdapter);
			
			// Fill tables into DS.
			invTableAdapter.Fill(carsDS, "Inventory");
			custTableAdapter.Fill(carsDS, "Customers");
			ordersTableAdapter.Fill(carsDS, "Orders");

			// Build relations.
			BuildTableRelationship();		
		}

		/// <summary>
		///		Clean up any resources being used.
		/// </summary>
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


		#region Windows Form Designer generated code
		/// <summary>
		///		Required method for Designer support - do not modify
		///		the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnUpdate = new System.Windows.Forms.Button();
			this.custGrid = new System.Windows.Forms.DataGrid();
			this.inventoryGrid = new System.Windows.Forms.DataGrid();
			this.OrdersGrid = new System.Windows.Forms.DataGrid();
			((System.ComponentModel.ISupportInitialize)(this.custGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.inventoryGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.OrdersGrid)).BeginInit();
			this.btnUpdate.Location = new System.Drawing.Point(16, 384);
			this.btnUpdate.TabIndex = 2;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			this.custGrid.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			this.custGrid.CaptionText = "Customers";
			this.custGrid.DataMember = "";
			this.custGrid.Location = new System.Drawing.Point(16, 136);
			this.custGrid.Size = new System.Drawing.Size(336, 104);
			this.custGrid.TabIndex = 1;
			this.inventoryGrid.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			this.inventoryGrid.CaptionText = "Inventory";
			this.inventoryGrid.DataMember = "";
			this.inventoryGrid.Location = new System.Drawing.Point(16, 16);
			this.inventoryGrid.Size = new System.Drawing.Size(336, 104);
			this.inventoryGrid.TabIndex = 0;
			this.OrdersGrid.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			this.OrdersGrid.CaptionText = "Orders";
			this.OrdersGrid.DataMember = "";
			this.OrdersGrid.Location = new System.Drawing.Point(16, 256);
			this.OrdersGrid.Size = new System.Drawing.Size(336, 104);
			this.OrdersGrid.TabIndex = 1;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(371, 440);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {this.btnUpdate,
																		  this.OrdersGrid,
																		  this.custGrid,
																		  this.inventoryGrid});
			this.Text = "Multi-Table DataSet";
			((System.ComponentModel.ISupportInitialize)(this.custGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.inventoryGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.OrdersGrid)).EndInit();

		}
		#endregion

		/// <summary>
		/// 	The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new mainForm());
		}

		private void BuildTableRelationship()
		{
			// Create a DR obj.
			DataRelation dr = new DataRelation("CustomerOrder", 
				carsDS.Tables["Customers"].Columns["CustID"],		
				carsDS.Tables["Orders"].Columns["CustID"]);
							
			// Add to the DataSet.
			carsDS.Relations.Add(dr);

			// Create another DR obj.
			dr = new DataRelation("InventoryOrder", 
				carsDS.Tables["Inventory"].Columns["CarID"],
				carsDS.Tables["Orders"].Columns["CarID"]);

			// Add to the DataSet.
			carsDS.Relations.Add(dr);

			// Fill the grids!
			inventoryGrid.SetDataBinding(carsDS, "Inventory");
			custGrid.SetDataBinding(carsDS, "Customers");
			OrdersGrid.SetDataBinding(carsDS, "Orders");
		}

		private void btnUpdate_Click(object sender, System.EventArgs e)
		{
			try
			{
				invTableAdapter.Update(carsDS, "Inventory");
				custTableAdapter.Update(carsDS, "Customers");
				ordersTableAdapter.Update(carsDS, "Orders");
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

	}
}
