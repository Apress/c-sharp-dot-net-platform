namespace ObjEnumWithCollection
{
using System;
using System.Collections;

// No pun intended!
public class CarDriver
{
	public static void Main()
	{
		Cars carLot = new Cars();
		
		// Add some cars.
		carLot.AddCar( new Car("Jasper", 200, 80));
		carLot.AddCar( new Car("Mandy", 140, 0));
		carLot.AddCar( new Car("Porker", 90, 90));
		carLot.AddCar( new Car("Jimbo", 40, 4));

		Console.WriteLine("You have {0} in the lot:\n", carLot.CarCount);
		foreach (Car c in carLot)
		{
			Console.WriteLine("Name: {0}", c.PetName);
			Console.WriteLine("Max speed: {0}\n", c.MaxSpeed);
		}

		// Kill the third car.
		carLot.RemoveCar(3);
		Console.WriteLine("You have {0} in the lot:\n", carLot.CarCount);

		// Add another car and verify it is in the collection.
		Car temp = new Car("Zippy", 90, 90);
		carLot.AddCar(temp);

		if(carLot.CarIsPresent(temp))
			Console.WriteLine(temp.PetName + " is already in the lot.");

		// Kill 'em all.
		carLot.ClearAllCars();
		Console.WriteLine("You have {0} in the lot:\n", carLot.CarCount);
	}
}
}
