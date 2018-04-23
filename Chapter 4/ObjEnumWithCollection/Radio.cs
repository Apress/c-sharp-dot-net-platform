namespace ObjEnumWithCollection
{
using System;

public class Radio
{
    public Radio()
    {}

	public void TurnOn(bool on)
	{
		if(on)
			Console.WriteLine("Jamming...");
		else
			Console.WriteLine("Quiet time...");
	}
}
}
