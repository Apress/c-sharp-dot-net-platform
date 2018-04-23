namespace IFaceHierarchy
{
using System;

public class SuperImage : IDraw3
{
	void IDraw.Draw()
	{
		// Basic drawing logic
		Console.WriteLine("Bland drawing...");
	}

	void IDraw2.DrawToPrinter()
	{
		// Draw to a printer.
		Console.WriteLine("Drawing to the printer...");
	}

	void IDraw3.DrawToMetaFile()
	{
		// draw to meta file.
		Console.WriteLine("Drawing to a meta file...");
	}
}
}
