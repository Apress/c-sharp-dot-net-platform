namespace ErrorProvider
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
	public class ErrorForm : System.Windows.Forms.Form
	{
		private System.ComponentModel.Container components;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnValidate;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.TextBox txtInput;

		public ErrorForm()
		{
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
		}


		#region Windows Form Designer generated code
		/// <summary>
		///		Required method for Designer support - do not modify
		///		the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider();
			this.label1 = new System.Windows.Forms.Label();
			this.txtInput = new System.Windows.Forms.TextBox();
			this.btnValidate = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// errorProvider1
			// 
			this.errorProvider1.BlinkRate = 500;
			this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial Black", 12F);
			this.label1.Location = new System.Drawing.Point(8, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(376, 56);
			this.label1.TabIndex = 2;
			this.label1.Text = "The following text box only allows 5 characters.  Try to enter more...";
			// 
			// txtInput
			// 
			this.txtInput.Location = new System.Drawing.Point(144, 80);
			this.txtInput.Name = "txtInput";
			this.txtInput.Size = new System.Drawing.Size(120, 20);
			this.txtInput.TabIndex = 0;
			this.txtInput.Text = "";
			this.txtInput.Validating += new System.ComponentModel.CancelEventHandler(this.txtInput_Validating);
			// 
			// btnValidate
			// 
			this.btnValidate.Location = new System.Drawing.Point(16, 72);
			this.btnValidate.Name = "btnValidate";
			this.btnValidate.Size = new System.Drawing.Size(112, 32);
			this.btnValidate.TabIndex = 1;
			this.btnValidate.Text = "OK";
			// 
			// ErrorForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(400, 125);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.label1,
																		  this.btnValidate,
																		  this.txtInput});
			this.Name = "ErrorForm";
			this.Text = "Error Trapper";
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// 	The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new ErrorForm());
		}

		private void txtInput_Validating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			// Check if the text length is greater than 5.
			if(txtInput.Text.ToString().Length > 5)
			{
				errorProvider1.SetError( txtInput, 
					"Can't be greater than 5!");
			} 
			else
				errorProvider1.SetError(txtInput, "");
		}
	}
}
