namespace Nested
{
using System;

// C# allows nesting of classes, interfaces and structures.
// Here, the car nests the radio.
public class Car : Object
{
	// Internal state data.
	private int currSpeed;
	private int maxSpeed;
	private string petName;

	// Is the car alive or dead?
	bool dead;
		
		// A nested, private radio.
		private class Radio
		{
		    public Radio()
		    {}

			public void TurnOn(bool on)
			{
				if(on)
					Console.WriteLine("Jamming...");
				else
					Console.WriteLine("Quiet time...");
			}
		}

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
		// If the car is dead, just say so...
		if(dead)
		{
			Console.WriteLine(petName + " is out of order....");
		}
		else	// Not dead, speed up.
		{
			currSpeed += delta;
			if(currSpeed >= maxSpeed)
			{
				Console.WriteLine(petName + " has overheated...");
				dead = true;
			}
			else
				Console.WriteLine("\tCurrSpeed = " + currSpeed);
		}
	}
}
}

