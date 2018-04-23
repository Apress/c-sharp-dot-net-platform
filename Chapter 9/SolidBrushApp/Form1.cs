namespace SolidBrushApp
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
	public class Form1 : System.Windows.Forms.Form
	{
		/// <summary>
		///		Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components;

		public Form1()
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
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(292, 273);
			this.Text = "Solid Brushes...";
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);

		}
		#endregion

		/// <summary>
		/// 	The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void Form1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			Graphics g = e.Graphics;

			// Make a blue SolidBrush.
			SolidBrush blueBrush = new SolidBrush(Color.Blue);
			
			// Get a stock brush from the Brushes type.
			SolidBrush pen2 = (SolidBrush)Brushes.Firebrick;

			// Render some shapes with the brushes.
			g.FillEllipse(blueBrush, 10, 10, 100, 100);
			g.FillPie(Brushes.Black, 150, 10, 120, 150, 90, 80);

			// Draw a purple dashed polygon as well...
			SolidBrush brush3= new SolidBrush(Color.Purple);

			g.FillPolygon(brush3, new Point[]{new Point(30, 140),
												 new Point(265, 200),
												 new Point(100, 225),
												 new Point(190, 190),
												 new Point(50, 330),
												 new Point(20, 180)} );

			// And a rect with some text...
			Rectangle r = new Rectangle(150, 10, 130, 60);
			g.FillRectangle(Brushes.Blue, r);
			g.DrawString("Hello out there...How are ya?", 
				new Font("Arial", 12), Brushes.White, r);

		}
	}
}
