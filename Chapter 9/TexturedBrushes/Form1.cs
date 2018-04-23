namespace TexturedBrushes
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
		
		// Data for the image brush.
		private Brush texturedTextBrush;
		private Brush texturedBGroundBrush;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			// Load image for background brush.
			Image BGroundBrushImage = new Bitmap("Clouds.bmp");
			texturedBGroundBrush = new TextureBrush(BGroundBrushImage);

			// Now load image for text brush.
			Image textBrushImage = new Bitmap("Soap Bubbles.bmp");
			texturedTextBrush = new TextureBrush(textBrushImage);
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
			this.Text = "Textured Brushes ...";
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

		private void Form1_Resize (object sender, System.EventArgs e)
		{
			Invalidate();
		}

		private void Form1_Paint (object sender, PaintEventArgs e)
		{
			Graphics g = e.Graphics;
			Rectangle r = ClientRectangle;

			// Paint the clouds on the client araa.
			g.FillRectangle(texturedBGroundBrush, r);

			// Some big bold text with a textured brush.
			g.DrawString("Bitmaps as brushes!  Way cool...",
				new Font("Arial", 60, 
				FontStyle.Bold), 
				texturedTextBrush,
				r);
		}
	}
}
