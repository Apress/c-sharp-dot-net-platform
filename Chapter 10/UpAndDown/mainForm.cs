namespace UpAndDown
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
	public class UpDownForm : System.Windows.Forms.Form
	{
		private System.ComponentModel.Container components;
		private System.Windows.Forms.Label lblCurrSel;
		private System.Windows.Forms.Button btnGetSelections;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown numericUpDown;
		private System.Windows.Forms.DomainUpDown domainUpDown;

		public UpDownForm()
		{
			InitializeComponent();
			domainUpDown.SelectedIndex = 2;
			CenterToScreen();
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
			this.components = new System.ComponentModel.Container ();
			this.label1 = new System.Windows.Forms.Label ();
			this.label2 = new System.Windows.Forms.Label ();
			this.numericUpDown = new System.Windows.Forms.NumericUpDown ();
			this.domainUpDown = new System.Windows.Forms.DomainUpDown ();
			this.btnGetSelections = new System.Windows.Forms.Button ();
			this.lblCurrSel = new System.Windows.Forms.Label ();
			numericUpDown.BeginInit ();
			//@this.TrayHeight = 0;
			//@this.TrayLargeIcon = false;
			//@this.TrayAutoArrange = true;
			label1.Location = new System.Drawing.Point (8, 24);
			label1.Text = "Domain UpDown Control";
			label1.Size = new System.Drawing.Size (224, 32);
			label1.Font = new System.Drawing.Font ("Verdana", 12);
			label1.TabIndex = 2;
			label2.Location = new System.Drawing.Point (8, 80);
			label2.Text = "Numeric UpDown Control";
			label2.Size = new System.Drawing.Size (232, 32);
			label2.Font = new System.Drawing.Font ("Verdana", 12);
			label2.TabIndex = 3;
			numericUpDown.Location = new System.Drawing.Point (264, 80);
			numericUpDown.Maximum = new decimal (5000);
			numericUpDown.Size = new System.Drawing.Size (168, 20);
			numericUpDown.ThousandsSeparator = true;
			numericUpDown.TabIndex = 1;
			numericUpDown.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
			numericUpDown.ValueChanged += new System.EventHandler (this.numericUpDown_ValueChanged);
			domainUpDown.Location = new System.Drawing.Point (264, 24);
			domainUpDown.Text = "domainUpDown1";
			domainUpDown.Size = new System.Drawing.Size (168, 20);
			domainUpDown.TabIndex = 0;
			domainUpDown.Sorted = true;
			domainUpDown.Wrap = true;
			domainUpDown.SelectedItemChanged += new System.EventHandler (this.domainUpDown_SelectedItemChanged);
			domainUpDown.Items.AddRange(new object[4] {"Another Boring String named B", "Boring String A", "BORING String C", "Final Boring string (D)"});
			btnGetSelections.Location = new System.Drawing.Point (16, 136);
			btnGetSelections.Size = new System.Drawing.Size (136, 24);
			btnGetSelections.TabIndex = 4;
			btnGetSelections.Text = "Get Current Selections";
			btnGetSelections.Click += new System.EventHandler (this.btnGetSelections_Click);
			lblCurrSel.Location = new System.Drawing.Point (176, 120);
			lblCurrSel.Size = new System.Drawing.Size (256, 48);
			lblCurrSel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			lblCurrSel.TabIndex = 5;
			lblCurrSel.BackColor = System.Drawing.Color.Linen;
			this.Text = "Spin Controls";
			this.AutoScaleBaseSize = new System.Drawing.Size (5, 13);
			this.ClientSize = new System.Drawing.Size (448, 181);
			this.Controls.Add (this.lblCurrSel);
			this.Controls.Add (this.btnGetSelections);
			this.Controls.Add (this.label2);
			this.Controls.Add (this.label1);
			this.Controls.Add (this.numericUpDown);
			this.Controls.Add (this.domainUpDown);
			numericUpDown.EndInit ();
		}
		#endregion

		/// <summary>
		/// 	The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new UpDownForm());
		}

		protected void numericUpDown_ValueChanged (object sender, System.EventArgs e)
		{
			this.Text = "You changed the numeric value...";
		}

		protected void domainUpDown_SelectedItemChanged (object sender, System.EventArgs e)
		{
			this.Text = "You changed the string value...";
		}

		protected void btnGetSelections_Click (object sender, System.EventArgs e)
		{
			// Get info from updowns...
			lblCurrSel.Text = "String: " 
				+ domainUpDown.Text 
				+ "\n" 
				+ "Number: " 
				+ numericUpDown.Value;
		}
	}
}
