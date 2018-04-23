namespace Calculator
{
    using System;

    public class Calc
    {
		// Default ctor.
        public Calc(){}
		
		// A single method.
		public int Add(int x, int y)
		{
			return x + y;
		}

        public static int Main(string[] args)
        {
			Calc c = new Calc();
			int ans = c.Add(10, 84);
			Console.WriteLine("10 + 84 is {0}.", ans);
			return 0;
        }
    }
}
