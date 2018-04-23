namespace Arrays
{
using System;

class Arrays
{
    public static int Main(string[] args)
    {
		/* Array declarations */
		Console.WriteLine("See source code for array declaration examples...");
		
		// A string array containing 10 elements {0, 1, ...,9}.
		string[] booksOnCOM;	
		booksOnCOM = new string[10];		

		// A 2 item string array, numbered {0, 1}
		string[] booksOnPL1 = new string[2];	

		// 100 item string array, numbered {0, 1, ..., 99}
		string[] booksOnDotNet = new string[100];	

		// The size of this array will automatically be set to 4.  
		// Note the lack of the 'new' keyword.
		int[] ages = {20, 22, 23, 0};
	
		// Need 'new' keyword when you define a fixed size array.
		// Uncomment to trigger error.
		// int[4] ages = {30, 54, 4, 10};		// Error!  


		// Initialize items at startup or...
		Console.WriteLine("Created array of strings.");
		string[] firstNames = 
			new string[5]{"Steve", "Gina", "Swallow", "Baldy", "Gunner"};

		// ...go member by member.
		/*
		string[] firstNames = new string[4];
		firstNames[0] = "Steve";
		firstNames[1] = "Gina";
		firstNames[2] = "Swallow";
		firstNames[3] = "Baldy";
		firstNames[4] = "Gunner";
		*/
		
		// Print out names in declared order.
		Console.WriteLine("Here is the array:");

		for(int i = 0; i < firstNames.Length; i++)
		{
			// Print a name
			Console.Write(firstNames[i] + "\t");
		}
		
		// Reverse them...
		Array.Reverse(firstNames);
		Console.WriteLine("\n\n");

		// ... and print them.
		Console.WriteLine("Here is the array once reversed:");
		for(int i = 0; i < firstNames.Length; i++)
		{
			Console.Write(firstNames[i] + "\t");
		}
		Console.WriteLine("\n\n");

		// Clear out all but the final member.
		Console.WriteLine("Cleared out all but one...");
		Array.Clear(firstNames, 1, 4);
		for(int i = 0; i < firstNames.Length; i++)
		{
			Console.Write(firstNames[i] + "\t\n");
		}

		Console.WriteLine("A rectangular MD array:\n");
		int[,] myMatrix;
		myMatrix = new int[6,6];

		// Populate (6 * 6) array.
		for(int i = 0; i < 6; i++)
			for(int j = 0; j < 6; j++)
				myMatrix[i, j] = i * j;

		// Show (6 * 6) array.
		for(int i = 0; i < 6; i++)
		{
			for(int j = 0; j < 6; j++)
			{				
				Console.Write(myMatrix[i, j] + "\t");
			}
			Console.WriteLine();
		}

		Console.WriteLine("\nA jagged MD array:\n");   
        int[][] myJagArray = new int[5][];

        // Create the jagged array.
        for (int i = 0; i < myJagArray.Length; i++)
        {
            myJagArray[i] = new int[i + 7];
        }
 
        // Print each row (remember, each element is 
		// defaulted to zero!
		for(int i = 0; i < 5; i++)
		{
			Console.Write("Length of row {0} is {1}:\t", i, myJagArray[i].Length);
			for(int j = 0; j < myJagArray[i].Length; j++)
			{								
				Console.Write(myJagArray[i][j] + " ");
			}
			Console.WriteLine();
		}
		
		return 0;
    }
}
}
