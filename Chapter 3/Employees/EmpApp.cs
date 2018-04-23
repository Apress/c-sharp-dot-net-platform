namespace Employees
{
using System;

public class EmpApp
{
    public EmpApp()
    {}

    public static int Main(string[] args)
    {
		Console.WriteLine("These folks work at " + Employee.Company);
		Console.WriteLine();

		// Uncomment to test abstract base class.
		// Employee e = new Employee();
		
		Manager chucky = new Manager("Chucky", 92, 100000, "333-23-2322", 9000);
		chucky.GiveBonus(300);
		chucky.DisplayStats();
	
		Console.WriteLine();
		
		SalesPerson fran = new SalesPerson("Fran", 93, 30000, "932-32-3232", 31);
		fran.GiveBonus(201);
		fran.DisplayStats();
		
		// Casting!
		
		// A Manager 'is-a' object.
		object o = new Manager("Frank Zappa", 9, 40000, "111-11-1111", 5);
		
		// A Manager 'is-a' Employee too.
		Employee e = new Manager("MoonUnit Zappa", 2, 20000, "101-11-1321", 1);

		// A PTSales dude(tte) is a Sales dude(tte)
		SalesPerson sp = new PTSalesPerson("Jill", 834, 100000, "111-12-1119", 90);

		FireThisPerson(e);
		FireThisPerson(sp);
		
		// Error!  Must cast when moving from base to derived!
		// FireThisPerson(o);		
		FireThisPerson((Employee)o);
		
		// Numerical casts...
int x = 30000;
byte b = (byte)x;		// Loss of information here…

		

        return 0;
    }

	// fire everyone >:-)
	public static void FireThisPerson(Employee e)
	{
		Console.WriteLine(e.GetFullName() + " has been fired!");
	}

}
}
