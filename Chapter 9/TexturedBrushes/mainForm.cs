namespace TexturedBrushes
{
    using System;
    using System.Drawing;
    using System.Collections;
    using System.ComponentModel;
    using System.WinForms;
    using System.Data;

    public class mainForm : System.WinForms.Form
    {
        private System.ComponentModel.Container components;
		
		// Data for the image brush.
		private Brush texturedTextBrush;
		private Brush texturedBGroundBrush;

        public mainForm()
        {
            InitializeComponent();

			// Load image for background brush.
			Image BGroundBrushImage = new Bitmap("Clouds.bmp");
			texturedBGroundBrush = new TextureBrush(BGroundBrushImage);

			// Now load image for text brush.
			Image textBrushImage = new Bitmap("Soap Bubbles.bmp");
			texturedTextBrush = new TextureBrush(textBrushImage);
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
			this.Text = "Texture Brush";
			this.AutoScaleBaseSize = new System.Drawing.Size (5, 13);
			this.Resize += new System.EventHandler (this.OnResize);
			this.Paint += new System.WinForms.PaintEventHandler (this.OnPaint);
		}

		protected void OnResize (object sender, System.EventArgs e)
		{
			Invalidate();
		}

		protected void OnPaint (object sender, System.WinForms.PaintEventArgs e)
		{
			Graphics g = e.Graphics;
			Rectangle r = ClientRectangle;

			// Paint the clouds on the client araa.
			g.FillRectangle(texturedBGroundBrush, r);

			// Some big bold text with a textured brush.
			g.DrawString("Bitmaps as brushes!  Way cool...",
				         new Font("Arial", 60, 
						 FontStyle.BoldItalic), 
						 texturedTextBrush,
				         r);
		}

        public static void Main(string[] args) 
        {
            Application.Run(new mainForm());
        }
    }
}
