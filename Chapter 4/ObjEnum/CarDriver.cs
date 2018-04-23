namespace ObjEnum
{
using System;
using System.Collections;

// No pun intended!
public class CarDriver
{
	public static void Main()
	{
		Cars carLot = new Cars();

		try
		{
			foreach (Car c in carLot)
			{
				Console.WriteLine("Name: {0}", c.PetName);
				Console.WriteLine("Max speed: {0}", c.MaxSpeed + "\n");
			}
		}
		catch{}

		// Now ala IEnumerator
		IEnumerator itfEnum;
		itfEnum = (IEnumerator)carLot;

		// Reset the cursor to the beginning.
		itfEnum.Reset();

		// Advance internal cursor by 1.
		itfEnum.MoveNext();
		
		// Cast to a Car and crank some tunes.
		object curCar = itfEnum.Current;
		((Car)curCar).CrankTunes(true);
	}
}
}
