namespace Shapes
{
using System;

public class ShapesApp
{
	// I'll Draw anything!
	public static void DrawThisShapeIn3D(IDraw3D itf3d)
	{
		itf3d.Draw();
	}
	
    public static int Main(string[] args)
    {

		Line l = new Line();
		l.Draw();

		IDraw3D itfDraw3d= (IDraw3D)l;
		itfDraw3d.Draw();

		// First way to obtain an interface:
		Circle c = new Circle("Mitch");
		IPointy itfPt; 
		try
		{
			itfPt = (IPointy)c;
			Console.WriteLine("Got interface using casting...");
		}
		catch(InvalidCastException e)
		{Console.WriteLine("OOPS!  Not pointy...");}


		// Second way to obtain an interface:
		Hexagon hex = new Hexagon("Fran");
		IPointy itfPt2; 
		itfPt2 = hex as IPointy;
		if(itfPt2 != null)
			Console.WriteLine("Got interface using as keyword");
		else
			Console.WriteLine("OOPS!  Not pointy...");


		// Third way to grab an interface.
		Triangle t = new Triangle();
		if(t is IPointy)
			Console.WriteLine("Got interface using is keyword");
		else	
			Console.WriteLine("OOPS!  Not pointy...");

		Console.WriteLine();

		// The C# base class pointer trick.
		Shape[] s = {new Hexagon(), new Circle(), new Triangle("Joe"), new Circle("JoJo")};
		for(int i = 0; i < s.Length; i++)
		{
			s[i].Draw();

			// Who's pointy?
			if(s[i] is IPointy)
				Console.WriteLine("Points: {0}\n", ((IPointy)s[i]).GetNumberOfPoints());
			else
			Console.WriteLine(s[i].PetName + "\'s not pointy!\n");
		
			
			// Can I draw you in 3D?
			if(s[i] is IDraw3D)
				DrawThisShapeIn3D((IDraw3D)s[i]);
				Console.WriteLine();
		}
		return 0;
		
    }
}
}
