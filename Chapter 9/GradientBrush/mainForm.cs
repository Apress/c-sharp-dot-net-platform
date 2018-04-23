namespace GradientBrush
{
    using System;
    using System.Drawing;
    using System.Drawing.Drawing2D;
    using System.Collections;
    using System.ComponentModel;
    using System.WinForms;
    using System.Data;

    public class Form1 : System.WinForms.Form
    {
        private System.ComponentModel.Container components;

        public Form1()
        {
            InitializeComponent();
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
			this.Text = "Gradient Brushes";
			this.AutoScaleBaseSize = new System.Drawing.Size (5, 13);
			this.Paint += new System.WinForms.PaintEventHandler (this.OnPaint);
		}

		protected void OnPaint(object sender, PaintEventArgs e) 
		{
            Graphics g = e.Graphics;
            Rectangle r = new Rectangle(10, 10, 100, 100);

			// A gradient brush.
			LinearGradientBrush theBrush = null;
			int yOffSet = 10;

			// Get all members of the LinearGradientMode enum.
			Object[] obj = Enum.GetValues(typeof(LinearGradientMode));

			// Draw an oval with a LinearGradientMode member.
			for(int x = 0; x < obj.Length; x++)
			{
				// Configure Brush.
				LinearGradientMode temp = (LinearGradientMode)obj[x];
				theBrush = new LinearGradientBrush(r, Color.Red, 
												Color.Blue, temp);			
				
				// Print name of LinearGradientMode enum.
				g.DrawString(temp.Format(), new Font("Times New Roman", 10), 
								new SolidBrush(Color.Black), 0, yOffSet);

				// Fill a rectangle with the correct brush.
				g. FillRectangle(theBrush, 150, yOffSet, 200, 50);
				yOffSet += 80;
			}
        }

        public static void Main(string[] args) 
        {
            Application.Run(new Form1());
        }
    }
}
