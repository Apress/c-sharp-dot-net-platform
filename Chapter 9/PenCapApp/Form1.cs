namespace PenCapApp
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
			this.Text = "Pen Cap App";
			this.Resize += new System.EventHandler(this.Form1_Resize);
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
			Pen thePen = new Pen(Color.Black, 10);
			int yOffSet = 10;

			// Get all members of the LineCap enum.
			Array obj = Enum.GetValues(typeof(LineCap));

			// Draw a line with a LineCap member.
			for(int x = 0; x < obj.Length; x++)
			{
				// Get next cap and configure pen.
				LineCap temp = (LineCap)obj.GetValue(x);
				thePen.StartCap = temp;
				thePen.EndCap = temp;

				// Print name of LineCap enum.
				g.DrawString(temp.ToString(), new Font("Times New Roman", 10), 
					new SolidBrush(Color.Black), 0, yOffSet);

				// Draw a line with the correct cap.
				g.DrawLine(thePen, 100, yOffSet, Width - 50, yOffSet);

				yOffSet += 40;
			}
		}

		private void Form1_Resize(object sender, System.EventArgs e)
		{
			Invalidate();
		}
	}
}
