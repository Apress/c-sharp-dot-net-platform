namespace FinalFormsApp
{
	using System;
	using System.Drawing;
	using System.Collections;
	using System.ComponentModel;
	using System.Windows.Forms;
	using System.Data;
	
	// For reg stuff...
	using Microsoft.Win32;

	// For event log.
	using System.Diagnostics;

	// Helper struct for font size.
	internal struct TheFontSize
	{
		public static int Huge = 30;
		public static int Normal = 20;
		public static int Tiny = 8;
	}
	
	public class mainForm : System.Windows.Forms.Form
	{
		// State data.
		Color currColor = Color.MistyRose;
		private int currFontSize = TheFontSize.Normal;
		private StatusBar statusBar = new StatusBar();
		private StatusBarPanel sbPnlPrompt = new StatusBarPanel();
		private StatusBarPanel sbPnlTime = new StatusBarPanel();
		private Timer timer1;
		private MainMenu mainMenu = new MainMenu();
		private ContextMenu popUpMenu = new ContextMenu();
		
		// Used to keep track of the current checked item.
		private MenuItem currentCheckedItem;
		private MenuItem checkedHuge;
		private MenuItem checkedNormal;
		private MenuItem checkedTiny;


		/*  NOTE:  Sorry, I did not bother to handle the
		 *  check marks for the Color menu :-)
		 *  Please feel free to update!
		 */

		private System.ComponentModel.Container components;

		public mainForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			// Get Reg values to set state data.
			RegistryKey regKey = Registry.CurrentUser;
			regKey = regKey.CreateSubKey("Software\\Intertech\\Chapter8App");
			currFontSize = (int)regKey.GetValue("CurrSize", currFontSize);
			string c = (string)regKey.GetValue("CurrColor", currColor.Name);
			currColor = Color.FromName(c);
			BackColor = currColor;

			// Set up Form properties.
			Text = "Final Form";
			CenterToScreen();
			this.MenuComplete += new EventHandler(StatusForm_MenuDone);

			// Configure the timer.
			timer1 = new Timer();
			timer1.Interval = 1000;
			timer1.Enabled = true;
			timer1.Tick += new EventHandler(timer1_Tick);
			
			BuildMenuSystem();
			BuildStatBar();
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
		}
		#endregion

		/// <summary>
		/// 	The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new mainForm());
		}

		// File | Exit Menu item handler
		private void FileExit_Clicked(object sender, EventArgs e) 
		{
			// Just for kicks, let's log this event to 
			// the Event Log...
			EventLog log = new EventLog();
			log.Log = "Application";
			log.Source = this.Text;
			log.WriteEntry("Hey dude, this app shut down...");
			
			// Display the first 5 entries in the Application log.
			for(int i = 0; i < 5; i++)
			{
				try
				{
					MessageBox.Show("Message: " + log.Entries[i].Message + "\n" +  
						"Box: " + log.Entries[i].MachineName + "\n" +
						"App: " + log.Entries[i].Source + "\n" +
						"Time entered: " + log.Entries[i].TimeWritten, 
						"Application Log entry:");
				}
				catch{}
			}

			log.Close();
			// Now shut down the app.
			this.Close();
		}

		// File | Save Menu item handler
		private void FileSave_Clicked(object sender, EventArgs e) 
		{
			// Save user prefs to reg.
			RegistryKey regKey = Registry.CurrentUser;
			regKey = regKey.CreateSubKey("Software\\Intertech\\Chapter8App");
			regKey.SetValue("CurrSize", currFontSize);
			regKey.SetValue("CurrColor", currColor.Name);
			MessageBox.Show("Settings saved in registry");
		}

		// Color | X Menu item handler
		private void ColorItem_Clicked(object sender, EventArgs e) 
		{
			// Figure out the string name of the color selected.
			MenuItem miClicked = (MenuItem)sender;
			string color = miClicked.Text.Remove(0,1);
			
			// Now set the color.
			BackColor = Color.FromName(color);
			currColor = BackColor;
		}

		// PopUp_Clicked | X Menu item handler
		private void PopUp_Clicked(object sender, EventArgs e) 
		{
			currentCheckedItem.Checked = false;

			// Figure out the string name of the selected item.
			MenuItem miClicked = (MenuItem)sender;
			string item = miClicked.Text;
			
			if(item == "Huge")
			{
				currFontSize = TheFontSize.Huge;
				currentCheckedItem = checkedHuge;
			}

			if(item == "Normal")
			{
				currFontSize = TheFontSize.Normal;
				currentCheckedItem = checkedNormal;
			}

			if(item == "Tiny")
			{
				currFontSize = TheFontSize.Tiny;
				currentCheckedItem = checkedTiny;
			}
			currentCheckedItem.Checked = true;
			Invalidate();
		}

		// Overrides.
		protected override void OnPaint(PaintEventArgs e)
		{
			Graphics g = e.Graphics;

			// Draw some text in the client rect.
			g.DrawString("Please make use of my menu system...", 
				new Font("Times New Roman", (float)currFontSize), 
				new SolidBrush(Color.Black), 
				this.DisplayRectangle);
		}
		
		// If the user resizes the Form, be sure to redraw
		// the text string.
		protected override void OnResize(EventArgs e)
		{
			base.OnResize(e);
			Invalidate();
		}

		// Help | About Menu item handler
		private void HelpAbout_Clicked(object sender, EventArgs e) 
		{
			MessageBox.Show("The amazing final app...", "About...");
		}
        
		// Selected handlers.
		private void FileMenuItem_Selected(object sender, EventArgs e) 
		{
			// Figure out the string name of the selected item.
			MenuItem miClicked = (MenuItem)sender;
			string item = miClicked.Text.Remove(0,1);
			
			if(item == "Save...")
				sbPnlPrompt.Text = "Save current settings.";     
			else	
				sbPnlPrompt.Text = "Terminates this app.";     
		}

		private void ColorMenuItem_Selected(object sender, EventArgs e) 
		{
			// Figure out the string name of the selected item.
			MenuItem miClicked = (MenuItem)sender;
			string item = miClicked.Text.Remove(0,1);
			sbPnlPrompt.Text = "Select " + item;      			
		}

		private void HelpAbout_Selected(object sender, EventArgs e) 
		{
			sbPnlPrompt.Text = "Displays app info";
		}

		// Other handlers...
		private void StatusForm_MenuDone(object sender, EventArgs e) 
		{
			sbPnlPrompt.Text = "Ready";
		}

		private void timer1_Tick(object sender, EventArgs e) 
		{
			DateTime t = DateTime.Now;
			string s = t.ToLongTimeString() ;
			sbPnlTime.Text = s ;		
		}

		// Helper functions.
		private void BuildMenuSystem()
		{
			//Create the 'File' Menu.
			MenuItem miFile = mainMenu.MenuItems.Add("&File");     			
			miFile.MenuItems.Add(new MenuItem("&Save...", 
				new EventHandler(this.FileSave_Clicked), 
				Shortcut.CtrlS));     
			miFile.MenuItems.Add(new MenuItem("E&xit", 
				new EventHandler(this.FileExit_Clicked), 
				Shortcut.CtrlX));

			miFile.MenuItems[0].Select += new EventHandler(FileMenuItem_Selected);
			miFile.MenuItems[1].Select += new EventHandler(FileMenuItem_Selected);

			// Now create the 'Color' menu.
			// Notice that all sub menus are routed to the same
			// event handler...
			MenuItem miColor = mainMenu.MenuItems.Add("&Background Color");
			miColor.MenuItems.Add("&DarkGoldenrod", new EventHandler(ColorItem_Clicked));
			miColor.MenuItems.Add("&GreenYellow", new EventHandler(ColorItem_Clicked));
			miColor.MenuItems.Add("&MistyRose", new EventHandler(ColorItem_Clicked));
			miColor.MenuItems.Add("&Crimson", new EventHandler(ColorItem_Clicked));
			miColor.MenuItems.Add("&LemonChiffon", new EventHandler(ColorItem_Clicked));
			miColor.MenuItems.Add("&OldLace", new EventHandler(ColorItem_Clicked));
			
			// All color menu items have the same selected handler.
			for(int i = 0; i < miColor.MenuItems.Count; i++)
				miColor.MenuItems[i].Select += new EventHandler(ColorMenuItem_Selected);

			// Now create a 'Help | About' menu.
			MenuItem miHelp = mainMenu.MenuItems.Add("Help");	
			miHelp.MenuItems.Add(new MenuItem("&About",
				new EventHandler(this.HelpAbout_Clicked),
				Shortcut.CtrlA));
			miHelp.MenuItems[0].Select += new EventHandler(HelpAbout_Selected);

			// Attach main menu to the Form object.         
			this.Menu = mainMenu;	

			// Now make the ContextMenu items.
			popUpMenu.MenuItems.Add("Huge", new EventHandler(PopUp_Clicked));
			popUpMenu.MenuItems.Add("Normal", new EventHandler(PopUp_Clicked));
			popUpMenu.MenuItems.Add("Tiny", new EventHandler(PopUp_Clicked));

			// Assign popup.
			this.ContextMenu = popUpMenu;

			checkedHuge = this.ContextMenu.MenuItems[0];
			checkedNormal = this.ContextMenu.MenuItems[1];        
			checkedTiny = this.ContextMenu.MenuItems[2];
			
			// Current size?
			if(currFontSize == TheFontSize.Huge)
				currentCheckedItem = checkedHuge;
			else if(currFontSize == TheFontSize.Normal)
				currentCheckedItem = checkedNormal;
			else
				currentCheckedItem = checkedTiny;

			currentCheckedItem.Checked = true;
		}

		private void BuildStatBar()
		{
			// Configure the status bar.
			statusBar.ShowPanels = true;
			statusBar.Panels.AddRange((StatusBarPanel[])new StatusBarPanel[] {sbPnlPrompt, sbPnlTime});

			// Configure prompt panel.
			sbPnlPrompt.BorderStyle = StatusBarPanelBorderStyle.None;
			sbPnlPrompt.AutoSize = StatusBarPanelAutoSize.Spring;
			sbPnlPrompt.Width = 62;
			sbPnlPrompt.Text = "Ready";

			// Configure time pane.
			sbPnlTime.Alignment = System.Windows.Forms.HorizontalAlignment.Right;
			sbPnlTime.Width = 76;

			// Add an icon!
			try
			{
				Icon i = new Icon("status.ico");
				sbPnlPrompt.Icon = i;
			}
			catch(Exception e)
			{
				MessageBox.Show(e.Message);
			}

			// Now add this new status bar to the Controls collection.
			this.Controls.Add(statusBar);  
		}

	}
}
