namespace Tracker
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
	public class TrackForm : System.Windows.Forms.Form
	{
		/// <summary>
		///		Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TrackBar blueTrackBar;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TrackBar greenTrackBar;
		private System.Windows.Forms.TrackBar redTrackBar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lblCurrColor;
		private System.Windows.Forms.PictureBox colorBox;

		public TrackForm()
		{
			InitializeComponent();
			CenterToScreen();         
  
			// Set initial position of each slider.
			redTrackBar.Value = 100;
			greenTrackBar.Value = 255;
			blueTrackBar.Value = 0;
			UpdateColor();
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
			this.label4 = new System.Windows.Forms.Label ();
			this.label1 = new System.Windows.Forms.Label ();
			this.label3 = new System.Windows.Forms.Label ();
			this.label2 = new System.Windows.Forms.Label ();
			this.panel1 = new System.Windows.Forms.Panel ();
			this.redTrackBar = new System.Windows.Forms.TrackBar ();
			this.greenTrackBar = new System.Windows.Forms.TrackBar ();
			this.colorBox = new System.Windows.Forms.PictureBox ();
			this.lblCurrColor = new System.Windows.Forms.Label ();
			this.blueTrackBar = new System.Windows.Forms.TrackBar ();
			redTrackBar.BeginInit ();
			greenTrackBar.BeginInit ();
			blueTrackBar.BeginInit ();
			//@this.TrayHeight = 0;
			//@this.TrayLargeIcon = false;
			//@this.TrayAutoArrange = true;
			label4.Location = new System.Drawing.Point (16, 88);
			label4.Text = "Pick your slider here:";
			label4.Size = new System.Drawing.Size (240, 32);
			label4.Font = new System.Drawing.Font ("Microsoft Sans Serif", 15);
			label4.TabIndex = 9;
			label1.Location = new System.Drawing.Point (24, 16);
			label1.Text = "Red:";
			label1.Size = new System.Drawing.Size (88, 32);
			label1.Font = new System.Drawing.Font ("Arial", 15);
			label1.TabIndex = 4;
			label3.Location = new System.Drawing.Point (24, 104);
			label3.Text = "Blue:";
			label3.Size = new System.Drawing.Size (88, 32);
			label3.Font = new System.Drawing.Font ("Arial", 15);
			label3.TabIndex = 6;
			label2.Location = new System.Drawing.Point (24, 64);
			label2.Text = "Green:";
			label2.Size = new System.Drawing.Size (88, 32);
			label2.Font = new System.Drawing.Font ("Arial", 15);
			label2.TabIndex = 5;
			panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			panel1.Location = new System.Drawing.Point (16, 120);
			panel1.Size = new System.Drawing.Size (384, 88);
			panel1.TabIndex = 8;
			panel1.AutoScroll = true;
			redTrackBar.TickFrequency = 5;
			redTrackBar.Location = new System.Drawing.Point (120, 16);
			redTrackBar.TabIndex = 2;
			redTrackBar.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
			redTrackBar.Maximum = 255;
			redTrackBar.Size = new System.Drawing.Size (232, 42);
			redTrackBar.Scroll += new System.EventHandler (this.redTrackBar_Scroll);
			greenTrackBar.TickFrequency = 5;
			greenTrackBar.Location = new System.Drawing.Point (120, 56);
			greenTrackBar.TabIndex = 3;
			greenTrackBar.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
			greenTrackBar.Maximum = 255;
			greenTrackBar.Size = new System.Drawing.Size (240, 42);
			greenTrackBar.Scroll += new System.EventHandler (this.greenTrackBar_Scroll);
			colorBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			colorBox.BackColor = System.Drawing.Color.Blue;
			colorBox.Location = new System.Drawing.Point (16, 16);
			colorBox.Size = new System.Drawing.Size (384, 56);
			colorBox.TabIndex = 0;
			colorBox.TabStop = false;
			lblCurrColor.Location = new System.Drawing.Point (16, 224);
			lblCurrColor.Text = "label4";
			lblCurrColor.Size = new System.Drawing.Size (392, 40);
			lblCurrColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			lblCurrColor.Font = new System.Drawing.Font ("Microsoft Sans Serif", 14);
			lblCurrColor.TabIndex = 7;
			blueTrackBar.TickFrequency = 5;
			blueTrackBar.Location = new System.Drawing.Point (120, 96);
			blueTrackBar.TabIndex = 1;
			blueTrackBar.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
			blueTrackBar.Maximum = 255;
			blueTrackBar.Size = new System.Drawing.Size (240, 42);
			blueTrackBar.Scroll += new System.EventHandler (this.blueTrackBar_Scroll);
			this.Text = "Color Form";
			this.AutoScaleBaseSize = new System.Drawing.Size (5, 13);
			this.ClientSize = new System.Drawing.Size (424, 285);
			panel1.Controls.Add (this.label2);
			panel1.Controls.Add (this.blueTrackBar);
			panel1.Controls.Add (this.label3);
			panel1.Controls.Add (this.greenTrackBar);
			panel1.Controls.Add (this.redTrackBar);
			panel1.Controls.Add (this.label1);
			this.Controls.Add (this.label4);
			this.Controls.Add (this.panel1);
			this.Controls.Add (this.lblCurrColor);
			this.Controls.Add (this.colorBox);
			redTrackBar.EndInit ();
			greenTrackBar.EndInit ();
			blueTrackBar.EndInit ();
		}
		#endregion

		/// <summary>
		/// 	The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new TrackForm());
		}

		protected void greenTrackBar_Scroll (object sender, System.EventArgs e)
		{
			UpdateColor();
		}

		protected void redTrackBar_Scroll (object sender, System.EventArgs e)
		{
			UpdateColor();
		}

		protected void blueTrackBar_Scroll (object sender, System.EventArgs e)
		{
			UpdateColor();
		}

		private void UpdateColor()
		{
			// Get the new color.
			Color c = Color.FromArgb(redTrackBar.Value, 
				greenTrackBar.Value, 
				blueTrackBar.Value);
			// Change the color in the PictureBox.
			colorBox.BackColor = c;

			// Set color label.
			lblCurrColor.Text = "Current color is: " + "(" + 
				redTrackBar.Value + ", " + 
				greenTrackBar.Value + " ," +  
				blueTrackBar.Value + ")";
		}
	}
}
