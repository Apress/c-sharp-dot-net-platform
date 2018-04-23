namespace MyResXApp
{
	using System;

	// Want this.
	using System.Resources;

	using System.Drawing;
	using System.Collections;
	using System.Windows.Forms;

	public class ResXForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;

		public ResXForm()
		{
			CenterToScreen();
			InitializeComponent();
		}

		#region This is stuff you don't need to see ;-)
		private void InitializeComponent()
		{
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1.Location = new System.Drawing.Point(16, 16);
			this.button1.Size = new System.Drawing.Size(264, 40);
			this.button1.TabIndex = 0;
			this.button1.Text = "Add resources to *.resx file";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			this.button2.Location = new System.Drawing.Point(16, 88);
			this.button2.Size = new System.Drawing.Size(264, 40);
			this.button2.TabIndex = 1;
			this.button2.Text = "Read *resx file";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(292, 152);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {this.button2,
																		  this.button1});
			this.Text = "ResX-er";
		}
		#endregion

		protected void button2_Click (object sender, System.EventArgs e)
		{
			// Make a resx reader.
			ResXResourceReader r = 
				new ResXResourceReader("ResXForm.resx");
			
			// Grab the IDictEnum interface and show everything.
			IDictionaryEnumerator en = r.GetEnumerator();
			while (en.MoveNext()) 
			{
				MessageBox.Show("Value:" + en.Value.ToString(),
					            "Key: " + en.Key.ToString());
			}
			r.Close();
		}

		protected void button1_Click (object sender, System.EventArgs e)
		{
			// Make a resx writer & specify the file
			// to write to.
			ResXResourceWriter w = 
				new ResXResourceWriter("ResXForm.resx");
			// Add happy dude.
			Image i = new Bitmap("happy.bmp");
			w.AddResource("happyDude", i);
			
			// Add a string.
			w.AddResource("welcomeString", "Hello new resource format!");

			// Commit it and close.
			w.Generate();
			w.Close();
		}

		public static void Main(string[] args) 
		{
			Application.Run(new ResXForm());
		}
	}
}
