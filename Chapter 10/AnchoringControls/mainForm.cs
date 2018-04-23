namespace AnchoringControls
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
	public class AnchorForm : System.Windows.Forms.Form
	{
		/// <summary>
		///		Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components;
		private System.Windows.Forms.MenuItem dockNone;
		private System.Windows.Forms.MenuItem dockFill;
		private System.Windows.Forms.MenuItem dockRight;
		private System.Windows.Forms.MenuItem dockLeft;
		private System.Windows.Forms.MenuItem dockBottom;
		private System.Windows.Forms.MenuItem dockTop;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.MenuItem ancRight;
		private System.Windows.Forms.MenuItem ancBottom;
		private System.Windows.Forms.MenuItem ancLeft;
		private System.Windows.Forms.MenuItem ancTop;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem ancNone;
		private System.Windows.Forms.MenuItem ancTopLeft;
		private System.Windows.Forms.MenuItem ancBotRight;
		private System.Windows.Forms.MenuItem ancBotLeft;
		private System.Windows.Forms.MenuItem ancTopRight;
		private System.Windows.Forms.MainMenu mainMenu1;
		public AnchorForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			CenterToScreen();
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
			this.dockRight = new System.Windows.Forms.MenuItem();
			this.dockBottom = new System.Windows.Forms.MenuItem();
			this.ancNone = new System.Windows.Forms.MenuItem();
			this.ancTopLeft = new System.Windows.Forms.MenuItem();
			this.ancTop = new System.Windows.Forms.MenuItem();
			this.dockFill = new System.Windows.Forms.MenuItem();
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.ancLeft = new System.Windows.Forms.MenuItem();
			this.ancBotRight = new System.Windows.Forms.MenuItem();
			this.ancBotLeft = new System.Windows.Forms.MenuItem();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.dockLeft = new System.Windows.Forms.MenuItem();
			this.dockNone = new System.Windows.Forms.MenuItem();
			this.button1 = new System.Windows.Forms.Button();
			this.ancBottom = new System.Windows.Forms.MenuItem();
			this.ancTopRight = new System.Windows.Forms.MenuItem();
			this.ancRight = new System.Windows.Forms.MenuItem();
			this.dockTop = new System.Windows.Forms.MenuItem();
			this.dockRight.Index = 3;
			this.dockRight.Text = "Right";
			this.dockRight.Click += new System.EventHandler(this.dockRight_Click);
			this.dockBottom.Index = 1;
			this.dockBottom.Text = "Bottom";
			this.dockBottom.Click += new System.EventHandler(this.dockBottom_Click);
			this.ancNone.Index = 4;
			this.ancNone.Text = "None";
			this.ancNone.Click += new System.EventHandler(this.ancNone_Click);
			this.ancTopLeft.Index = 5;
			this.ancTopLeft.Text = "TopLeft";
			this.ancTopLeft.Click += new System.EventHandler(this.ancTopLeft_Click);
			this.ancTop.Index = 0;
			this.ancTop.Text = "Top";
			this.ancTop.Click += new System.EventHandler(this.ancTop_Click);
			this.dockFill.Index = 4;
			this.dockFill.Text = "Fill";
			this.dockFill.Click += new System.EventHandler(this.dockFill_Click);
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {this.menuItem1,
																					  this.menuItem2});
			this.ancLeft.Index = 1;
			this.ancLeft.Text = "Left";
			this.ancLeft.Click += new System.EventHandler(this.ancLeft_Click);
			this.ancBotRight.Index = 8;
			this.ancBotRight.Text = "BottomRight";
			this.ancBotRight.Click += new System.EventHandler(this.ancBotRight_Click);
			this.ancBotLeft.Index = 7;
			this.ancBotLeft.Text = "BottomLeft";
			this.ancBotLeft.Click += new System.EventHandler(this.ancBotLeft_Click);
			this.menuItem1.Index = 0;
			this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {this.ancTop,
																					  this.ancLeft,
																					  this.ancBottom,
																					  this.ancRight,
																					  this.ancNone,
																					  this.ancTopLeft,
																					  this.ancTopRight,
																					  this.ancBotLeft,
																					  this.ancBotRight});
			this.menuItem1.Text = "&Anchor Value";
			this.menuItem2.Index = 1;
			this.menuItem2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {this.dockTop,
																					  this.dockBottom,
																					  this.dockLeft,
																					  this.dockRight,
																					  this.dockFill,
																					  this.dockNone});
			this.menuItem2.Text = "Dock Value";
			this.dockLeft.Index = 2;
			this.dockLeft.Text = "Left";
			this.dockLeft.Click += new System.EventHandler(this.dockLeft_Click);
			this.dockNone.Index = 5;
			this.dockNone.Text = "None";
			this.dockNone.Click += new System.EventHandler(this.dockNone_Click);
			this.button1.Location = new System.Drawing.Point(8, 16);
			this.button1.Size = new System.Drawing.Size(120, 40);
			this.button1.TabIndex = 0;
			this.button1.Text = "TheButton";
			this.ancBottom.Index = 2;
			this.ancBottom.Text = "Bottom";
			this.ancBottom.Click += new System.EventHandler(this.ancBottom_Click);
			this.ancTopRight.Index = 6;
			this.ancTopRight.Text = "TopRight";
			this.ancTopRight.Click += new System.EventHandler(this.ancTopRight_Click);
			this.ancRight.Index = 3;
			this.ancRight.Text = "Right";
			this.ancRight.Click += new System.EventHandler(this.ancRight_Click);
			this.dockTop.Index = 0;
			this.dockTop.Text = "Top";
			this.dockTop.Click += new System.EventHandler(this.dockTop_Click);
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(292, 253);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {this.button1});
			this.Menu = this.mainMenu1;
			this.Text = "Anchoring (and Docking) Controls";

		}
		#endregion

		/// <summary>
		/// 	The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new AnchorForm());
		}

		protected void dockNone_Click (object sender, System.EventArgs e)
		{
			button1.Dock = DockStyle.None;
			button1.Text = "Anchor: " + button1.Anchor.ToString() + 
				"\nDock: " + button1.Dock.ToString();
		}

		protected void dockFill_Click (object sender, System.EventArgs e)
		{
			button1.Dock = DockStyle.Fill;
			button1.Text = "Anchor: " + button1.Anchor.ToString() + 
				"\nDock: " + button1.Dock.ToString();
		}

		protected void dockRight_Click (object sender, System.EventArgs e)
		{
			button1.Dock = DockStyle.Right;
			button1.Text = "Anchor: " + button1.Anchor.ToString() + 
				"\nDock: " + button1.Dock.ToString();
		}

		protected void dockLeft_Click (object sender, System.EventArgs e)
		{
			button1.Dock = DockStyle.Left;
			button1.Text = "Anchor: " + button1.Anchor.ToString() + 
				"\nDock: " + button1.Dock.ToString();
		}

		protected void dockBottom_Click (object sender, System.EventArgs e)
		{
			button1.Dock = DockStyle.Bottom;
			button1.Text = "Anchor: " + button1.Anchor.ToString() + 
				"\nDock: " + button1.Dock.ToString();
		}

		protected void dockTop_Click (object sender, System.EventArgs e)
		{
			button1.Dock = DockStyle.Top;
			button1.Text = "Anchor: " + button1.Anchor.ToString() + 
				"\nDock: " + button1.Dock.ToString();
		}

		protected void ancRight_Click (object sender, System.EventArgs e)
		{
			button1.Anchor = AnchorStyles.Right;
			button1.Text = "Anchor: " + button1.Anchor.ToString() + 
				"\nDock: " + button1.Dock.ToString();
		}

		protected void ancBottom_Click (object sender, System.EventArgs e)
		{
			button1.Anchor = AnchorStyles.Bottom;
			button1.Text = "Anchor: " + button1.Anchor.ToString() + 
				"\nDock: " + button1.Dock.ToString();
		}

		protected void ancLeft_Click (object sender, System.EventArgs e)
		{
			button1.Anchor = AnchorStyles.Left;
			button1.Text = "Anchor: " + button1.Anchor.ToString() + 
				"\nDock: " + button1.Dock.ToString();
		}

		protected void ancTop_Click (object sender, System.EventArgs e)
		{
			button1.Anchor = AnchorStyles.Top;
			button1.Text = "Anchor: " + button1.Anchor.ToString() + 
				"\nDock: " + button1.Dock.ToString();
		}

		private void ancNone_Click(object sender, System.EventArgs e)
		{
			button1.Anchor = AnchorStyles.None;
			button1.Text = "Anchor: " + button1.Anchor.ToString() + 
				"\nDock: " + button1.Dock.ToString();
		}

		private void ancTopLeft_Click(object sender, System.EventArgs e)
		{
			button1.Anchor = AnchorStyles.Top | AnchorStyles.Left;
			button1.Text = "Anchor: " + button1.Anchor.ToString() + 
				"\nDock: " + button1.Dock.ToString();
		}

		private void ancTopRight_Click(object sender, System.EventArgs e)
		{
			button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			button1.Text = "Anchor: " + button1.Anchor.ToString() + 
				"\nDock: " + button1.Dock.ToString();
		}

		private void ancBotLeft_Click(object sender, System.EventArgs e)
		{
			button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			button1.Text = "Anchor: " + button1.Anchor.ToString() + 
				"\nDock: " + button1.Dock.ToString();
		}

		private void ancBotRight_Click(object sender, System.EventArgs e)
		{
			button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			button1.Text = "Anchor: " + button1.Anchor.ToString() + 
				"\nDock: " + button1.Dock.ToString();
		}
	}
}
