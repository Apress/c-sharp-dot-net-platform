namespace TextBoxes
{
    using System;
    using System.Drawing;
    using System.Collections;
    using System.ComponentModel;
    using System.Windows.Forms;
    using System.Data;

	public class TextForm : System.Windows.Forms.Form
    {
        private System.ComponentModel.Container components;
		private System.Windows.Forms.Button btnPasswordDecoderRing;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox passwordBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox capsOnlyBox;
		private System.Windows.Forms.Button btnGetMultiLineText;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox multiLineBox;

        public TextForm()
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


		private void InitializeComponent()
		{
			this.capsOnlyBox = new System.Windows.Forms.TextBox();
			this.multiLineBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.passwordBox = new System.Windows.Forms.TextBox();
			this.btnGetMultiLineText = new System.Windows.Forms.Button();
			this.btnPasswordDecoderRing = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.capsOnlyBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.capsOnlyBox.Location = new System.Drawing.Point(14, 176);
			this.capsOnlyBox.Size = new System.Drawing.Size(120, 20);
			this.capsOnlyBox.TabIndex = 3;
			this.multiLineBox.AcceptsReturn = true;
			this.multiLineBox.AcceptsTab = true;
			this.multiLineBox.Location = new System.Drawing.Point(152, 8);
			this.multiLineBox.Multiline = true;
			this.multiLineBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.multiLineBox.Size = new System.Drawing.Size(240, 104);
			this.multiLineBox.TabIndex = 0;
			this.multiLineBox.Text = "Type some stuff here (and hit the return and tab keys...)";
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label1.Location = new System.Drawing.Point(8, 8);
			this.label1.Size = new System.Drawing.Size(136, 56);
			this.label1.TabIndex = 1;
			this.label1.Text = "A muliline textbox that accepts tabs and return keystrokes.";
			this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F);
			this.label2.Location = new System.Drawing.Point(14, 144);
			this.label2.Size = new System.Drawing.Size(106, 24);
			this.label2.TabIndex = 4;
			this.label2.Text = "Caps only!!";
			this.passwordBox.Location = new System.Drawing.Point(160, 176);
			this.passwordBox.PasswordChar = '$';
			this.passwordBox.Size = new System.Drawing.Size(232, 20);
			this.passwordBox.TabIndex = 5;
			this.passwordBox.Text = "COM seems so old fashion";
			this.btnGetMultiLineText.Location = new System.Drawing.Point(13, 72);
			this.btnGetMultiLineText.Size = new System.Drawing.Size(120, 32);
			this.btnGetMultiLineText.TabIndex = 2;
			this.btnGetMultiLineText.Text = "Get Text";
			this.btnGetMultiLineText.Click += new System.EventHandler(this.btnGetMultiLineText_Click);
			this.btnPasswordDecoderRing.Location = new System.Drawing.Point(280, 144);
			this.btnPasswordDecoderRing.Size = new System.Drawing.Size(112, 24);
			this.btnPasswordDecoderRing.TabIndex = 7;
			this.btnPasswordDecoderRing.Text = "Decode Password";
			this.btnPasswordDecoderRing.Click += new System.EventHandler(this.btnPasswordDecoderRing_Click);
			this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F);
			this.label3.Location = new System.Drawing.Point(152, 144);
			this.label3.Size = new System.Drawing.Size(120, 24);
			this.label3.TabIndex = 6;
			this.label3.Text = "Password Box";
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(408, 221);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {this.btnPasswordDecoderRing,
																		  this.label3,
																		  this.passwordBox,
																		  this.label2,
																		  this.capsOnlyBox,
																		  this.btnGetMultiLineText,
																		  this.label1,
																		  this.multiLineBox});
			this.Text = "TextBox Types";

		}

		protected void btnPasswordDecoderRing_Click (object sender, System.EventArgs e)
		{
			MessageBox.Show(passwordBox.Text, "Your password is:");
		}

		protected void btnGetMultiLineText_Click (object sender, System.EventArgs e)
		{
			MessageBox.Show(multiLineBox.Text, "Here is your text");
		}

        public static void Main(string[] args) 
        {
            Application.Run(new TextForm());
        }
    }
}
