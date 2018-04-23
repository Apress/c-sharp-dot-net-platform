namespace PenApp
{
	using System;
	using System.Drawing;
	using System.Drawing.Drawing2D;
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
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			CenterToScreen();
			SetStyle(ControlStyles.ResizeRedraw, true);	
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
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(292, 273);
			this.Text = "Pens...";
			this.Resize += new System.EventHandler(this.Form1_Resize);
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

		private void MainForm_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			Graphics g = e.Graphics;

			// Make a big blue pen.
			Pen bluePen = new Pen(Color.Blue, 20);
			
			// Get a stock pen from the Pens type.
			Pen pen2 = Pens.Firebrick;


			// NOTE!  In Beta 2, you are no longer able
			// to change the state of a Pen you receive from
			// the Pens type.
			// pen2.Width = 5;

			// Render some shapes with the pens.
			g.DrawEllipse(bluePen, 10, 10, 100, 100);
			g.DrawLine(pen2, 10, 130, 110, 130);
			g.DrawPie(Pens.Black, 150, 10, 120, 150, 90, 80);

			// Draw a pruple dashed polygon as well...
			Pen pen3 = new Pen(Color.Purple, 5);
			pen3.DashStyle = DashStyle.DashDotDot;

			g.DrawPolygon(pen3, new Point[]{new Point(30, 140),
											   new Point(265, 200),
											   new Point(100, 225),
											   new Point(190, 190),
											   new Point(50, 330),
											   new Point(20, 180)} );

			// And a rect with some text...
			Rectangle r = new Rectangle(150, 10, 130, 60);
			g.DrawRectangle(Pens.Blue, r);
			g.DrawString("Hello out there...How are ya?", 
				new Font("Arial", 12), Brushes.Black, r);

			// A custom dash...
			Pen customDashPen = new Pen(Color.BlueViolet, 5);
			float[] myDashes = {5.0f, 2.0f, 1.0f, 3.0f};
			customDashPen.DashPattern = myDashes;
			g.DrawRectangle(customDashPen, ClientRectangle);

		}

		private void Form1_Resize(object sender, System.EventArgs e)
		{
			// Invalidate();  See ctor!
		}
	}
}
