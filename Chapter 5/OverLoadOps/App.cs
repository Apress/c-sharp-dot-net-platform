namespace OverLoadOps
{
using System;

public class App
{
	public static int Main(string[] args)
    {
        // Make two points
		Point ptOne = new Point(100, 100);
		Point ptTwo = new Point(40, 40);

		// Add both points to make a new point.
		Point bigPoint = ptOne + ptTwo;
		Console.WriteLine("Here is the big point: {0}", bigPoint.ToString());

		// Subtract the points to make a new point.
		Point minorPoint = bigPoint - ptOne;
		Console.WriteLine("Just a minor point: {0}", minorPoint.ToString());

		// Are they the same?
		if(ptOne == ptTwo)
			Console.WriteLine("Same values!");
		else
			Console.WriteLine("Nope, different values");

		if(ptOne != ptTwo)
			Console.WriteLine("These are not equal\n");
		else
			Console.WriteLine("Same values!");

		// As member f(x)'s
		Point finalPt = Point.AddPoints(ptOne, ptTwo);
		Console.WriteLine("My final point: {0}\n", finalPt.ToString());
        return 0;
    }
}
}
