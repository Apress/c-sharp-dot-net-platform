namespace CarLogApp
{
    using System;
    using System.Drawing;
    using System.Collections;
    using System.ComponentModel;
    using System.Windows.Forms;

    public class AddCarDlg : System.Windows.Forms.Form
    {
        private System.ComponentModel.Container components;
		private System.Windows.Forms.ListBox listColor;
		private System.Windows.Forms.ListBox listMake;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnOK;

		// Make public for easy access
		public Car theCar = null;

        public AddCarDlg()
        {
            InitializeComponent();
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


        private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container ();
			this.label1 = new System.Windows.Forms.Label ();
			this.label3 = new System.Windows.Forms.Label ();
			this.btnOK = new System.Windows.Forms.Button ();
			this.label2 = new System.Windows.Forms.Label ();
			this.listColor = new System.Windows.Forms.ListBox ();
			this.btnCancel = new System.Windows.Forms.Button ();
			this.listMake = new System.Windows.Forms.ListBox ();
			this.txtName = new System.Windows.Forms.TextBox ();
			//@this.TrayHeight = 0;
			//@this.TrayLargeIcon = false;
			//@this.TrayAutoArrange = true;
			label1.Location = new System.Drawing.Point (8, 24);
			label1.Text = "Pet Name";
			label1.Size = new System.Drawing.Size (88, 24);
			label1.Font = new System.Drawing.Font ("Microsoft Sans Serif", 10, System.Drawing.FontStyle.Bold);
			label1.TabIndex = 2;
			label3.Location = new System.Drawing.Point (8, 104);
			label3.Text = "Color";
			label3.Size = new System.Drawing.Size (80, 24);
			label3.Font = new System.Drawing.Font ("Microsoft Sans Serif", 10, System.Drawing.FontStyle.Bold);
			label3.TabIndex = 4;
			btnOK.Location = new System.Drawing.Point (24, 144);
			btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			btnOK.Size = new System.Drawing.Size (104, 24);
			btnOK.TabIndex = 0;
			btnOK.Text = "OK";
			btnOK.Click += new System.EventHandler (this.btnOK_Click);
			label2.Location = new System.Drawing.Point (8, 64);
			label2.Text = "Make";
			label2.Size = new System.Drawing.Size (88, 24);
			label2.Font = new System.Drawing.Font ("Microsoft Sans Serif", 10, System.Drawing.FontStyle.Bold);
			label2.TabIndex = 3;
			listColor.Location = new System.Drawing.Point (112, 96);
			listColor.Size = new System.Drawing.Size (200, 30);
			listColor.TabIndex = 7;
			listColor.Items.AddRange(new object[7] {"Red", "Green", "Pink", "Yellow", "Rust", "Black", "White"});
			btnCancel.Location = new System.Drawing.Point (184, 144);
			btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			btnCancel.Size = new System.Drawing.Size (112, 24);
			btnCancel.TabIndex = 1;
			btnCancel.Text = "Cancel";
			listMake.Location = new System.Drawing.Point (112, 48);
			listMake.Size = new System.Drawing.Size (200, 30);
			listMake.TabIndex = 6;
			listMake.Items.AddRange(new object[7] {"BMW", "Colt", "VW Bug", "Viper", "Yugo", "Escort", "Audi TT"});
			txtName.Location = new System.Drawing.Point (112, 16);
			txtName.TabIndex = 5;
			txtName.Size = new System.Drawing.Size (200, 20);
			this.Text = "Add Car Dialog";
			this.MaximizeBox = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.AutoScaleBaseSize = new System.Drawing.Size (5, 13);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.ControlBox = false;
			this.MinimizeBox = false;
			this.ClientSize = new System.Drawing.Size (322, 183);
			this.Controls.Add (this.listColor);
			this.Controls.Add (this.listMake);
			this.Controls.Add (this.txtName);
			this.Controls.Add (this.label3);
			this.Controls.Add (this.label2);
			this.Controls.Add (this.label1);
			this.Controls.Add (this.btnCancel);
			this.Controls.Add (this.btnOK);
		}

		protected void btnOK_Click (object sender, System.EventArgs e)
		{
			theCar = new Car(txtName.Text, listMake.Text, listColor.Text);
		}
    }
}
