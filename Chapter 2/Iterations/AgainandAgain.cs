namespace Iterations
{
using System;
using System.IO;	// For file reading.

class AgainAndAgain
{
    public static int Main(string[] args)
    {
		// Your basic for loop.  
		for(int i = 0; i < 10; i++)
		{
			Console.WriteLine("Number is: {0}", i);
		}
		
		// Uncomment to generate error.
		// Console.WriteLine(i);

		// Digging into an array using foreach
		// Using foreach with arrays
		string[] arrBookTitles = new string[] {"Complex algorithms", 
											   "COM for the fearful programmer",
										       "Do you remember classic COM?",
											   "C# and the .NET Platform",
										       "COM for the lonely engineer"};
		int COM = 0, NET = 0;

		foreach (string s in arrBookTitles) 
		{
			if (-1 != s.IndexOf("COM"))  
				COM++;      
			else if(-1 != s.IndexOf(".NET"))
				NET++;         
		}
		Console.WriteLine("\n\nFound {0} COM references and {1} .NET references.",
                          COM, NET) ;
		
		// While loop.
		Console.WriteLine("\nHere is the contents config.win");
		Console.WriteLine("****************************************");
		
		try
		{
			StreamReader sr = 
				File.OpenText("c:\\config.win");
			string strLine;
			while(null != (strLine = sr.ReadLine()))
			{
				Console.WriteLine(strLine);
			}
			sr.Close();
			Console.WriteLine("****************************************\n");
		}
		catch(FileNotFoundException e)
		{
			Console.WriteLine(e.Message);
		}
		// Do / while loop.
		string ans;
		do
		{
			Console.Write("Are you done? [yes] [no] : ");
			ans = Console.ReadLine();
		}while(ans != "yes");

		return 0;
    }
}
}
