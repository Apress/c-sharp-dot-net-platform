namespace PenCapApp
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
			this.Text = "Pen Caps!";
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
			Pen thePen = new Pen(Color.Black, 10);
			int yOffSet = 10;

			// Get all members of the LineCap enum.
			Object[] obj = Enum.GetValues(typeof(LineCap));

			// Draw a line with a LineCap member.
			for(int x = 0; x < obj.Length; x++)
			{
				// Get next cap and configure pen.
				LineCap temp = (LineCap)obj[x];
				thePen.StartCap = temp;
				thePen.EndCap = temp;

				// Print name of LineCap enum.
				g.DrawString(temp.Format(), new Font("Times New Roman", 10), 
							 new SolidBrush(Color.Black), 0, yOffSet);

				// Draw a line with the correct cap.
				g.DrawLine(thePen, 100, yOffSet, Width - 50, yOffSet);

				yOffSet += 40;
			}
		}

        public static void Main(string[] args) 
        {
            Application.Run(new Form1());
        }
    }
}
