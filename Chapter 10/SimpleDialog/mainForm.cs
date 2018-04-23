namespace SimpleDialog
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
		/// <summary>
		///		Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components;

		private System.Windows.Forms.MenuItem mnuModalBox;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MainMenu mainMenu1;
		
		private string dlgMsg = "Pick a menu item";

		public mainForm()
		{
			InitializeComponent();
			CenterToScreen();
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
			this.mnuModalBox = new System.Windows.Forms.MenuItem();
			this.menuItem1.Index = 0;
			this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {this.mnuModalBox});
			this.menuItem1.Text = "Dialogs";
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {this.menuItem1});
			this.mnuModalBox.Index = 0;
			this.mnuModalBox.Text = "Show Modal Box";
			this.mnuModalBox.Click += new System.EventHandler(this.mnuModalBox_Click);
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(240, 105);
			this.Menu = this.mainMenu1;
			this.Text = "Parent Form";
			this.Resize += new System.EventHandler(this.mainForm_Resize);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.mainForm_Paint);

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

		protected void mainForm_Resize (object sender, System.EventArgs e)
		{
			Invalidate();
		}

		protected void mainForm_Paint (object sender, System.Windows.Forms.PaintEventArgs e)
		{
			Graphics g = e.Graphics;
			g.DrawString(dlgMsg, new Font("times New Roman", 24),
				Brushes.Blue, this.ClientRectangle);
		}

		protected void mnuModalBox_Click (object sender, System.EventArgs e)
		{
			// Style props set in form.
			SomeCustomForm myForm = new SomeCustomForm();
			myForm.Message = dlgMsg;

			// Passing in a reference to the launching dialog is optional.
			myForm.ShowDialog(this);

			if(myForm.DialogResult == DialogResult.OK)
			{
				dlgMsg = myForm.Message;
				Invalidate();
			}

			DoSomeMoreWork();		
		}

		private void DoSomeMoreWork()
		{
			MessageBox.Show("OK, doing more work!");
		}
	}
}
