namespace Strings
{
using System;
using System.Text;

class StringApp
{
    public static int Main(string[] args)
    {
		System.String strObj = "This is a TEST";
		string s = "This is another TEST";
		
		// Test for equality between the stings.
		if(s == strObj)
			Console.WriteLine("Same info...");
		else
			Console.WriteLine("Not the same info...");

		// Concatenation.
		string newString = s + strObj;
		Console.WriteLine("s + strObj = " + newString + "\n");
		
		// Escape characters.
		string anotherString;
		anotherString = "Every programming book needs \"Hello World\"";
		Console.WriteLine("\t" + anotherString);
		
		anotherString = "c:\\CSharpProjects\\Strings\\string.cs";
		Console.WriteLine("\t" + anotherString + "\n");

		// The @ string turns off the processing of escape characters.
		string finalString = @"\n\tString file: 'C:\CSharpProjects\Strings\string.cs'";
		Console.WriteLine(finalString);

		// Make changes to this string?  Not really...
		System.String strFixed = "This is how I began life";
		Console.WriteLine(strFixed);
		string upperVersion = strFixed.ToUpper();
		Console.WriteLine(strFixed);	
		Console.WriteLine(upperVersion + "\n\n");	

		// Play with the StringBuilder class.
		StringBuilder myBuffer = new StringBuilder("I am a buffer");
		myBuffer.Append(" that just got longer...");
		Console.WriteLine(myBuffer);
		myBuffer.Append("and even longer.");
		Console.WriteLine(myBuffer);
		string theReallyFinalString = myBuffer.ToString().ToUpper();
		Console.WriteLine(theReallyFinalString);

		// Note!  System.String also defines a custom indexer to access each
		// character in the string.
		for(int k = 0; k < s.Length; k++)
			Console.WriteLine("Char {0} is {1}", k, s[k]);

		return 0;
    }
}
}
