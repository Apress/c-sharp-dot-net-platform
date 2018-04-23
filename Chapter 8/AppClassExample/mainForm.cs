namespace AppClassExample
{
	using System;
	using System.Windows.Forms;
	using Microsoft.Win32;

	// Create a  message filter.
	public class MyMessageFilter : IMessageFilter 
	{
		public bool PreFilterMessage(ref Message m) 
		{
			// Intercept the left mouse button down message.
			if (m.Msg == 513) 
			{
				MessageBox.Show("WM_LBUTTONDOWN is: " + m.Msg);
				return true;
			}
			return false;
		}
	}

	public class mainForm : System.Windows.Forms.Form
	{
		private MyMessageFilter msgFliter = new MyMessageFilter();

		public mainForm()
		{
			// Get some properties of this app.
			GetStats();

			// Add a delegate to grab Exit event.
			Application.ApplicationExit += new EventHandler(Form_OnExit);

			// Add a message filter.
			Application.AddMessageFilter(msgFliter);		
		}

		[STAThread]
		static void Main() 
		{
			Application.Run(new mainForm());
		}

		private void GetStats()
		{
			MessageBox.Show(Application.CompanyName, "Company:");
			MessageBox.Show(Application.ProductName, "App Name:");
			MessageBox.Show(Application.StartupPath, "I live here:");
		}

		// Event handlers.
		private void Form_OnExit(object sender, EventArgs evArgs) 
		{
			MessageBox.Show("See ya!", "This app is dead...");
			Application.RemoveMessageFilter(msgFliter);
		}
	}
}
