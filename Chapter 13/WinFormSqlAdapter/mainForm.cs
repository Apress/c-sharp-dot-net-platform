namespace WinFormSqlAdapter
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
		private SqlConnection cn = new SqlConnection("server=(local);uid=sa;pwd=;database=Cars");
		private SqlDataAdapter dAdapt;
		private SqlCommandBuilder invBuilder; 
		private DataSet myDS = new DataSet();
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.Button btnUpdateData;

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

			// Create the SELECT SQL statement.
			dAdapt = new SqlDataAdapter("Select * from Inventory", cn);

			// Auto generate the INSERT, UPDATE and DELETE statements.
			invBuilder = new SqlCommandBuilder(dAdapt);

			// Fill and bind.
			dAdapt.Fill(myDS, "Inventory");
			dataGrid1.DataSource = myDS.Tables["Inventory"].DefaultView;
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
			cn.Close();
		}


		#region Windows Form Designer generated code
		/// <summary>
		///		Required method for Designer support - do not modify
		///		the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnUpdateData = new System.Windows.Forms.Button();
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			this.btnUpdateData.Location = new System.Drawing.Point(8, 224);
			this.btnUpdateData.Size = new System.Drawing.Size(128, 23);
			this.btnUpdateData.TabIndex = 1;
			this.btnUpdateData.Text = "Submit Changes";
			this.btnUpdateData.Click += new System.EventHandler(this.btnUpdateData_Click);
			this.dataGrid1.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			this.dataGrid1.CaptionText = "Inventory";
			this.dataGrid1.DataMember = "";
			this.dataGrid1.Location = new System.Drawing.Point(8, 16);
			this.dataGrid1.Size = new System.Drawing.Size(432, 184);
			this.dataGrid1.TabIndex = 0;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(451, 264);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.btnUpdateData,
																		  this.dataGrid1});
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Windows Data Adapter Client";
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

		private void btnUpdateData_Click(object sender, System.EventArgs e)
		{
			try
			{
				dataGrid1.Refresh();
				dAdapt.Update(myDS, "Inventory");
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}		
		}
	}
}
