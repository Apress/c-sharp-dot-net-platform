namespace Structures
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

// And here is a struct using this enum.
struct EMPLOYEE 
{
	// Fields.
	public EmpType title;
	public string name;
	public short deptID;

	// Constructor.
	public EMPLOYEE(EmpType et, string n, short d)
	{
		title = et;
		name = n;
		deptID = d;
	}
}

class StructTester
{

	public void DisplayEmpStats(EMPLOYEE e)
	{
		Console.WriteLine("Here is {0} \'s info:", e.name);
		Console.WriteLine("Department ID: {0}", e.deptID);
		Console.WriteLine("Title: {0}", Enum.Format(typeof(EmpType), e.title, "G"));
	}

	public void UnboxThisEmployee(object o)
	{
		EMPLOYEE temp = (EMPLOYEE)o;
		Console.WriteLine(temp.name + " is alive!");
	}

    public static int Main(string[] args)
    {
        // Create and format Fred.
		EMPLOYEE fred;
		fred.deptID = 40;
		fred.name = "Fred";
		fred.title = EmpType.Grunt;

		// Create and format Mary using a ctor.
		EMPLOYEE mary = new EMPLOYEE(EmpType.VP, "Mary", 10);

		// Let emps struct their stuff.
		StructTester t = new StructTester();
		t.DisplayEmpStats(mary);
		t.DisplayEmpStats(fred);

		// Create and box an employee.
		EMPLOYEE stan = new EMPLOYEE(EmpType.Grunt, "Stan", 10);
		object stanInBox = stan;
		
		// Send into function prototyped with object.
		t.UnboxThisEmployee(stanInBox);

        return 0;
    }
}
}
