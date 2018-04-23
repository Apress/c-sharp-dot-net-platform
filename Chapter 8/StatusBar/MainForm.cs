namespace StatusBar
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
	public class MainForm : System.Windows.Forms.Form
	{
		private StatusBar statusBar = new StatusBar();
		private StatusBarPanel sbPnlPrompt = new StatusBarPanel();
		private StatusBarPanel sbPnlTime = new StatusBarPanel();

		private Timer timer1 = new Timer();
		private MainMenu mainMenu;
		private System.ComponentModel.Container components;

		public MainForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			// Set up Form properties.
			Text = "Status Bar Example";
			CenterToScreen();
			BackColor = Color.CadetBlue;

			// Configure the timer.
			timer1.Interval = 1000;
			timer1.Enabled = true;
			timer1.Tick += new EventHandler(timer1_Tick);
			this.MenuComplete += new EventHandler(StatusForm_MenuDone);
			BuildMenuSystem();
			BuildStatBar();
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
			this.components = new System.ComponentModel.Container();
			this.Size = new System.Drawing.Size(300,300);
			this.Text = "Form1";
		}
		#endregion

		/// <summary>
		/// 	The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new MainForm());
		}

		// Clicked handlers.
		private void FileExit_Clicked(object sender, EventArgs e) 
		{		
			this.Close();
		}
        
		// Help | About Menu item handler
		private void HelpAbout_Clicked(object sender, EventArgs e) 
		{
			MessageBox.Show("The amazing menu app...");
		}
        
		// Selected handlers.
		private void FileExit_Selected(object sender, EventArgs e) 
		{
			sbPnlPrompt.Text = "Terminates this app";     
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
			// First make the main menu.
			mainMenu = new MainMenu();
			
			//Create the 'File' Menu.
			MenuItem miFile = mainMenu.MenuItems.Add("&File");          
			miFile.MenuItems.Add(new MenuItem("E&xit", 
				new EventHandler(this.FileExit_Clicked), 
				Shortcut.CtrlX));
			miFile.MenuItems[0].Select += new EventHandler(FileExit_Selected);

			// Now create a 'Help | About' menu.
			MenuItem miHelp = mainMenu.MenuItems.Add("Help");	
			miHelp.MenuItems.Add(new MenuItem("&About",
				new EventHandler(this.HelpAbout_Clicked),
				Shortcut.CtrlA));
			miHelp.MenuItems[0].Select += new EventHandler(HelpAbout_Selected);

			// Attach main menu to the Form object.         
			this.Menu = mainMenu;			
		}

		private void BuildStatBar()
		{
			// Configure the status bar.
			statusBar.ShowPanels = true;
			statusBar.Panels.AddRange(new StatusBarPanel[] {sbPnlPrompt, sbPnlTime});
			
			// Configure prompt panel.
			sbPnlPrompt.BorderStyle = StatusBarPanelBorderStyle.None;
			sbPnlPrompt.AutoSize = StatusBarPanelAutoSize.Spring;
			sbPnlPrompt.Width = 62;
			sbPnlPrompt.Text = "Ready";
			
			// Configure time pane.
			sbPnlTime.Alignment = HorizontalAlignment.Right;
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
