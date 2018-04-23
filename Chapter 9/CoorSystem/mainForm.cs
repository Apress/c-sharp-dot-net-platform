namespace CoorSystem
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
		private System.Windows.Forms.MenuItem mnuOrg100100;
		private System.Windows.Forms.MenuItem mnuOrg55;
		private System.Windows.Forms.MenuItem mnuOrg00;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem mnuPT;
		private System.Windows.Forms.MenuItem mnuDoc;
		private System.Windows.Forms.MenuItem mnuDisplay;
		private System.Windows.Forms.MenuItem mnuMM;
		private System.Windows.Forms.MenuItem mnuInch;
		private System.Windows.Forms.MenuItem mnuPixel;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MainMenu mainMenu1;

		// The unit o' measurement.
		GraphicsUnit gUnit = GraphicsUnit.Pixel;

		// Origin.
		Point renderingOrgPt = new Point(0,0);

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
			this.mnuOrg100100 = new System.Windows.Forms.MenuItem();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.mnuOrg55 = new System.Windows.Forms.MenuItem();
			this.mnuPT = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.mnuDisplay = new System.Windows.Forms.MenuItem();
			this.mnuMM = new System.Windows.Forms.MenuItem();
			this.mnuDoc = new System.Windows.Forms.MenuItem();
			this.mnuOrg00 = new System.Windows.Forms.MenuItem();
			this.mnuPixel = new System.Windows.Forms.MenuItem();
			this.mnuInch = new System.Windows.Forms.MenuItem();
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.mnuOrg100100.Index = 2;
			this.mnuOrg100100.Text = "(100, 100)";
			this.mnuOrg100100.Click += new System.EventHandler(this.mnuOrg100100_Click);
			this.menuItem1.Index = 0;
			this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {this.mnuPixel,
																					  this.mnuInch,
																					  this.mnuMM,
																					  this.mnuDisplay,
																					  this.mnuDoc,
																					  this.mnuPT});
			this.menuItem1.Text = "Unit of Measurement";
			this.menuItem1.Click += new System.EventHandler(this.TopMenuClick);
			this.mnuOrg55.Index = 1;
			this.mnuOrg55.Text = "(5, 5)";
			this.mnuOrg55.Click += new System.EventHandler(this.mnuOrg55_Click);
			this.mnuPT.Index = 5;
			this.mnuPT.Text = "Point";
			this.mnuPT.Click += new System.EventHandler(this.mnuPT_Click);
			this.menuItem2.Index = 1;
			this.menuItem2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {this.mnuOrg00,
																					  this.mnuOrg55,
																					  this.mnuOrg100100});
			this.menuItem2.Text = "Origin";
			this.menuItem2.Click += new System.EventHandler(this.TopMenuClick);
			this.mnuDisplay.Index = 3;
			this.mnuDisplay.Text = "Display";
			this.mnuDisplay.Click += new System.EventHandler(this.mnuDisplay_Click);
			this.mnuMM.Index = 2;
			this.mnuMM.Text = "Millimeter";
			this.mnuMM.Click += new System.EventHandler(this.mnuMM_Click);
			this.mnuDoc.Index = 4;
			this.mnuDoc.Text = "Document";
			this.mnuDoc.Click += new System.EventHandler(this.mnuDoc_Click);
			this.mnuOrg00.Index = 0;
			this.mnuOrg00.Text = "(0, 0)";
			this.mnuOrg00.Click += new System.EventHandler(this.mnuOrg00_Click);
			this.mnuPixel.Index = 0;
			this.mnuPixel.Text = "Pixel";
			this.mnuPixel.Click += new System.EventHandler(this.mnuPixel_Click);
			this.mnuInch.Index = 1;
			this.mnuInch.Text = "Inch";
			this.mnuInch.Click += new System.EventHandler(this.mnuInch_Click);
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {this.menuItem1,
																					  this.menuItem2});
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(292, 273);
			this.Menu = this.mainMenu1;
			this.Text = "GDI+ Coordinate";
			this.Resize += new System.EventHandler(this.OnResize);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPaint);

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
		protected void mnuOrg100100_Click (object sender, System.EventArgs e)
		{
			renderingOrgPt.X = 100;
			renderingOrgPt.Y = 100;
			Invalidate();
		}

		protected void mnuOrg55_Click (object sender, System.EventArgs e)
		{
			renderingOrgPt.X = 5;
			renderingOrgPt.Y = 5;
			Invalidate();
		}

		protected void mnuOrg00_Click (object sender, System.EventArgs e)
		{
			renderingOrgPt.X = 0;
			renderingOrgPt.Y = 0;
			Invalidate();
		}

		protected void mnuPT_Click (object sender, System.EventArgs e)
		{
			gUnit = GraphicsUnit.Point;
			Invalidate();
		}

		protected void mnuDoc_Click (object sender, System.EventArgs e)
		{
			gUnit = GraphicsUnit.Document;
			Invalidate();
		}

		protected void mnuDisplay_Click (object sender, System.EventArgs e)
		{
			gUnit = GraphicsUnit.Display;
			Invalidate();		
		}

		protected void mnuMM_Click (object sender, System.EventArgs e)
		{
			gUnit = GraphicsUnit.Millimeter;
			Invalidate();
		}

		protected void mnuInch_Click (object sender, System.EventArgs e)
		{
			gUnit = GraphicsUnit.Inch;
			Invalidate();
		}

		protected void mnuPixel_Click (object sender, System.EventArgs e)
		{
			gUnit = GraphicsUnit.Pixel;
			Invalidate();
		}


		protected void OnPaint (object sender, System.Windows.Forms.PaintEventArgs e)
		{
			Graphics g = e.Graphics;

			// Set quality of rendering.
			g.SmoothingMode = SmoothingMode.AntiAlias;
	
			// Configure graphics unit.
			g.PageUnit = gUnit;

			// Configure origin.
			g.TranslateTransform(renderingOrgPt.X,
				renderingOrgPt.Y);

			g.DrawRectangle(new Pen(Color.Red, 1), 0, 0, 100, 100);
			
			// Force the old state to be killed.
			// (not necessary in general, but
			// want to be sure...)
			g.Dispose();
		}
		protected void OnResize (object sender, System.EventArgs e)
		{
			Invalidate();
		}
		protected void TopMenuClick (object sender, System.EventArgs e)
		{
			Invalidate();
		}
	}
}
