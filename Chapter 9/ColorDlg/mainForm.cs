namespace ColorDlg
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
		/// <summary>
		///		Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components;
		private System.Windows.Forms.ColorDialog colorDlg;
		private Color currColor;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			CenterToScreen();
			colorDlg = new System.Windows.Forms.ColorDialog();		
			colorDlg.AnyColor = true;
			colorDlg.ShowHelp = true;	
	
			Text = "Click on me to change the Color";
			currColor = Color.BlueViolet;
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
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(292, 273);
			this.Text = "Form1";
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);

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

		private void Form1_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (colorDlg.ShowDialog() != DialogResult.Cancel)
			{
				currColor = colorDlg.Color;
				this.BackColor = currColor;

				// Show current color.
				string strARGB = colorDlg.Color.ToString();
				MessageBox.Show(strARGB, "Color is:");
			}
		}
	}
}
