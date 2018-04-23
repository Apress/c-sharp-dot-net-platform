namespace ResourceTest
{
	using System;
	using System.Resources;
	using System.Drawing;
	using System.Windows.Forms;
	using System.Reflection;

	class ResourceGenerator
	{
		static void Main(string[] args)
		{
			// Make a new *resources file.
			ResourceWriter rw;
			rw = new ResourceWriter("myResources.resources");

			// Add 1 image and 1 string.
			rw.AddResource("happyDude", new Bitmap("happy.Bmp"));

			rw.AddResource("welcomeString", "Welcome to .NET resources.");
			rw.Generate();

			// Now read it all in and show resources. 
			// in a Form.
			try
			{
				MyResourceReader r = new MyResourceReader();
				r.ReadMyResources();
			}
			catch(Exception e)
			{
				System.Console.WriteLine(e.ToString());
			}
		}
	}

	class MyResourceReader
	{
		public void ReadMyResources()
		{
			// Open the resources file.
			ResourceManager rm = new ResourceManager ("myResources", Assembly.GetExecutingAssembly());

			// Load image resource.
			PictureBox p = new PictureBox();
			Bitmap b = (Bitmap)rm.GetObject("happyDude");			
			p.Image = (Image)b;
			p.Height = b.Height;
			p.Width = b.Width;
			p.Location = new Point(10, 10);
			
			// Load string resource.
			Label label1 = new Label();
			label1.Location = new Point(50, 10);
			label1.Font = new Font( label1.Font.FontFamily, 12, FontStyle.Bold);
			label1.AutoSize = true;
			label1.Text = rm.GetString("welcomeString");	
		
			// Build a Form to show the resources.
			Form f = new Form();
			f.Height = 100;
			f.Width = 370;
			f.Text = "These resources are embedded in the assembly!";

			// Add controls & show Form.
			f.Controls.Add(p);
			f.Controls.Add(label1);
			f.ShowDialog();
		}
	}
}

