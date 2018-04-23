namespace CarDelegateApp
{
using System;
using System.Collections;

// This delegate encapsulates a function pointer
// to some method taking a Car and returning void.
// public delegate void CarDelegate(Car c);

public class Garage
{
	// We have some cars.
	ArrayList theCars = new ArrayList();

	public Garage()
	{
		theCars.Add(new Car("Viper", 100, 0, true, false));
		theCars.Add(new Car("Fred", 100, 0, false, false));
		theCars.Add(new Car("BillyBob", 100, 0, false, true));
		theCars.Add(new Car("Bart", 100, 0, true, true));
		theCars.Add(new Car("Stan", 100, 0, false, true));
	}

	// This method takes a CarDelegate as a parameter.
	// Therefore!  'proc' is nothing more than a function pointer...
	public void ProcessCars(Car.CarDelegate proc)
	{
		// Where are we passing the call?
		foreach(Delegate d in proc.GetInvocationList())
		{
			Console.WriteLine("***** Calling: {0} *****", 
							  d.Method.ToString());
		}

		// Am I calling an object's method or a static method?
		if(proc.Target != null)
			Console.WriteLine("\n-->Target: " + proc.Target.ToString());
		else
			Console.WriteLine("\n-->Target is a static method");

		// Now call method for each car.
		foreach(Car c in theCars)
			proc(c);	

		Console.WriteLine();
	}
}
}
