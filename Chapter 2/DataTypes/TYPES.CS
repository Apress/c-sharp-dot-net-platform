namespace DataTypes
{
using System;

class MyDataTypes
{
	public static void Foo(object o)
	{
		Console.WriteLine(o.GetType());
		Console.WriteLine(o.ToString());
		Console.WriteLine("Value of o is: " + o);
	}

    public static int Main(string[] args)
    {
		// Test value semantics.
		System.Int32 intA = 1001;
		System.Int32 intB = 1000;
		if(intA == intB)
			Console.WriteLine("Same value!\n");
		else
			Console.WriteLine("Not the same value!\n");

		// Working with UInt16 as a wrapper.
		System.UInt16 myUInt16 = 30000;
		Console.WriteLine("Max for an UInt16 is: {0}", UInt16.MaxValue);
		Console.WriteLine("Min for an UInt16 is: {0}", UInt16.MinValue);
		Console.WriteLine("Your value is: {0}", myUInt16.ToString());
		Console.WriteLine("I am a: {0}", myUInt16.GetType().ToString());
		
		// Now in UInt16 shorthand (e.g. a ushort).
		ushort myOtherUInt16 = 12000;
		Console.WriteLine("\nYour value is: {0}", myOtherUInt16.ToString());
		Console.WriteLine("I am a: {0}", myOtherUInt16.GetType().ToString());

		// Boxing and unboxing.
		Console.WriteLine("\nNow for some boxing...");
		
		// Make a simple value.
		short s = 25;
		Console.WriteLine("short s = {0}", s);
		Console.WriteLine("short is a: {0}\n", s.GetType().ToString());

		// Box the value into a reference.
		object objShort = s;
		Console.WriteLine("Boxed object is a: {0}\n", objShort.GetType().ToString());
		
		// Now, unbox the reference back into a short:
		short anotherShort = (short)objShort;
		Console.WriteLine("short anotherShort = {0}", anotherShort);
		Console.WriteLine("Unboxed object is a: {0}", anotherShort.GetType().ToString());

		// Bad unboxing!
		try
		{
			// The type contained in the box is NOT a
			// string, but a short!
			string str = (string)objShort;
		}
		catch(InvalidCastException e)
		{
			Console.WriteLine("\nOOPS!\n{0}", e.ToString());
		}

		// Auto-box.
		Console.WriteLine("\n\nThe Auto Box");
		int x = 99;
		Foo(x);
		return 0;
    }
}
}
