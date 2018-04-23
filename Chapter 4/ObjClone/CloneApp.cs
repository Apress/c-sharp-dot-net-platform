namespace ObjClone
{
using System;

public class CloneApp
{
    public static int Main(string[] args)
    {
		// First some shallow copies.
		Point p1 = new Point(50, 50);
		Point p2 = p1;
		p2.x = 0;

		// Print each obj.
		Console.WriteLine("Shallow copying using MemberwiseClone()");
		Console.WriteLine(p1);
		Console.WriteLine(p2);

		// Now some deep copies.
		Point p3 = new Point(100, 100);
		Point p4 = (Point)p3.Clone();
		p4.x = 0;
		
		// Print each obj.
		Console.WriteLine("\nDeep copying using Clone()");
		Console.WriteLine(p3);
		Console.WriteLine(p4 + "\n");

        return 0;
    }

}
}
