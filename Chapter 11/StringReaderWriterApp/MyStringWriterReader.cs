namespace StringWriterReaderApp
{
    using System;
	using System.IO;
	using System.Windows.Forms;
	
	// For StringBuilder type
	using System.Text;

    public class MyStringWriterReader
    {
        public static int Main(string[] args)
        {
			// Get a StringWriter and write some stuff.
			StringWriter writer = new StringWriter();
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
			Console.WriteLine("Stored thoughts in a StringWriter...");

			// Get a copy of the contents (stored in a string) and pump
			// to console.
			Console.WriteLine("Contents:\n" + writer);
			
			
			// Get the internal StringBuilder.
			StringBuilder str = writer.GetStringBuilder();
			string allOfTheData = str.ToString();
			Console.WriteLine("StringBuilder says:\n{0}", allOfTheData);

			// Insert item to buffer.
			str.Insert(20, "INSERTED STUFF");
			allOfTheData = str.ToString();
			Console.WriteLine("New StringBuilder says:\n{0}", allOfTheData);

			// Remove the inserted string.
			str.Remove(20, "INSERTED STUFF".Length);
			allOfTheData = str.ToString();
			Console.WriteLine("Original says:\n{0}", allOfTheData);

			// Now dump using a StringReader.
			Console.WriteLine("Here are your thoughts:\n");
			StringReader sr = new StringReader(writer.ToString());
			
			string input = null;
			while ((input = sr.ReadLine()) != null)
			{
				Console.WriteLine (input);
			}

			sr.Close();

            return 0;
        }
    }
}
