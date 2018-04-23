namespace FileManipulation
{
    using System;
	using System.IO;

	class MyDirectory
	{
		public static void Main(String[] args)
		{
			// Create a new directoryinfo object bound to the D drive.
			//DirectoryInfo dir1 = new DirectoryInfo(@"D:\");

			// Create a new directoryinfo object bound to the current directory.
			//DirectoryInfo dir2 = new DirectoryInfo(".");

			// Create a new directoryinfo object bound to C:\Foo\Bar.
			//DirectoryInfo dir3 = new DirectoryInfo(@"C:\Foo\Bar");

			// Create a new directoryinfo object we will really use.
			DirectoryInfo dir = new DirectoryInfo(@"C:\WinNT");
			
			// Dump directory information.
			Console.WriteLine("***** Directory Info *****");
			Console.WriteLine("FullName: {0}", dir.FullName);
			Console.WriteLine("Name: {0}", dir.Name);
			Console.WriteLine("Parent: {0}", dir.Parent);
			Console.WriteLine("Creation: {0}", dir.CreationTime);
			Console.WriteLine("Attributes: {0}", dir.Attributes.ToString());
			Console.WriteLine("Root: {0}", dir.Root);
			Console.WriteLine("**************************\n");


			// Examine the contents of the D drive,
			// and look for bitmap files.
			FileInfo[] bitmapFiles = dir.GetFiles("*.bmp");

			Console.WriteLine("Found {0} *.bmp files\n", bitmapFiles.Length);
				
			foreach (FileInfo f in bitmapFiles) 
			{
				// Now print out info for the file.
				Console.WriteLine("***************************\n");
				Console.WriteLine("File name: {0}", f.Name);
				Console.WriteLine("File size: {0}", f.Length);
				Console.WriteLine("Creation: {0}", f.CreationTime);
				Console.WriteLine("Attributes: {0}", f.Attributes.ToString());
				Console.WriteLine("***************************\n");
			}

			// Now make a new directory on the D:\WinNT root:
			try
			{
				// Create D:\WinNT\MyFoo
				DirectoryInfo d = dir.CreateSubdirectory("MyFoo");
				Console.WriteLine("Created: {0}", d.FullName);

				// Create D:\WinNT\MyBar\MyQaaz
				d = dir.CreateSubdirectory(@"MyBar\MyQaaz");
				Console.WriteLine("Created: {0}", d.FullName);
			}
			catch(IOException e)
			{
				Console.WriteLine(e.Message);
			}
			
			// Now call some static members...

			// Get all drives.
			string[] drives = Directory.GetLogicalDrives();
			Console.WriteLine("Here are your drives:");
			foreach(string s in drives)
			{
				Console.WriteLine("--> {0}", s);
			}

			// Now delete what we made.
			Console.Write("Going to delete\n->" +
						  dir.FullName + "\\MyBar\\MyQaaz.\n" + 
						  "and\n->" + dir.FullName + "\\MyFoo.\n" +					
						  "Press a key to continue!");
			Console.Read();

			// Blow em away...
			try
			{
				Directory.Delete(@"C:\WinNT\MyFoo");
				Directory.Delete(@"C:\WinNT\MyBar", true);
			}
			catch(IOException e)
			{
				Console.WriteLine(e.Message);
			}
		}
	}
}
