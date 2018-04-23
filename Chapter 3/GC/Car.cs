namespace GC
{
using System;

// This car implements IDisposable
// in order to allow the object
// user to manually deallocate resources.
public class Car : IDisposable
{
	// Internal state data.
	private int currSpeed;
	private int maxSpeed;
	private string petName;

	public Car(){maxSpeed = 100;}

	public Car(string name, int max, int curr)
    {
		currSpeed = curr;
		maxSpeed = max;
		petName = name;
    }

	// Object.Finalize() in disguise!
	// If the object is GC-ed just call the
	// Dispose() method to do the real
	// work.
	~Car()
	{
		Console.WriteLine("In destructor for {0}!", petName);
		Dispose();
	}
	
	// IDisposable impl.
	public void Dispose()
	{
		// Clean up any resources here...
		
		// No need to finalize if user 
		// called Dispose() manually.
		Console.WriteLine("In Dispose() for {0}!", petName);
		GC.SuppressFinalize(this);
	}
}
}