namespace SimpleMenu
{
	using System;
	using System.Drawing;
	using System.Collections;
	using System.ComponentModel;
	using System.Windows.Forms;
	using System.Data;

	public class MainForm : System.Windows.Forms.Form
	{
		// The Form's main menu.
		private MainMenu mainMenu;

		private System.ComponentModel.Container components;

		public MainForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			// Configure the initial look and feel of this form.
			Text = "Simple Menu";
			CenterToScreen();

			// First make the main menu.
			mainMenu = new MainMenu();

			//Create the 'File | Exit' Menu.
			MenuItem miFile = mainMenu.MenuItems.Add("&File");          
			miFile.MenuItems.Add(new MenuItem("E&xit", 
				new EventHandler(this.FileExit_Clicked), 
				Shortcut.CtrlX));
			
			// Now create a 'Help | About' menu.
			MenuItem miHelp = mainMenu.MenuItems.Add("Help");
			miHelp.MenuItems.Add(new MenuItem("&About",
				new EventHandler(this.HelpAbout_Clicked),
				Shortcut.CtrlA));

			// Attach main menu to the Form object.         
			this.Menu = mainMenu;

			// Just for kicks...
			// change the form's color using a menu.
			mainMenu.GetForm().BackColor = Color.Black;
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
			this.components = new System.ComponentModel.Container();
			this.Size = new System.Drawing.Size(300,300);
			this.Text = "Form1";
		}
		#endregion

		// File | Exit Menu item handler
		private void FileExit_Clicked(object sender, EventArgs e) 
		{
			this.Close();
		}
        
		// Help | About Menu item handler
		private void HelpAbout_Clicked(object sender, EventArgs e) 
		{
			MessageBox.Show("The amazing menu app...");
		}

		[STAThread]
		static void Main() 
		{
			Application.Run(new MainForm());
		}
	}
}
