namespace ControlBehaviors
{
	using System;
	using System.Drawing;
	using System.Collections;
	using System.ComponentModel;
	using System.Windows.Forms;
	using System.Data;

	public class MainForm : System.Windows.Forms.Form
	{
		private System.ComponentModel.Container components;

		public MainForm()
		{
			Top = 100;
			Left = 75;
			Height = 100;
			Width = 500;

			MessageBox.Show(Bounds.ToString(), "Current rect");

			// Add delegates for mouse & keyboard events.
			this.MouseUp += new MouseEventHandler(OnMouseUp);
			this.MouseMove += new MouseEventHandler(OnMouseMove);
			this.KeyUp += new KeyEventHandler(OnKeyUp);
			InitializeComponent();
			CenterToScreen();
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
			MessageBox.Show("Disposing this Form");
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

		[STAThread]
		static void Main() 
		{
			Application.Run(new MainForm());
		}
		protected void OnMouseUp(object sender, MouseEventArgs e)
		{
			// Which mouse button was clicked?
			if(e.Button == MouseButtons.Left)
				MessageBox.Show("Left click!");
			else if(e.Button == MouseButtons.Right)
				MessageBox.Show("Right click!");
			else if(e.Button == MouseButtons.Middle)
				MessageBox.Show("Middle click!");
		}

		protected void OnMouseMove(object sender, MouseEventArgs e)
		{
			this.Text = "Current Pos: (" + e.X + ", " + e.Y + ")";
		}

		public void OnKeyUp(object sender, KeyEventArgs e)
		{
			MessageBox.Show(e.KeyCode.ToString(), "Key Pressed!");
		}
	}
}
