namespace CarEvents
{
using System;


// Car event sink
public class CarEventSink
{
	// OnBlowUp event sink A.
	public void OnBlowUp(string s)
	{
			Console.WriteLine("Message from car: {0}", s);
	}

	// OnBlowUp event sink B.
	public void OnBlowUp2(string s)
	{
		Console.WriteLine("-->AGAIN I say: {0}", s);
	}

	// OnAboutToBlow event sink.
	public void OnAboutToBlow(string s)
	{
			Console.WriteLine("Message from car: {0}", s);
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
		CarEventSink sink = new CarEventSink();

		// Hook into events.
		Car.Exploded += new Car.EngineHandler(sink.OnBlowUp);
		Car.Exploded += new Car.EngineHandler(sink.OnBlowUp2);
		Car.AboutToBlow += new Car.EngineHandler(sink.OnAboutToBlow);

		// Speed up (this will generate the events.)
		for(int i = 0; i < 10; i++)
			c1.SpeedUp(20);

		// Detach from events.
		Car.Exploded -= new Car.EngineHandler(sink.OnBlowUp);
		Car.Exploded -= new Car.EngineHandler(sink.OnBlowUp2);
		Car.Exploded -= new Car.EngineHandler(sink.OnAboutToBlow);

		// No response! 
		for(int i = 0; i < 10; i++) c1.SpeedUp(20);

		return 0;
	}
}

}
