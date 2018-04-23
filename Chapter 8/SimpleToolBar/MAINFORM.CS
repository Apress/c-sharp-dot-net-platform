namespace SimpleToolBar
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
	public class Form1 : System.Windows.Forms.Form
	{
		// State data.
		private ImageList toolBarIcons;
		private ToolBarButton tbExitButton;
		private ToolBarButton tbSaveButton;
		private ToolBar toolBar;
 
		private System.ComponentModel.Container components;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			// Form properties.
			Text = "A Simple Toolbar";
			BackColor = Color.Firebrick;
			CenterToScreen();
			BuildToolBar();	
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
			Application.Run(new Form1());
		}
		private void BuildToolBar()
		{		
			// Make the necessary types.
			toolBar = new ToolBar();
			toolBarIcons = new ImageList();
			tbSaveButton = new ToolBarButton();
			tbExitButton = new ToolBarButton();

			// Configure save button.
			tbSaveButton.ImageIndex = 0;
			tbSaveButton.ToolTipText = "Save";

			// Configure exit button.						
			tbExitButton.ImageIndex = 1;
			tbExitButton.ToolTipText = "Exit";	

			// Create ToolBar and add buttons.
			toolBar.ImageList = toolBarIcons;
			toolBar.Size = new System.Drawing.Size(272, 28);
			toolBar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			toolBar.ShowToolTips = true;
			toolBar.Buttons.AddRange(new ToolBarButton[] {tbSaveButton, tbExitButton});
			toolBar.ButtonClick += new ToolBarButtonClickEventHandler(ToolBar_Clicked);
			
			// Load images.
			toolBarIcons.ImageSize = new System.Drawing.Size(32, 32);
			toolBarIcons.Images.Add(new Icon("filesave.ico"));
			toolBarIcons.Images.Add(new Icon("fileexit.ico"));
			toolBarIcons.ColorDepth = ColorDepth.Depth16Bit;
			toolBarIcons.TransparentColor = System.Drawing.Color.Transparent;

			// Add the new bar to the Controls collection.
			this.Controls.Add(toolBar);		
		}
		
		private void ToolBar_Clicked(object sender, ToolBarButtonClickEventArgs e) 
		{
			MessageBox.Show(e.Button.ToolTipText);
		}
	}
}
