namespace Shapes
{
using System;

public class ShapesApp
{
    public static int Main(string[] args)
    {
		// The C# base class pointer trick.
		Shape[] s = {new Hexagon(), new Circle(), new Hexagon("Mick"),
					 new Circle("Beth"), new Hexagon("Linda")};

		for(int i = 0; i < s.Length; i++)
		{
			s[i].Draw();
		}

		// Oval hides the base class impl of Draw()
		// and calls its own version.
		Oval o = new Oval();
		o.Draw();

		return 0;
		
    }
}
}
