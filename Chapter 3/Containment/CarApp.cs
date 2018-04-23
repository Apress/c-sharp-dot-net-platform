namespace Containment
{
using System;

public class CarApp
{
    public static int Main(string[] args)
    {		
		// Make a car.
		Car c1;
		c1 = new Car("SlugBug", 100, 10);

		// Jam some tunes.
		c1.CrankTunes(true);

		// Speed up.
		for(int i = 0; i < 10; i++)
		{
			c1.SpeedUp(20);
		}

		// Shut down.
		c1.CrankTunes(false);
		return 0;
    }
}
}
