namespace SimpleDialog
{
    using System;
    using System.Drawing;
    using System.Collections;
    using System.ComponentModel;
    using System.Windows.Forms;

    public class SomeCustomForm : System.Windows.Forms.Form
    {
        private System.ComponentModel.Container components;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtMessage;

        public SomeCustomForm()
        {
            InitializeComponent();
			this.StartPosition = FormStartPosition.CenterParent;			
        }

		private string strMessage;

		public string Message
		{
			get{ return strMessage;}
			set
			{ 
				strMessage = value;
				txtMessage.Text = strMessage;
			}
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


		#region Windows Form Designer generated code
        private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container ();
			this.label1 = new System.Windows.Forms.Label ();
			this.btnOK = new System.Windows.Forms.Button ();
			this.btnCancel = new System.Windows.Forms.Button ();
			this.txtMessage = new System.Windows.Forms.TextBox ();
			label1.Location = new System.Drawing.Point (12, 8);
			label1.Text = "Type in your message, and the owing window will use it...";
			label1.Size = new System.Drawing.Size (240, 48);
			label1.Font = new System.Drawing.Font ("Microsoft Sans Serif", 12, System.Drawing.FontStyle.Bold);
			label1.TabIndex = 1;
			btnOK.Location = new System.Drawing.Point (16, 104);
			btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			btnOK.Size = new System.Drawing.Size (96, 24);
			btnOK.TabIndex = 2;
			btnOK.Text = "OK";
			btnOK.Click += new System.EventHandler (this.btnOK_Click);
			btnCancel.Location = new System.Drawing.Point (152, 104);
			btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			btnCancel.Size = new System.Drawing.Size (96, 24);
			btnCancel.TabIndex = 3;
			btnCancel.Text = "Cancel";
			txtMessage.Location = new System.Drawing.Point (16, 72);
			txtMessage.TabIndex = 0;
			txtMessage.Size = new System.Drawing.Size (232, 20);
			this.Text = "Some Custom Dialog";
			this.MaximizeBox = false;
			this.AutoScaleBaseSize = new System.Drawing.Size (5, 13);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.ControlBox = false;
			this.MinimizeBox = false;
			this.ClientSize = new System.Drawing.Size (266, 151);
			this.Controls.Add (this.btnCancel);
			this.Controls.Add (this.btnOK);
			this.Controls.Add (this.label1);
			this.Controls.Add (this.txtMessage);
		}
		#endregion

		protected void btnOK_Click (object sender, System.EventArgs e)
		{
			// OK button clicked.
			// get new message.
			strMessage = txtMessage.Text;
		}
    }
}
