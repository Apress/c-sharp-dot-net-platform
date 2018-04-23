namespace ObjComp
{
using System;


public class CarApp
{
    public static int Main(string[] args)
    {
		// Make an array of Car types.
		Car[] myAutos = new Car[5];
		myAutos[0] = new Car(123, "Rusty");
		myAutos[1] = new Car(6, "Mary");
		myAutos[2] = new Car(6, "Viper");
		myAutos[3] = new Car(13, "NoName");
		myAutos[4] = new Car(6, "Chucky");

		// Dump current array.
		Console.WriteLine("Here is the unordered set of cars:");
		foreach(Car c in myAutos)
			Console.WriteLine(c.ID + "  " + c.PetName);	

		// Now, sort them using IComparable.
		Array.Sort(myAutos);
		
		// Dump sorted array.
		Console.WriteLine("\nHere is the ordered set of cars:");
		foreach(Car c in myAutos)
			Console.WriteLine(c.ID + "  " + c.PetName);	

		// Now sort by pet name.
		// Array.Sort(myAutos, new SortByPetName());

		// or...
		Array.Sort(myAutos, Car.SortByPetName);

		// Dump sorted array.
		Console.WriteLine("\nOrdering by pet name:");
		foreach(Car c in myAutos)
			Console.WriteLine(c.ID + "  " + c.PetName);	
		return 0;
    }

}
}
