namespace ResLoader
{
	using System;
	using System.Drawing;
	using System.Collections;
	using System.ComponentModel;
	using System.Windows.Forms;
	using System.Data;

	using System.Resources;

	/// <summary>
	///		Summary description for Form1.
	/// </summary>
	public class MainForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button btnLoadRes;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox2;
		/// <summary>
		///		Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components;

		public MainForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			CenterToScreen();
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(MainForm));
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnLoadRes = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// pictureBox2
			// 
			this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox2.Location = new System.Drawing.Point(176, 72);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(32, 32);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 5;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Bitmap)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(176, 16);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(32, 32);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// btnLoadRes
			// 
			this.btnLoadRes.Location = new System.Drawing.Point(8, 80);
			this.btnLoadRes.Name = "btnLoadRes";
			this.btnLoadRes.Size = new System.Drawing.Size(144, 23);
			this.btnLoadRes.TabIndex = 4;
			this.btnLoadRes.Text = "Load Happy dude!";
			this.btnLoadRes.Click += new System.EventHandler(this.btnLoadRes_Click);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
			this.label1.Location = new System.Drawing.Point(8, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(152, 40);
			this.label1.TabIndex = 0;
			this.label1.Text = "Here is the image:";
			// 
			// MainForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(235, 128);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.pictureBox2,
																		  this.btnLoadRes,
																		  this.pictureBox1,
																		  this.label1});
			this.Name = "MainForm";
			this.Text = "Resource Loader";
			this.ResumeLayout(false);

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

		private void btnLoadRes_Click(object sender, System.EventArgs e)
		{
			// Make a ResourceManager
			ResourceManager resources = new ResourceManager (typeof(MainForm));
			
			// Read happy dude from assembly and place it
			// into the PictureBox object.
			this.pictureBox2.Image = 
				((System.Drawing.Bitmap)(resources.GetObject("pictureBox1.Image")));
				
			// All done!
			resources.ReleaseAllResources();	
		}
			
	}
}
