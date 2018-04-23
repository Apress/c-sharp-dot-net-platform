namespace CarDelegateApp
{
using System;

public class Car : Object
{	
	// This delegate encapsulates a function pointer
	// to some method taking a Car and returning void.
	// This is represented as Car$CarDelegate (e.g. is nested).
	public delegate void CarDelegate(Car c);
	
	// The nested car type.
	public class Radio
	{
	    public Radio(){}
		public void TurnOn(bool on)
		{
			if(on)
				Console.WriteLine("Jamming...");
			else
				Console.WriteLine("Quiet time...");
		}
	}

	// Internal state data.
	private int currSpeed;
	private int maxSpeed;
	private string petName;
	
	// Is the car alive or dead?
	private bool dead;

	// NEW!  Are we in need of a wash?
	private bool isDirty;

	// NEW!  Are we in need of a wash?
	private bool shouldRotate;	
	
	// A car has-a radio.
	private Radio theMusicBox;
	
	public bool Dirty
	{
		get{ return isDirty; }
		set{ isDirty = value; }
	}
	
	public bool Rotate
	{
		get{ return shouldRotate; }
		set{ shouldRotate = value; }
	}
	
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

	public Car(string name, int max, int curr, bool dirty, bool rotate)
    {
		currSpeed = curr;
		maxSpeed = max;
		petName = name;
		dead = false;
		isDirty = dirty;
		shouldRotate = rotate;
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
			Console.WriteLine("Car is already dead...");
		else	// Not dead, speed up.
		{
			currSpeed += delta;
			if(currSpeed >= maxSpeed)
				dead = true;
			else
				Console.WriteLine("\tCurrSpeed = " + currSpeed);
		}
	}
}
}

