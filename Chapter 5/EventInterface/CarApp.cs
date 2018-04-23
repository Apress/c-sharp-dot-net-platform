namespace EventInterface
{
using System;

// Car event sink.
public class CarEventSink : IEngineEvents
{
	private string name;

	public CarEventSink(string sinkName)
	{
		name = sinkName;
	}
	public void AboutToBlow(string msg)
	{
		Console.WriteLine(name + " reporting: " + msg);
	}

	public void Exploded(string msg)
	{
		Console.WriteLine(name + " reporting: " + msg);
	}
}

// Make a car and listen to the events.
public class CarApp
{
	public static int Main(string[] args)
	{
		// Make a car as usual. 
		Car c1 = new Car("SlugBug", 100, 10);

		// Make sink object.
		CarEventSink sink = new CarEventSink("First sink");
		CarEventSink myOtherSink = new CarEventSink("Other sink");

		// Hand sink to Car.
		c1.Advise(sink);
		c1.Advise(myOtherSink);

		// Speed up (this will generate the events.)
		for(int i = 0; i < 10; i++)
			c1.SpeedUp(20);

		// Detach sink from events.
		c1.Unadvise(sink);

		// Speed up again (only myothersink will be called.)
		for(int i = 0; i < 10; i++)
			c1.SpeedUp(20);

		// Detach other sink from events.
		c1.Unadvise(myOtherSink);

		return 0;
	}
}

}
