namespace WinFormsCalcClient
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
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox txtNumb1;
		private System.Windows.Forms.TextBox txtNumb2;
		private System.Windows.Forms.Label lblAns;
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
			this.txtNumb1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtNumb2 = new System.Windows.Forms.TextBox();
			this.btnAdd = new System.Windows.Forms.Button();
			this.lblAns = new System.Windows.Forms.Label();
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.label1.Location = new System.Drawing.Point(8, 16);
			this.label1.Size = new System.Drawing.Size(96, 32);
			this.label1.TabIndex = 1;
			this.label1.Text = "Numb1";
			this.txtNumb1.Location = new System.Drawing.Point(120, 16);
			this.txtNumb1.Size = new System.Drawing.Size(88, 20);
			this.txtNumb1.TabIndex = 2;
			this.txtNumb1.Text = "0";
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.label2.Location = new System.Drawing.Point(8, 64);
			this.label2.Size = new System.Drawing.Size(88, 32);
			this.label2.TabIndex = 1;
			this.label2.Text = "Numb2";
			this.txtNumb2.Location = new System.Drawing.Point(120, 64);
			this.txtNumb2.Size = new System.Drawing.Size(88, 20);
			this.txtNumb2.TabIndex = 2;
			this.txtNumb2.Text = "0";
			this.btnAdd.Location = new System.Drawing.Point(8, 112);
			this.btnAdd.TabIndex = 0;
			this.btnAdd.Text = "Add";
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			this.lblAns.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.lblAns.Location = new System.Drawing.Point(104, 112);
			this.lblAns.Size = new System.Drawing.Size(100, 32);
			this.lblAns.TabIndex = 1;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(283, 168);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {this.txtNumb2,
																		  this.txtNumb1,
																		  this.lblAns,
																		  this.label2,
																		  this.label1,
																		  this.btnAdd});
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Windows Forms Web Service Client";

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

		private void btnAdd_Click(object sender, System.EventArgs e)
		{
			localhost.Service1 w = new localhost.Service1();			
			int ans = w.Add(int.Parse(txtNumb1.Text), int.Parse(txtNumb2.Text));
			lblAns.Text = ans.ToString();

		}
	}
}
