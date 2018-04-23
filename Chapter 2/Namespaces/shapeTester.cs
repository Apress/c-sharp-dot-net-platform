namespace MyApp
{
using System;
using Chapter2Types.MyShapes;
using Chapter2Types.My3DShapes;

using The3DHexagon = Chapter2Types.My3DShapes.Hexagon;

class ShapeTester
{
	public static void Main()
	{
		Chapter2Types.My3DShapes.Hexagon h = new Chapter2Types.My3DShapes.Hexagon();
		Chapter2Types.My3DShapes.Circle c = new Chapter2Types.My3DShapes.Circle();
		Chapter2Types.MyShapes.Square s = new Chapter2Types.MyShapes.Square();

		// Create a 3D hex using a defined alais:
		The3DHexagon h2 = new The3DHexagon();
	}
}
}
