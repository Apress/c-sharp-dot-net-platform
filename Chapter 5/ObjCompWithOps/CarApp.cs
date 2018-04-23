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

		// Is Rusty less than Chucky?
		if(myAutos[0] < myAutos[4])
			Console.WriteLine("Rusty is less than Chucky!");
		else
			Console.WriteLine("Chucky is less than Rusty!");
		
		return 0;
    }
}
}
