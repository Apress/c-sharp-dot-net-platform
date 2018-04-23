namespace CalcClient
{
	using System;
	using localhost;

	public class WebConsumer
	{
		public static int Main(string[] args)
		{
			// Work with the web service.
			Service1 w = new Service1();
			Console.WriteLine("100 + 100 is {0}",
				w.Add(100 , 100));
			try
			{
				w.Divide(0, 0);
			}
			catch(DivideByZeroException e)
			{
				Console.WriteLine(e.Message);
			}
			return 0;
		}
	}
}
