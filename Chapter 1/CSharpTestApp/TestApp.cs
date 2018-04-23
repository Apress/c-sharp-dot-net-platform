// The first C# app of the book...
using System;

// Add this!
// using System.Windows.Forms;

class TestApp
{
     public static void Main()
     {
	// System.Console.WriteLine("Testing! 1, 2, 3");

	// Add this!
	// MessageBox.Show("Hello...");
	HelloMessage h = new HelloMessage();
	h.Speak();
     }
}
