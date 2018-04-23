namespace BasicPaintForm
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
		private ArrayList myPts = new ArrayList();

		public MainForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			CenterToScreen();
			this.Text = "Basic Paint Form (click on me)";

			// Could do this as well...
			// this.Paint += new System.WinForms.PaintEventHandler(MyPaintHandler);

		}

		/*
		public void MyPaintHandler(object sender, PaintEventArgs e)
		{
			Graphics g = e.Graphics;
		}
		*/

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
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
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

		private void MainForm_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			// Grab a new Graphics object.
			Graphics g = Graphics.FromHwnd(this.Handle);

			// Now draw a 10*10 circle at mouse click.
			// g.DrawEllipse(new Pen(Color.Green), e.X, e.Y, 10, 10);

			// Add to points collection.
			myPts.Add(new Point(e.X, e.Y));
			Invalidate();
		}

		private void MainForm_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			Graphics g = e.Graphics;
			g.DrawString("Hello GDI+", new Font("Times New Roman", 20), 
				new SolidBrush(Color.Black), 0, 0);

			foreach(Point p in myPts)
				g.DrawEllipse(new Pen(Color.Green), p.X, p.Y, 10, 10);
		}
	}
}
