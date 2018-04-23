namespace StaticTypes
{
using System;

class StaticApp
{
	// Make some airplanes are examine the static
	// members.
   	 public static int Main(string[] args)
   	 {
		// Make some planes.
		Airplane a1 = new Airplane();
		Airplane a2 = new Airplane();

		// How many are in flight? 
		Console.WriteLine("Number of planes: {0}", 
					      a1.GetNumberFromObject());
		Console.WriteLine("Number of planes: {0}", Airplane.GetNumber());

		// More planes!
		Airplane a3 = new Airplane();
		Airplane a4 = new Airplane();

		// Now how many?
		Console.WriteLine("Number of planes: {0}", 
						  a3.GetNumberFromObject());
		Console.WriteLine("Number of planes: {0}", Airplane.GetNumber());

		return 0;
    	}
}
}
