namespace Indexer
{
using System;
using System.Collections;

public class CarApp
{
	public static void Main()
	{
		Console.WriteLine("Basic array iteration...");
		int[] myInts = {10, 9, 100, 432, 9874};

		// Use the [] operator to access each element.
		for(int j = 0; j < myInts.Length; j++)
			Console.WriteLine("Index {0} = {1}", j,  myInts[j]);

		Cars carLot = new Cars();
		
		// Add to car array.
		carLot[0] = new Car("FeeFee", 200, 0);
		carLot[1] = new Car("Clunker", 90, 0);
		carLot[2] = new Car("Zippy", 30, 0);

		// Now get and display each.
		Console.WriteLine("\nUsing indexer...");
		for(int i = 0; i < 3; i++)
		{
			Console.WriteLine("Car number {0}:", i);
			Console.WriteLine("Name: {0}", carLot[i].PetName);
			Console.WriteLine("Max speed: {0}\n", carLot[i].MaxSpeed);
		}

		try
		{	// Iterate using IEnumerable.
			Console.WriteLine("Using IEnumerable...");
			foreach (Car c in carLot)
			{
				Console.WriteLine("Name: {0}", c.PetName);
				Console.WriteLine("Max speed: {0}\n", c.MaxSpeed);
			}
		}
		catch{}			
	}
}
}
