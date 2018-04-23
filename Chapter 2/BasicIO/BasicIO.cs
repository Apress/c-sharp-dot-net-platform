using System;

// Simple string formatting.
class BasicIO
{
	public static void Main(string[] args)
	{
		// Get some stats.
		Console.Write("Enter your name: ");
		
		string s;
		s = Console.ReadLine();
		Console.WriteLine("Hello, {0}", s);
		Console.Write("Enter your age: ");

		s = Console.ReadLine();
		Console.WriteLine("You are {0} years old\n", s);
    	
		// Format a simple string...
		int theInt = 90;
		float theFloat = 9.99F;
		BasicIO myIO = new BasicIO();
		Console.WriteLine("Int is: {0}\nFloat is: {1}\nYou Are: {2}\n",
			theInt, theFloat, myIO.ToString());
		// As an array of object.
		object[] stuff = 
		{
			"Hello", 20.9, 1, "There", "83", 99.99933
		};

		Console.WriteLine("The Stuff: {0}, {1}, {2}, {3}, {4}, {5}", stuff);

		// Now make use of some cool format chars.
		Console.WriteLine("C format: {0:C}", 99989.987);
		Console.WriteLine("D9 format: {0:D9}", 99999);
		Console.WriteLine("E format: {0:E}", 99999.76543);
		Console.WriteLine("F format: {0:F3}", 99999.9999);
		Console.WriteLine("N format: {0:N}", 99999);
		Console.WriteLine("X format: {0:X}", 99999);
		Console.WriteLine("x format: {0:x}", 99999);

		string formStr;
		formStr = string.Format("\nDon't you wish you had {0:C} in your account?", 99989.987);
		Console.WriteLine(formStr);
	}
}

