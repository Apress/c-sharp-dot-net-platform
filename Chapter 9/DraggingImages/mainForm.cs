namespace Images
{
    using System;
    using System.Drawing;
    using System.Collections;
    using System.ComponentModel;
    using System.WinForms;
    using System.Data;

    public class Form1 : System.WinForms.Form
    {
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

        public override void Dispose()
        {
            base.Dispose();
            components.Dispose();
        }

        private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container ();
			//@this.TrayHeight = 0;
			//@this.TrayLargeIcon = false;
			//@this.TrayAutoArrange = true;
			this.Text = "Dragging Images";
			this.AutoScaleBaseSize = new System.Drawing.Size (5, 13);
			this.ClientSize = new System.Drawing.Size (368, 357);
			this.Paint += new System.WinForms.PaintEventHandler (this.OnPaint);
		}

		protected void OnPaint (object sender, System.WinForms.PaintEventArgs e)
		{
			Graphics g = e.Graphics;
			g.FillRectangle(Brushes.AntiqueWhite, dropRect);

			// Display instructions.
			g.DrawString("Drag the happy guy in here...", new Font("Times New Roman", 25),
				         Brushes.Red, dropRect);
		}

        public static void Main(string[] args) 
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
}
}
