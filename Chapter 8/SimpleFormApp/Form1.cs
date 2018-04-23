namespace SimpleFormApp
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
	public class MainForm : System.Windows.Forms.Form
	{
		/// <summary>
		///		Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components;

		public MainForm()
		{
			InitializeComponent();
			BackColor = Color.LemonChiffon;	// Background color.
			Text = "My Fantastic Form";		// Form’s caption.
			Size = new Size(200, 200);		// 200 * 200.
			CenterToScreen();				// Center Form to the screen.
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
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(292, 273);
			this.Text = "Form1";
			this.Resize += new System.EventHandler(this.MainForm_Resize);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);

		}
		#endregion

		/// <summary>
		/// 	The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new MainForm());
		}

		private void MainForm_Resize(object sender, System.EventArgs e)
		{
			Invalidate();
		}

		private void MainForm_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			Graphics g = e.Graphics;
			g.DrawString("Windows Forms is for building GUIs!", 
				new Font("Times New Roman", 20), 
				new SolidBrush(Color.Black), 
				this.DisplayRectangle);	   // Display in client rect.
		}
	}
}
