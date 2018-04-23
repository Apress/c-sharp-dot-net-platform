namespace Exceptions
{
using System;

// Custom exception.
public class CarIsDeadException : System.Exception
{
	// Constructors for this exception.
	public CarIsDeadException(){}

	public CarIsDeadException(string message)
		: base(message){}

	public CarIsDeadException(string message, Exception innerEx)
		: base(message, innerEx){}
}

public class Car : Object
{
	// Internal state data.
	private int currSpeed;
	private int maxSpeed;
	private string petName;

	// Is the car alive or dead?
	bool dead;

	// A car has-a radio.
	private Radio theMusicBox;

	public Car()
    {
		maxSpeed = 100;
		dead = false;
		// Outer class creates the inner class(es)
		// upon start-up.
		// NOTE:  If we did not, theMusicBox would
		// begin as a null reference.
		theMusicBox = new Radio();
	}

	public Car(string name, int max, int curr)
    {
		currSpeed = curr;
		maxSpeed = max;
		petName = name;
		dead = false;
		theMusicBox = new Radio();
    }

	public void CrankTunes(bool state)
	{
		// Tell the radio play (or not).
		// Delegate request to inner object.
		theMusicBox.TurnOn(state);
	}

	public void SpeedUp(int delta) 
	{
		// Bad param?
		if(delta < 0)
			throw new ArgumentOutOfRangeException("Speed must be greater than zero");

		// If the car is dead, just say so...
		if(dead)
		{
			// Throw 'Car is dead' exception.
			throw new CarIsDeadException(this.petName + " has bought the farm!");
		}
		else	// Not dead, speed up.
		{
			currSpeed += delta;
			if(currSpeed >= maxSpeed)
			{
				dead = true;
			}
			else
				Console.WriteLine("\tCurrSpeed = " + currSpeed);
		}
	}
}
}

