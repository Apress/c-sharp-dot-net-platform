namespace DraggingImages
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

		// Data used to move the picture box around.
		private bool  isDragging = false;
		private int   oldX, oldY;

		// The drop box.
		Rectangle dropRect = new Rectangle(100, 100, 150, 150);

		// This holds the image.
		private PictureBox happyBox; 

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			CenterToScreen();

			// Configure the PictureBox.
			happyBox = new PictureBox();
			happyBox.SizeMode = PictureBoxSizeMode.StretchImage;
			happyBox.Location = new System.Drawing.Point(64, 32);
			happyBox.Size = new System.Drawing.Size(50, 50);
			happyBox.Image = new Bitmap("happy.bmp");
			happyBox.MouseDown += new MouseEventHandler(happyBox_MouseDown);
			happyBox.MouseUp += new MouseEventHandler(happyBox_MouseUp);
			happyBox.MouseMove += new MouseEventHandler(happyBox_MouseMove);
			happyBox.Cursor = Cursors.Hand;

			// Now add to the Form's Controls collection.
			Controls.Add(happyBox);
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
			this.Text = "Dragging Images";
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

		// Mouse event handler to initiate dragging the pictureBox around
		private void happyBox_MouseDown(object sender, MouseEventArgs e) 
		{
			isDragging = true;
			
			// Save the (x, y) of the mouse down click, 
			// because we need them as an offset when
			// dragging the image.
			oldX = e.X;
			oldY = e.Y;
		}

		// If the user clicks on the image and moves the mouse,
		// redraw the iamge at the new location.
		private void happyBox_MouseMove(object sender, MouseEventArgs e) 
		{
			if (isDragging) 
			{
				// Need to figure new Y value based on where the mouse
				// down click happened.
				happyBox.Top = happyBox.Top + (e.Y - oldY);

				// Same deal for X (use oldX as a base line).
				happyBox.Left = happyBox.Left + (e.X - oldX);
			}
		}

		// When the mouse goes up, the are done dragging.
		// See if they dropped the image in the rectangle...
		private void happyBox_MouseUp(object sender, MouseEventArgs e) 
		{
			isDragging = false;

			if(dropRect.Contains(happyBox.Bounds))
			{
				MessageBox.Show("You win!", "What an amazing test of skill...");
			}
		}

		private void Form1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			Graphics g = e.Graphics;
			g.FillRectangle(Brushes.AntiqueWhite, dropRect);

			// Display instructions.
			g.DrawString("Drag the happy guy in here...", new Font("Times New Roman", 25),
				Brushes.Red, dropRect);
		}
	}
}
