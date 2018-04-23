namespace ControlByHand
{
    using System;	
	using System.Drawing;
	using System.Windows.Forms;

    class MyForm : Form
	{
		private TextBox firstNameBox = new TextBox(); 
		private Button btnShowControls = new Button();
		
		MyForm()
		{
			this.Text = "Controls in the raw";

			// Add a new text box.
			firstNameBox.Text = "Chucky";
			firstNameBox.Size = new Size(150, 50);
			firstNameBox.Location = new Point(10, 10);
			this.Controls.Add(firstNameBox);

			// Add a new button.
			btnShowControls.Text = "Examine Controls collection";
			btnShowControls.Size = new Size(90, 90);
			btnShowControls.Location = new Point(10, 70);
			btnShowControls.Click += 
				new EventHandler(btnShowControls_Clicked);
			this.Controls.Add(btnShowControls);
			CenterToScreen();

		}
		protected void btnShowControls_Clicked(object sender, EventArgs e)
		{
			Control.ControlCollection coll = this.Controls;
			foreach(Control c in coll)
			{
				if(c != null)
					MessageBox.Show(c.Text, "Index numb: " 
									+ coll.GetChildIndex(c, false)); 	
			}
		}

        public static int Main(string[] args)
        {
			Application.Run(new MyForm());
			return 0;
        }
    }
}
