namespace FontFamily
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
			this.components = new System.ComponentModel.Container();
			this.Size = new System.Drawing.Size(300,300);
			this.Text = "All in the family...";
			this.AutoScaleBaseSize = new System.Drawing.Size (5, 13);
			this.ClientSize = new System.Drawing.Size (392, 237);
			this.Paint += new System.Windows.Forms.PaintEventHandler (this.OnPaint);

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

		protected void OnPaint (object sender, System.Windows.Forms.PaintEventArgs e)
		{
			Graphics g = e.Graphics;

			FontFamily myFamily = new FontFamily("Verdana");
			Font myFont = new Font(myFamily, 12);
			
			int y = 0;
			int fontHeight = myFont.Height;

			// Show units of measurement.
			this.Text = "Measurements are in GraphicsUnit." + myFont.Unit.ToString();

			g.DrawString("The Verdana family.", myFont, Brushes.Blue, 10, y);
			y += 20;

			// Print our Family ties...
			g.DrawString("Ascent for bold Verdana: " + myFamily.GetCellAscent(FontStyle.Bold),
				myFont, Brushes.Black, 10, y + fontHeight);
			y += 20;

			g.DrawString("Descent for bold Verdana: " + myFamily.GetCellDescent(FontStyle.Bold),
				myFont, Brushes.Black, 10, y + fontHeight);
			y += 20;

			g.DrawString("Line spacing for bold Verdana: " + myFamily.GetLineSpacing(FontStyle.Bold),
				myFont, Brushes.Black, 10, y + fontHeight);
			y += 20;

			g.DrawString("Height for bold Verdana: " + myFamily.GetEmHeight(FontStyle.Bold),
				myFont, Brushes.Black, 10, y + fontHeight);
			y += 20;
		}

	}
}
