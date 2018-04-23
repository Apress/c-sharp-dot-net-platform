namespace SolidBrushApp
{
    using System;
    using System.Drawing;
	using System.Drawing.Drawing2D;
    using System.Collections;
    using System.ComponentModel;
    using System.WinForms;
    using System.Data;

    /// <summary>
    ///    Summary description for Form1.
    /// </summary>
    public class Form1 : System.WinForms.Form
    {
        /// <summary>
        ///    Required designer variable.
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
        ///    Clean up any resources being used.
        /// </summary>
        public override void Dispose()
        {
            base.Dispose();
            components.Dispose();
        }

        /// <summary>
        ///    Required method for Designer support - do not modify
        ///    the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container ();
			//@this.TrayHeight = 0;
			//@this.TrayLargeIcon = false;
			//@this.TrayAutoArrange = true;
			this.Text = "Solid Brushes...";
			this.AutoScaleBaseSize = new System.Drawing.Size (5, 13);
			this.Paint += new System.WinForms.PaintEventHandler (this.OnPaint);
		}

		protected void OnPaint (object sender, System.WinForms.PaintEventArgs e)
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

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static void Main(string[] args) 
        {
            Application.Run(new Form1());
        }
    }
}
