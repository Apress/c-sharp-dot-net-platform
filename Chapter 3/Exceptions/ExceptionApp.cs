namespace Exceptions
{
using System;

public class ExceptionApp
{
    public static int Main(string[] args)
    {
		// Make a simple car.
		Car buddha = new Car("Buddha", 100, 20);
		buddha.CrankTunes(true);

		// Try to rev the engine hard!
		try
		{
			for(int i = 0; i < 10; i++)
			{
				buddha.SpeedUp(10);
			}
		}
		catch(CarIsDeadException e)
		{
			Console.WriteLine(e.Message);
			Console.WriteLine(e.StackTrace);
		}
		catch(ArgumentOutOfRangeException e)
		{
			Console.WriteLine(e.Message);
			Console.WriteLine(e.StackTrace);
		}
		finally
		{
			// This will always happen regardless.
			buddha.CrankTunes(false);
		}

		return 0;
    }
}
}
