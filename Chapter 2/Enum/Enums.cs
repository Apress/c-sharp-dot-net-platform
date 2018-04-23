namespace Enum
{
using System;

// Here is a custom enum.

enum EmpType : byte 
{
	Manager = 10,
	Grunt = 1,
	Contractor = 100,
	VP = 9
}

class EnumClass
{
	// Enums as parameters.
	public static void AskForBonus(EmpType e)
	{
		switch(e)
		{
		case EmpType.Contractor:
			Console.WriteLine("You already get enough cash...");
		break;
		case EmpType.Grunt:
			Console.WriteLine("You have got to be kidding...");
		break;
		case EmpType.Manager:
			Console.WriteLine("How about stock options instead?");
		break;
		case EmpType.VP:
			Console.WriteLine("VERY GOOD, Sir!");
		break;
		default: break;
		}
	}
    public static int Main(string[] args)
    {
		EmpType fred;
		fred = EmpType.VP;
		EnumClass ec = new EnumClass();
		AskForBonus(fred);
		
		//Get underlying type.
		Console.WriteLine(Enum.GetUnderlyingType(typeof(EmpType)));

		// Get Fred's type.
		Console.WriteLine("You are a {0}", Enum.Format(typeof(EmpType), fred, "G"));

		// Get all stats for EmpType.
		Array obj = Enum.GetValues(typeof(EmpType));
		Console.WriteLine("This enum has {0} members.", obj.Length);

		// Now show the string name and associated value.
		foreach(EmpType e in obj)
		{
			Console.Write("String name: {0}", Enum.Format(typeof(EmpType), e, "G"));
			Console.Write(" ({0})", Enum.Format(typeof(EmpType), e, "D"));
			Console.Write(" hex: {0}\n", Enum.Format(typeof(EmpType), e, "X"));
		}

		// Does EmpType have a SalePerson value?
		if(Enum.IsDefined(typeof(EmpType), "SalesPerson"))
			Console.WriteLine("Yep, we have sales people.");
		else
			Console.WriteLine("No, we have no profits....");

		EmpType Joe = EmpType.VP;
		EmpType Fran = EmpType.Grunt;

		if(Joe < Fran)
			Console.WriteLine("Joe's value is less than Fran's");
		else
			Console.WriteLine("Fran's value is less than Joe's");

        return 0;
    }
}
}
