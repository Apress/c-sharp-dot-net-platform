namespace MyRawWindow
{
    using System;
	using System.Windows.Forms;
	
    public class MainWindow : Form
    {
        public MainWindow(){}

		// Run this application.
		public static int Main(string[] args) 
		{
			Application.Run(new MainWindow());
			return 0;
		}

    }
}
