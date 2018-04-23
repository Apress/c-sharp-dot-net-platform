namespace BasicFileApp
{
    using System;
	using System.IO;
	using System.Security.Permissions;

    public class FileManipulator
    {
        public static int Main(string[] args)
        {			
			// Make a new FileInfo.
			FileInfo f = new FileInfo(@"C:\Test.txt");
			FileStream fs = f.Create();

			// Print some basic traits.
			Console.WriteLine("Creation: {0}", f.CreationTime);
			Console.WriteLine("Full name: {0}", f.FullName);
			Console.WriteLine("Full atts: {0}", f.Attributes.ToString());

			Console.WriteLine("Press a key to delete file");
			Console.Read();

			fs.Close();
			f.Delete();			

			// Get a new FileStream object.
			FileInfo f2 = new FileInfo(@"C:\HelloThere.ini");
			FileStream  s = f2.Open(FileMode.OpenOrCreate, 
								FileAccess.ReadWrite, 
								FileShare.None);		

			// Write 20 bytes to the dat file...
			for(int i = 0; i < 256; i++)
			{
				s.WriteByte((byte)i);
			}

			// Reset internal position.
			s.Position = 0;

			// Read 20 bytes from the dat file...
			for(int i = 0; i < 256; i++)
			{
				Console.Write(s.ReadByte());	
			}

			Console.WriteLine("\nPress a key to delete file");
			Console.Read();

			s.Close();
			f2.Delete();

            return 0;
        }
    }
}
