namespace EventInterface
{
using System;
using System.Collections;

// The engine event interface.
public interface IEngineEvents
{
	void AboutToBlow(string msg);
	void Exploded(string msg);
}

public class Car
{
	// The set of connected sinks.
	ArrayList itfConnections = new ArrayList();

	// Attach or disconnect from the source of events.
	public void Advise(IEngineEvents itfClientImpl)
	{
		itfConnections.Add(itfClientImpl);		
	}
	
	// Note:  To the COM programmers out there, you 
	// understand that IConnectionPoint::Unadvise() takes
	// a registration tolken assigned by ICP::Advise().
	// This is due to the fact that YOU are writing the 
	// code to call the client side sink and need to 
	// shrink the array of IUnknown*'s when a client disconnects.  
	// Because the ArrayList shrinks dynamically, all
	// you need to do is pass in the sink to remove.
	public void Unadvise(IEngineEvents itfClientImpl)
	{
		itfConnections.Remove(itfClientImpl);		
	}

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
			foreach(IEngineEvents e in itfConnections)
				e.Exploded("Sorry, this car is dead...");
		}
		else	
		{
			currSpeed += delta;
			
			// Almost dead?
			if(10 == maxSpeed - currSpeed)
			{
				foreach(IEngineEvents e in itfConnections)
					e.AboutToBlow("Careful buddy!  Gonna blow!");
			}

			// Still OK!
			if(currSpeed >= maxSpeed)
				dead = true;
			else
				Console.WriteLine("->CurrSpeed = " + currSpeed);
		}
	}
}
}

