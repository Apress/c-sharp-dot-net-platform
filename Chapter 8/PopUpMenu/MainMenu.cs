namespace PopUpMenu
{
	using System;
	using System.Drawing;
	using System.Collections;
	using System.ComponentModel;
	using System.Windows.Forms;
	using System.Data;

	// Helper struct for font size.
	internal struct TheFontSize
	{
		public static int Huge = 30;
		public static int Normal = 20;
		public static int Tiny = 8;
	}

	public class MainForm : System.Windows.Forms.Form
	{
		// Current size of font.
		private int currFontSize = TheFontSize.Normal;

		// The Form's popup menu.
		private ContextMenu popUpMenu;

		// Used to keep track of the current checked item.
		private MenuItem currentCheckedItem;
		private MenuItem checkedHuge;
		private MenuItem checkedNormal;
		private MenuItem checkedTiny;

		private System.ComponentModel.Container components;

		public MainForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			// Configure the initial look and feel of this form.
			Text = "PopUp Menu";
			CenterToScreen();

			// First make the context menu.
			popUpMenu = new ContextMenu();

			// Now add the sub items.
			popUpMenu.MenuItems.Add("Huge", new EventHandler(PopUp_Clicked));
			popUpMenu.MenuItems.Add("Normal", new EventHandler(PopUp_Clicked));
			popUpMenu.MenuItems.Add("Tiny", new EventHandler(PopUp_Clicked));


			// Attach main menu to the Form object.         
			this.ContextMenu = popUpMenu;

			checkedHuge = this.ContextMenu.MenuItems[0];
			checkedNormal = this.ContextMenu.MenuItems[1];        
			checkedTiny = this.ContextMenu.MenuItems[2];
			currentCheckedItem = checkedNormal;
			currentCheckedItem.Checked = true;

			this.Resize += new System.EventHandler(this.MainForm_Resize);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);

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

		[STAThread]
		static void Main() 
		{
			Application.Run(new MainForm());
		}
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

		private void MainForm_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			Graphics g = e.Graphics;

			// Draw some text in the client rect.
			g.DrawString("Please click on me...", 
				new Font("Times New Roman", (float)currFontSize), 
				new SolidBrush(Color.Black), 
				this.DisplayRectangle);
		}

		private void MainForm_Resize(object sender, System.EventArgs e)
		{
			Invalidate();
		}
	}
}
