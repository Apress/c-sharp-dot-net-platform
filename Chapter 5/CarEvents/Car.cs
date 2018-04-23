namespace CarEvents
{
using System;

public class Car
{

	public class Radio
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

	// The delegate for our events.
	public delegate void EngineHandler(string msg);

	// This car can send these events.
	public static event EngineHandler Exploded;
	public static event EngineHandler AboutToBlow;

	// Internal state data.
	private int currSpeed;
	private int maxSpeed;
	private string petName;

	// Is the car alive or dead?
	private bool dead;

	// A car has-a radio.
	private Radio theMusicBox;

	public Car()
    {
		maxSpeed = 100;
		dead = false;
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
		theMusicBox.TurnOn(state);
	}

	public void SpeedUp(int delta)
	{
		// If the car is dead, send event.
		if(dead)
		{
			if(Exploded != null)
				Exploded("Sorry, this car is dead...");
		}
		else	
		{
			currSpeed += delta;
			
			// Almost dead?
			if(10 == maxSpeed - currSpeed)
				if(AboutToBlow != null)
					AboutToBlow("Careful, approaching terminal speed!");

			// Still OK!
			if(currSpeed >= maxSpeed)
				dead = true;
			else
				Console.WriteLine("--> CurrSpeed = " + currSpeed);
		}
	}

}
}

