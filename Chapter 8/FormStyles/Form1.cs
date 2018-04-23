namespace FormStyles
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
		private System.Windows.Forms.Button btnGetStyles;
		/// <summary>
		///		Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components;

		public Form1()
		{
			InitializeComponent();
			SetStyle(ControlStyles.ResizeRedraw, true);
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
			this.btnGetStyles = new System.Windows.Forms.Button();
			this.btnGetStyles.Location = new System.Drawing.Point(24, 64);
			this.btnGetStyles.Size = new System.Drawing.Size(160, 23);
			this.btnGetStyles.TabIndex = 0;
			this.btnGetStyles.Text = "Get Form Styles";
			this.btnGetStyles.Click += new System.EventHandler(this.btnGetStyles_Click);
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(211, 104);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {this.btnGetStyles});
			this.Text = "A Form with Style!";
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);

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

		private void btnGetStyles_Click(object sender, System.EventArgs e)
		{
			MessageBox.Show(GetStyle(ControlStyles.ResizeRedraw).ToString(), 
				"Do you have ResizeRedraw?");
		}

		private void Form1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			// A custom dash...
			Pen customDashPen = new Pen(Color.Black, 10);
			float[] myDashes = {5.0f, 2.0f, 1.0f, 3.0f};
			customDashPen.DashPattern = myDashes;
			e.Graphics.DrawRectangle(customDashPen, ClientRectangle);
		}
	}
}
