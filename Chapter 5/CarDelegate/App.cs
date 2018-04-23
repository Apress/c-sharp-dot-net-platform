namespace CarDelegateApp
{
using System;

// A helper class
public class ServiceDept
{
	// A target for the delegate.
	public void WashCar(Car c)
	{
		if(c.Dirty)
			Console.WriteLine("Cleaning a car");
		else
			Console.WriteLine("This car is already clean...");
	}
	
	// Another target for the delgate.
	public void RotateTires(Car c)
	{
		if(c.Rotate)
			Console.WriteLine("Tires have been rotated");
		else
			Console.WriteLine("Don't need to be rotated...");

	}
}

public class CarApp
{
	// A target for the delegate.
	/*
	public static void WashCar(Car c)
	{
		if(c.Dirty)
			Console.WriteLine("Cleaning a car");
		else
			Console.WriteLine("This car is already clean...");
	}
	
	// Another target for the delgate.
	public static void RotateTires(Car c)
	{
		if(c.Rotate)
			Console.WriteLine("Tires have been rotated");
		else
			Console.WriteLine("Don't need to be rotated...");

	}
	*/

    public static int Main(string[] args)
    {
		// Make the garage.
		Garage g = new Garage();

		// Make the service department.
		ServiceDept sd = new ServiceDept();
		
		// Wash all dirty cars.
		//g.ProcessCars(new Car.CarDelegate(sd.WashCar));

		// Rotate the tires.
		//g.ProcessCars(new Car.CarDelegate(sd.RotateTires));

		// Create two new delegates. 
		Car.CarDelegate wash = new Car.CarDelegate(sd.WashCar);
		Car.CarDelegate rotate = new Car.CarDelegate(sd.RotateTires);

		// Store the new delegate for later use.
		MulticastDelegate d = wash + rotate;

		// Send the new delegate into the ProcessCars() method.
		g.ProcessCars((Car.CarDelegate)d);
	
		// Remove the rotate pointer.
		Delegate washOnly = MulticastDelegate.Remove(d, rotate);
		g.ProcessCars((Car.CarDelegate)washOnly);
		return 0;
    }
}
}
