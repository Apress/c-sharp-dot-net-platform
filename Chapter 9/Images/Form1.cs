namespace Images
{
	using System;
	using System.Drawing;
	using System.Drawing.Drawing2D;
	using System.Collections;
	using System.ComponentModel;
	using System.Windows.Forms;
	using System.Data;

	public class Form1 : System.Windows.Forms.Form
	{
		private System.ComponentModel.Container components;

		// The images.
		private Image bMapImageA;
		private Image bMapImageB;
		private Image bMapImageC;

		// Rects for the images.
		private Rectangle rectA = new Rectangle(10, 10, 90, 90);
		private Rectangle rectB = new Rectangle(10, 110, 90, 90);
		private Rectangle rectC = new Rectangle(10, 210, 90, 90);

		// A polygon region.
		GraphicsPath myPath = new GraphicsPath();

		// Did they click on an image?
		private bool isImageClicked = false;
		private int imageClicked;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			// Fill the images with bitmaps.
			bMapImageA = new Bitmap("imageA.bmp");
			bMapImageB = new Bitmap("imageB.bmp");
			bMapImageC = new Bitmap("imageC.bmp");

			// Create an interesting region.
			myPath.StartFigure();
			myPath.AddLine(new Point(150, 10), new Point(120, 150));
			myPath.AddArc(200, 200, 100, 100, 0, 90);
			Point point1 = new Point(250, 250);
			Point point2 = new Point(350, 275);
			Point point3 = new Point(350, 325);
			Point point4 = new Point(250, 350);
			Point[] points = {point1, point2, point3, point4};
			myPath.AddCurve(points);
			myPath.CloseFigure();

			CenterToScreen();
		}

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
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);

		}
		#endregion

		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void Form1_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			// Get (x, y) of mouse click.
			Point mousePt = new Point(e.X, e.Y);

			// See if the mouse is anywhere in the 3 regions...
			if(rectA.Contains(mousePt))
			{
				isImageClicked = true;
				imageClicked = 0;
				this.Text = "You clicked image A";
			}
			else if(rectB.Contains(mousePt))
			{
				isImageClicked = true;
				imageClicked = 1;
				this.Text = "You clicked image B";
			}
			else if(rectC.Contains(mousePt))
			{
				isImageClicked = true;
				imageClicked = 2;
				this.Text = "You clicked image C";
			}
			else if(myPath.IsVisible(mousePt))
			{
				isImageClicked = true;
				imageClicked = 3;
				this.Text = "You clicked the strange shape...";
			}
			else	// Not in any shape, set defaults.
			{
				isImageClicked = false;
				this.Text = "Images";
			}
				
			// Redraw the client area.
			Invalidate();
		}

		private void Form1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			Graphics g = e.Graphics;

			// Render all three images.
			g.DrawImage(bMapImageA, rectA);
			g.DrawImage(bMapImageB, rectB);
			g.DrawImage(bMapImageC, rectC);

			// Draw the graphics path.
			g.FillPath(Brushes.AliceBlue, myPath);

			// Draw outline (if clicked...)
			if(isImageClicked == true)
			{
				Pen outline = new Pen(Color.Red, 5);

				switch(imageClicked)
				{
					case 0:
						g.DrawRectangle(outline, rectA);
						break;
					
					case 1:
						g.DrawRectangle(outline, rectB);
						break;
					
					case 2:
						g.DrawRectangle(outline, rectC);
						break;

					case 3:
						g.DrawPath(outline, myPath);
						break;

					default:
						break;
				}
			}
		}
	}
}
