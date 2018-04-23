namespace ScrollForm
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
		private System.Windows.Forms.Label label1;
		/// <summary>
		///		Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components;
	
		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
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
			this.label1 = new System.Windows.Forms.Label();
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
			this.label1.Location = new System.Drawing.Point(16, 16);
			this.label1.Size = new System.Drawing.Size(376, 224);
			this.label1.TabIndex = 0;
			this.label1.Text = "This is a block of text which will still be visible when the user resizes me.  Ho" +
				"w?  Scrollbars of course!";
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.AutoScroll = true;
			this.AutoScrollMinSize = new System.Drawing.Size(300, 300);
			this.ClientSize = new System.Drawing.Size(403, 256);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {this.label1});
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
	}
}
