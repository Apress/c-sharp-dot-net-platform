namespace StreamWriterReaderApp
{
    using System;
	using System.IO;
	using System.Windows.Forms;

    public class MyStreamWriterReader
    {
        public static int Main(string[] args)
        {
			// Make a file.
			FileInfo f = new FileInfo("Thoughts.txt");

			// Get a StreamWriter and write some stuff.
			StreamWriter writer = f.CreateText();
			writer.WriteLine("Don't forget Mother's Day this year...");
			writer.WriteLine("Don't forget Father's Day this year...");
			writer.WriteLine("Don't forget these numbers:");
			
			for(int i = 0; i < 10; i++)
			{
				writer.Write(i + " ");
			}
			writer.Write(writer.NewLine);

			// Closing automatically flushes!
			writer.Close();
			Console.WriteLine("Created file and wrote some thoughts...");


			// Now read it all back in.
			Console.WriteLine("Here are your thoughts:\n");
			StreamReader sr = File.OpenText("Thoughts.txt");

			string input = null;
			while ((input = sr.ReadLine()) != null)
			{
				Console.WriteLine (input);
			}

            return 0;
        }
    }
}
