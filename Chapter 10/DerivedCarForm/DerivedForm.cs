namespace DerivedCarForm
{
	using System;
	using System.Drawing;
	using System.Collections;
	using System.ComponentModel;
	using System.Windows.Forms;
	using System.Data;

	// The base form.
	using CarConfig;

	/// <summary>
	///		Summary description for Form1.
	/// </summary>
	public class DerivedForm : CarConfig.CarConfigForm
	{
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem mnuFileExit;
		/// <summary>
		///		Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components;

		public DerivedForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			CenterToScreen();

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
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.mnuFileExit = new System.Windows.Forms.MenuItem();
			this.menuItem1.Index = 0;
			this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {this.mnuFileExit});
			this.menuItem1.Text = "File";
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {this.menuItem1});
			this.mnuFileExit.Index = 0;
			this.mnuFileExit.Text = "Exit This Application......";
			this.mnuFileExit.Click += new System.EventHandler(this.mnuFileExit_Click);
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(459, 498);
			this.Controls.AddRange(new System.Windows.Forms.Control[0]);
			this.Location = new System.Drawing.Point(0, 0);
			this.Menu = this.mainMenu1;
			this.Text = "Form1";

		}
		#endregion

		/// <summary>
		/// 	The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new DerivedForm());
		}

		private void mnuFileExit_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
	}
}
