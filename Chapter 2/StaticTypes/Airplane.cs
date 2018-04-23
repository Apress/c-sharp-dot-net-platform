namespace StaticTypes
{
using System;

class Airplane
{
	private static int NumberInTheAir = 0;
    public Airplane()
    {
		NumberInTheAir++;
    }
	
	// As object instance.
	public int GetNumberFromObject() { return NumberInTheAir;}

	// As static method.
	public static int GetNumber() { return NumberInTheAir;}
}
}
