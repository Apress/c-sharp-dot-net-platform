namespace Indexer
{
using System;

public class Car
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
		// If the car is dead, just say so...
		if(dead)
		{
			Console.WriteLine("{0} is out of order....", petName);
		}
		else	// Not dead, speed up.
		{
			currSpeed += delta;
			if(currSpeed >= maxSpeed)
			{
				Console.WriteLine("{0} has overheated...", petName);
				dead = true;
			}
			else
				Console.WriteLine("\tCurrSpeed = {0}", currSpeed);
		}
	}

	// Properties.
	public string PetName
	{
		get { return petName; }
		set { petName = value;}
	}
	public int CurrSpeed
	{
		get { return currSpeed; }
		set { currSpeed = value;}
	}
	public int MaxSpeed
	{
		get { return maxSpeed; }
		set { maxSpeed = value;}
	}
}
}

