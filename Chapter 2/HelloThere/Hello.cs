using System;

class HelloClass
{
	// Default constructor has been redefined. 
	public HelloClass()
    {	
		Console.WriteLine("Default ctor called!");
    }
		
	// This custom constructor assigns state data to a known value.
	public HelloClass (int x, int y)
	{
			Console.WriteLine("Custom ctor called!");
			intX = x;
			intY = y;
	}
	
	// Sample state data.
	public int intX, intY;

	// Simple member function.
	public void SayHi() {Console.WriteLine("Hi there!");}
}

class HelloApp
{
	// Program entry point.
	public static int Main(string[] args)
	{
		// Process command line arguments...
		if(0 != args.Length)
		{
			for(int x = 0; x < args.Length; x++)
			{
				Console.WriteLine("Arg: {0}", args[x]);
			}

			// One more time using foreach!
			Console.WriteLine("Just in case you missed it the args were:");
			foreach(string s in args)
				Console.WriteLine("Arg: {0}", s);	
		}
		else
			Console.WriteLine("No command line args...\n");

		// Make instance of HelloClass. 
		HelloClass c1 = new HelloClass ();
		c1.SayHi();
		Console.WriteLine("c1.intX = {0}\nc1.intY = {1}\n", c1.intX, c1.intY);
		
		// Another instance of HelloClass.
		HelloClass c2;
		c2 = new HelloClass(100, 200);
		c2.SayHi();
		Console.WriteLine("c2.intX = {0}\nc2.intY = {1}\n", c2.intX, c2.intY);

		return 0;
	}
}