namespace Selections
{
using System;

class Selections
{
    public static int Main(string[] args)
    {
		// Prompt user with choices.
		Console.WriteLine("Welcome to the world of .NET");
		Console.WriteLine("1 = C#\n2 = Managed C++ (MC++)\n3 = VB.NET\n"); 
		Console.Write("Please select your implementation language:"); 

		// Get choice.
		string s = Console.ReadLine(); 
		int n = int.Parse(s);
		
		// Based on input, act accordingly...
		switch(n) 
		{
			case 1:
				Console.WriteLine("\nGood choice!  C# is all about managed code.");
            break;
		
			case 2:
				Console.WriteLine("\nLet me guess, your maintaining a legacy system?");
            break;
			
			case 3:
				Console.WriteLine("\nVB.NET:  It is not for just kids anymore...");
            break;
			
			default:
				Console.WriteLine("\nWell...good luck with that!");
			break;
		}
      return 0;
    }
}
}
