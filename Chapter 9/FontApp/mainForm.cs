namespace FontApp
{
	using System;
	using System.Drawing;
	using System.Drawing.Text;
	using System.Collections;
	using System.ComponentModel;
	using System.Windows.Forms;
	using System.Data;


	public class FontForm : System.Windows.Forms.Form
	{
		private System.ComponentModel.Container components;
		private Timer timer;
		private int swellValue;
		private string fontFace = "WingDings";
		private string installedFonts;

		// For font check mark.
		private MenuItem cmiArial = new MenuItem();
		private MenuItem cmiTimesNewRoman= new MenuItem();
		private MenuItem cmiWingDings= new MenuItem();
		private MenuItem cmiFontChecked = new MenuItem();

		private System.Windows.Forms.MainMenu mainMenu;
		private System.Windows.Forms.MenuItem mnuFontArial;
		private System.Windows.Forms.MenuItem mnuFontTimesNewRoman;
		private System.Windows.Forms.MenuItem mnuConfig;
		private System.Windows.Forms.MenuItem mnuFileExit;
		private System.Windows.Forms.MenuItem mnuConfigFontFace;
		private System.Windows.Forms.MenuItem mnuConfigSwell;
		private System.Windows.Forms.MenuItem mnuFile;
		private System.Windows.Forms.MenuItem mnuConfigShowFonts;
		private System.Windows.Forms.MenuItem ListFonts;
		private System.Windows.Forms.MenuItem mnuFontWingDings;
		

		public FontForm()
		{
			InitializeComponent();
			timer = new Timer();

			Text = "Font App";
			Width = 425;
			Height = 150;
			BackColor = Color.Honeydew;
			CenterToScreen();
			timer.Enabled = true;
			timer.Interval = 100;
			timer.Tick += new EventHandler(FontForm_OnTimer);

			// Set font check logic.
			cmiArial = mainMenu.MenuItems[1].MenuItems[1].MenuItems[0];
			cmiTimesNewRoman = mainMenu.MenuItems[1].MenuItems[1].MenuItems[1];
			cmiWingDings = mainMenu.MenuItems[1].MenuItems[1].MenuItems[2];
			cmiFontChecked = cmiWingDings;
			cmiFontChecked.Checked = true;
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


		private void InitializeComponent()
		{
			this.mnuFontArial = new System.Windows.Forms.MenuItem();
			this.mnuFontTimesNewRoman = new System.Windows.Forms.MenuItem();
			this.mnuConfig = new System.Windows.Forms.MenuItem();
			this.mnuFile = new System.Windows.Forms.MenuItem();
			this.mnuFileExit = new System.Windows.Forms.MenuItem();
			this.mnuConfigFontFace = new System.Windows.Forms.MenuItem();
			this.mnuConfigShowFonts = new System.Windows.Forms.MenuItem();
			this.mnuConfigSwell = new System.Windows.Forms.MenuItem();
			this.ListFonts = new System.Windows.Forms.MenuItem();
			this.mainMenu = new System.Windows.Forms.MainMenu();
			this.mnuFontWingDings = new System.Windows.Forms.MenuItem();
			this.mnuFontArial.Index = 0;
			this.mnuFontArial.Text = "&Arial";
			this.mnuFontArial.Click += new System.EventHandler(this.FormatFont_Clicked);
			this.mnuFontTimesNewRoman.Index = 1;
			this.mnuFontTimesNewRoman.Text = "&Times New Roman";
			this.mnuFontTimesNewRoman.Click += new System.EventHandler(this.FormatFont_Clicked);
			this.mnuConfig.Index = 1;
			this.mnuConfig.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {this.mnuConfigSwell,
																					  this.mnuConfigFontFace,
																					  this.ListFonts});
			this.mnuConfig.Text = "Configure";
			this.mnuFile.Index = 0;
			this.mnuFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {this.mnuFileExit});
			this.mnuFile.Text = "File";
			this.mnuFileExit.Index = 0;
			this.mnuFileExit.Text = "E&xit";
			this.mnuFileExit.Click += new System.EventHandler(this.mnuFileExit_Click);
			this.mnuConfigFontFace.Index = 1;
			this.mnuConfigFontFace.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {this.mnuFontArial,
																							  this.mnuFontTimesNewRoman,
																							  this.mnuFontWingDings});
			this.mnuConfigFontFace.Text = "Font Face";
			this.mnuConfigShowFonts.Index = -1;
			this.mnuConfigShowFonts.Text = "Show All Fonts";
			this.mnuConfigShowFonts.Click += new System.EventHandler(this.mnuConfigShowFonts_Click);
			this.mnuConfigSwell.Index = 0;
			this.mnuConfigSwell.Text = "Swell?";
			this.mnuConfigSwell.Click += new System.EventHandler(this.mnuConfigSwell_Click);
			this.ListFonts.Index = 2;
			this.ListFonts.Text = "List All Fonts";
			this.ListFonts.Click += new System.EventHandler(this.mnuConfigShowFonts_Click);
			this.mainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {this.mnuFile,
																					 this.mnuConfig});
			this.mnuFontWingDings.Index = 2;
			this.mnuFontWingDings.Text = "&WingDings";
			this.mnuFontWingDings.Click += new System.EventHandler(this.FormatFont_Clicked);
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(292, 253);
			this.Menu = this.mainMenu;
			this.Text = "Form1";
			this.Resize += new System.EventHandler(this.FontForm_Resize);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.FontForm_Paint);

		}

		[STAThread]
		static void Main() 
		{
			Application.Run(new FontForm());
		}

		private void FontForm_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			Graphics g = e.Graphics;
			Font theFont = new Font(fontFace, 12 + swellValue);

			string message = "Hello GDI+";	
	
			// Display message in the center of the window!
			float windowCenter = this.DisplayRectangle.Width / 2;             
			SizeF stringSize = e.Graphics.MeasureString(message, theFont);
			float startPos = windowCenter - (stringSize.Width / 2);

			g.DrawString(message, theFont, 
				new SolidBrush(Color.Blue), startPos, 10);

			// Show installed fonts.
			RectangleF myRect = new RectangleF(0, 100, 
				ClientRectangle.Width, ClientRectangle.Height); 
			g.FillRectangle(new SolidBrush(Color.Black), myRect);
			g.DrawString(installedFonts, new Font("Arial", 12), 
				new SolidBrush(Color.White), myRect);

		}

		private void FontForm_Resize(object sender, System.EventArgs e)
		{
			Rectangle myRect = new Rectangle(0, 100, 
				ClientRectangle.Width, ClientRectangle.Height); 
			Invalidate(myRect);
		}

		private void FormatFont_Clicked(object sender, EventArgs e) 
		{
			cmiFontChecked.Checked = false;

			MenuItem miClicked = (MenuItem)sender;
			fontFace = miClicked.Text.Remove(0,1);
		
			if (fontFace == "Arial") 
			{
				cmiFontChecked = cmiArial;
			} 
			else if (fontFace == "Times New Roman") 
			{
				cmiFontChecked = cmiTimesNewRoman;
			} 
			else if (fontFace == "WingDings")
			{
				cmiFontChecked = cmiWingDings;
			}

			cmiFontChecked.Checked = true;
			Invalidate();
		}

		private void ListFonts_Clicked(object sender, EventArgs e) 
		{
			InstalledFontCollection fonts = new InstalledFontCollection();
			for(int i = 0; i < fonts.Families.Length; i++)
			{
				installedFonts += fonts.Families[i].Name + "  ";
			}
			Invalidate();
		}

		private void FontForm_OnTimer(object sender, EventArgs e)
		{
			swellValue += 5;
			if(swellValue >= 50)
				swellValue = 0;

			Invalidate(new Rectangle(0, 0, ClientRectangle.Width, 100));
		}

		private void mnuFileExit_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void mnuConfigSwell_Click(object sender, System.EventArgs e)
		{
			timer.Enabled = !timer.Enabled;
			mainMenu.MenuItems[1].MenuItems[0].Checked = timer.Enabled;
		}

		private void mnuConfigShowFonts_Click(object sender, System.EventArgs e)
		{
			InstalledFontCollection fonts = new InstalledFontCollection();
			for(int i = 0; i < fonts.Families.Length; i++)
			{
				installedFonts += fonts.Families[i].Name + "  ";
			}
			Invalidate();
		}
	}
}