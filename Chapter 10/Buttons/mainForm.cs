namespace Buttons
{
	using System;
	using System.Drawing;
	using System.Collections;
	using System.ComponentModel;
	using System.Windows.Forms;
	using System.Data;

	public class ButtonForm : System.Windows.Forms.Form
	{
		private System.ComponentModel.Container components;
		private System.Windows.Forms.Button btnImage;
		private System.Windows.Forms.Button btnStandard;
		private System.Windows.Forms.Button btnPopup;
		private System.Windows.Forms.Button btnFlat;

		// Hold the current text alignment
		ContentAlignment currAlignment = ContentAlignment.MiddleCenter;
		int currEnumPos = 0;
    
		public ButtonForm()
		{
			InitializeComponent();

			// Set btnStandard as default accept.
			this.AcceptButton = btnStandard;

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
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(ButtonForm));
			this.btnStandard = new System.Windows.Forms.Button();
			this.btnFlat = new System.Windows.Forms.Button();
			this.btnImage = new System.Windows.Forms.Button();
			this.btnPopup = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnStandard
			// 
			this.btnStandard.BackgroundImage = ((System.Drawing.Bitmap)(resources.GetObject("btnStandard.BackgroundImage")));
			this.btnStandard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.btnStandard.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnStandard.Location = new System.Drawing.Point(16, 80);
			this.btnStandard.Name = "btnStandard";
			this.btnStandard.Size = new System.Drawing.Size(312, 88);
			this.btnStandard.TabIndex = 2;
			this.btnStandard.Text = "I am a standard button";
			this.btnStandard.Click += new System.EventHandler(this.btnStandard_Click);
			// 
			// btnFlat
			// 
			this.btnFlat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFlat.ForeColor = System.Drawing.Color.Blue;
			this.btnFlat.Location = new System.Drawing.Point(16, 24);
			this.btnFlat.Name = "btnFlat";
			this.btnFlat.Size = new System.Drawing.Size(152, 32);
			this.btnFlat.TabIndex = 0;
			this.btnFlat.Text = "I am flat...";
			// 
			// btnImage
			// 
			this.btnImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
			this.btnImage.Image = ((System.Drawing.Bitmap)(resources.GetObject("btnImage.Image")));
			this.btnImage.Location = new System.Drawing.Point(16, 192);
			this.btnImage.Name = "btnImage";
			this.btnImage.Size = new System.Drawing.Size(312, 72);
			this.btnImage.TabIndex = 3;
			this.btnImage.Text = "Image Button";
			this.btnImage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// btnPopup
			// 
			this.btnPopup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnPopup.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnPopup.Location = new System.Drawing.Point(176, 24);
			this.btnPopup.Name = "btnPopup";
			this.btnPopup.Size = new System.Drawing.Size(152, 32);
			this.btnPopup.TabIndex = 1;
			this.btnPopup.Text = "I am a Popup!";
			// 
			// ButtonForm
			// 
			this.AcceptButton = this.btnStandard;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(340, 269);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.btnImage,
																		  this.btnStandard,
																		  this.btnPopup,
																		  this.btnFlat});
			this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Name = "ButtonForm";
			this.Text = "Buttons";
			this.ResumeLayout(false);

		}
		#endregion
		
		protected void btnStandard_Click (object sender, System.EventArgs e)
		{			
			// Get all possible values
			// of the ContentAlignment enum.
			Array values = Enum.GetValues(currAlignment.GetType());
		
			// Bump the current position in the enum.
			// & check for wrap around.
			currEnumPos++;
			if(currEnumPos >= values.Length)
				currEnumPos = 0;
			
			// Bump the current enum value.
			currAlignment = (ContentAlignment)ContentAlignment.Parse(currAlignment.GetType(), 
							values.GetValue(currEnumPos).ToString());
			btnStandard.TextAlign = currAlignment;

			// Paint enum value name on button.
			btnStandard.Text = currAlignment.ToString();

			// Now assign the location of the ICON on
			// btnImage...
			btnImage.ImageAlign = currAlignment;
		}

		[STAThread]
		public static void Main(string[] args) 
		{
			Application.Run(new ButtonForm());
		}
	}
}
