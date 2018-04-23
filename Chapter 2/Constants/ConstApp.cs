namespace Constants
{
using System;

class ConstApp
{
	public static void Main() 
	{
		const string localConst = "I am a rock, I am an island";
		// Use const data.
		Console.WriteLine("myIntConst = {0}\nmyStringConst = {1}\nLocalConst = {2}", 
				          MyConstants.myIntConst, 
						  MyConstants.myStringConst,
						  localConst);

		// Uncomment to generate compiler errors.
		// MyConstants.myIntConst = 987;
		// MyConstants.myStringConst = "No I'm not!";
		// MyConstants c = new MyConstants();
	}
}
}
