using System;

class PlatformSpy
{
    public static int Main(string[] args)
    {
		// OS?
		Console.WriteLine("Current OS:\n{0}\n", Environment.OSVersion);

		// Directory?
		Console.WriteLine("Current Directory:\n{0}\n", 
				        Environment.CurrentDirectory);

		// Here are the drives on this box.
		string[] drives = Environment.GetLogicalDrives();
		for(int i = 0; i < drives.Length; i++)
			Console.WriteLine("Drive {0} : {1}",  i, drives[i]);
		
		// Which version of the .NET platform?
		Console.WriteLine("Current version of .NET: {0}\n", 
			            Environment.Version);
		
		return 0;
    }
}

