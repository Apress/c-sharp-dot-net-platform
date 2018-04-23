namespace Exceptions
{
	using System;

	public class App
	{
		public static void Main()
		{
			// Make a car.
			Car buddha = new Car("Buddha", 100, 20);

			// Try to rev the engine hard!
			try
			{
				for(int i = 0; i < 10; i++)
				{
					buddha.SpeedUp(10);
				}
			}
			catch(Exception e)	// Print message and stack trace. 
			{
				Console.WriteLine(e.Message);
				Console.WriteLine(e.StackTrace);
			}
		}
	}
}
