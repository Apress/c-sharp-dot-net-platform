namespace DataSetClient
{
	using System;
	using System.Drawing;
	using System.Collections;
	using System.ComponentModel;
	using System.Windows.Forms;
	using System.Data;

	/// <summary>
	///		Summary description for Form1.
	/// </summary>
	public class mainForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.Button btnGetCar;
		private System.Windows.Forms.TextBox txtCarToGet;
		private System.Windows.Forms.Button btnArrayList;
		/// <summary>
		///		Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components;

		public mainForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
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
			this.btnArrayList = new System.Windows.Forms.Button();
			this.txtCarToGet = new System.Windows.Forms.TextBox();
			this.btnGetCar = new System.Windows.Forms.Button();
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			this.btnArrayList.Location = new System.Drawing.Point(8, 216);
			this.btnArrayList.Size = new System.Drawing.Size(128, 24);
			this.btnArrayList.TabIndex = 3;
			this.btnArrayList.Text = "Get Array List";
			this.btnArrayList.Click += new System.EventHandler(this.btnArrayList_Click);
			this.txtCarToGet.Location = new System.Drawing.Point(144, 176);
			this.txtCarToGet.Size = new System.Drawing.Size(104, 20);
			this.txtCarToGet.TabIndex = 2;
			this.btnGetCar.Location = new System.Drawing.Point(8, 176);
			this.btnGetCar.Size = new System.Drawing.Size(128, 23);
			this.btnGetCar.TabIndex = 1;
			this.btnGetCar.Text = "Get Car From List";
			this.btnGetCar.Click += new System.EventHandler(this.btnGetCar_Click);
			this.dataGrid1.AlternatingBackColor = System.Drawing.Color.WhiteSmoke;
			this.dataGrid1.BackColor = System.Drawing.Color.Gainsboro;
			this.dataGrid1.BackgroundColor = System.Drawing.Color.DarkGray;
			this.dataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.dataGrid1.CaptionBackColor = System.Drawing.Color.DarkKhaki;
			this.dataGrid1.CaptionFont = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
			this.dataGrid1.CaptionForeColor = System.Drawing.Color.Black;
			this.dataGrid1.CaptionText = "Data from the Web Service!";
			this.dataGrid1.DataMember = "";
			this.dataGrid1.FlatMode = true;
			this.dataGrid1.Font = new System.Drawing.Font("Times New Roman", 9F);
			this.dataGrid1.ForeColor = System.Drawing.Color.Black;
			this.dataGrid1.GridLineColor = System.Drawing.Color.Silver;
			this.dataGrid1.HeaderBackColor = System.Drawing.Color.Black;
			this.dataGrid1.HeaderFont = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
			this.dataGrid1.HeaderForeColor = System.Drawing.Color.White;
			this.dataGrid1.LinkColor = System.Drawing.Color.DarkSlateBlue;
			this.dataGrid1.LinkHoverColor = System.Drawing.Color.Firebrick;
			this.dataGrid1.Location = new System.Drawing.Point(8, 16);
			this.dataGrid1.ParentRowsBackColor = System.Drawing.Color.LightGray;
			this.dataGrid1.ParentRowsForeColor = System.Drawing.Color.Black;
			this.dataGrid1.SelectionBackColor = System.Drawing.Color.Firebrick;
			this.dataGrid1.SelectionForeColor = System.Drawing.Color.White;
			this.dataGrid1.Size = new System.Drawing.Size(336, 144);
			this.dataGrid1.TabIndex = 0;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(355, 256);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {this.btnArrayList,
																		  this.txtCarToGet,
																		  this.btnGetCar,
																		  this.dataGrid1});
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Web Service Client";
			this.Load += new System.EventHandler(this.mainForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();

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

		private void mainForm_Load(object sender, System.EventArgs e)
		{
			localhost.CarService s = new localhost.CarService();
			DataSet ds = s.GetAllCars();
			dataGrid1.DataSource = ds.Tables["Inventory"];
			s.Dispose();
		}

		private void btnGetCar_Click(object sender, System.EventArgs e)
		{
			try
			{
				localhost.Car c;
				localhost.CarService cws = new localhost.CarService();
				c = cws.GetACarFromList(int.Parse(txtCarToGet.Text));
				MessageBox.Show(c.petName, "Car " + txtCarToGet.Text 
					+ " is named:");
				cws.Dispose();
			}
			catch
			{
				MessageBox.Show("No car with that number...");
			}
			
		}

		private void btnArrayList_Click(object sender, System.EventArgs e)
		{
			localhost.CarService cws = new localhost.CarService();
			object[] objs = cws.GetCarList();
			string petNames = "";
	
			// Print out pet name of each item in object array.	
			for(int i = 0; i< objs.Length; i++)
			{
				// Extract next car!
				localhost.Car c = (localhost.Car)objs[i];
				petNames += c.petName + "\n";	
			}
			
			MessageBox.Show(petNames, "Pet names for cars in array list:");
			cws.Dispose();
		}
	}
}
