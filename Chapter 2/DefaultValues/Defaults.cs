namespace DefaultValues
{
using System;

class DefValObject
{
	// Here are a number of fields...
	public sbyte	theSignedByte;
	public byte		theByte;
	public short	theShort;
	public ushort	theUShort;
	public int		theInt;
	public uint		theUInt;
	public long		theLong;
	public ulong	theULong;
	public char		theChar;
	public float	theFloat;
	public double	theDouble;
	public bool		theBool;
	public decimal	theDecimal;
	public string	theStr;
	public object	theObj;

    public static int Main(string[] args)
    {
		DefValObject v = new DefValObject();

		// Print out default values.
		Console.WriteLine("bool: {0}", v.theBool);
		Console.WriteLine("byte: {0}", v.theByte);
		Console.WriteLine("char: {0}", v.theChar);
		Console.WriteLine("decimal: {0}", v.theDecimal);
		Console.WriteLine("double: {0}", v.theDouble);
		Console.WriteLine("float: {0}", v.theFloat);
		Console.WriteLine("int: {0}", v.theInt);
		Console.WriteLine("long: {0}", v.theLong);
		Console.WriteLine("object: {0}", v.theObj);
		Console.WriteLine("short: {0}", v.theShort);
		Console.WriteLine("signed byte: {0}", v.theSignedByte);
		Console.WriteLine("string: {0}", v.theStr);
		Console.WriteLine("unsigned int: {0}", v.theUInt);
		Console.WriteLine("unsigned long: {0}", v.theULong);
		Console.WriteLine("unsigned short: {0}", v.theUShort);

        return 0;
    }
}
}
