namespace PInvokeExample
{
    using System;
	
	// Must have to gain access to the necessary
	// attributes.
	using System.Runtime.InteropServices;

    public class PInvokeClient
    {
		// The Win32 MessageBox C function.
		[DllImport("user32", ExactSpelling = true,
			       CharSet=CharSet.Unicode, 
				   EntryPoint = "MessageBoxW")]
		public static extern int DisplayMessage(int hWnd,
											String  pText,
											String  pCaption,
											int uType);

        public static int Main(string[] args)
        {
			// Send in some managed data.
			String pText = "Hello World!";
			String pCaption = "PInvoke Test";

			// Moniker for MessageBoxW.
			DisplayMessage(0, pText, pCaption, 0);
            return 0;
        }
    }
}
