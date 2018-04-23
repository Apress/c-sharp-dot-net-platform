namespace Employees
{
using System;

// Employee is the base class in this hierarchy.
// It serves to hold data common to all employee types.
abstract public class Employee
{
	// protected state data.
	// Child classes can directly access this
	// information.  Object users cannot.
	protected  string fullName;
	protected int empID;
	protected float currPay;
	protected string ssn;		

	// Bump the pay for this emp.
	public virtual void GiveBonus(float amount)
	{
		currPay += amount;
	}

	// Accessor & mutator for the FirstName.
	public string GetFullName() { return fullName; } 
	public void SetFullName(string n) 
	{ 
		// Remove any illegal characters (!,@,#,$,%),
		// check maximum length or case before making assignment.
		fullName = n; 
	}

	// Property for the empID.
	public int EmpID 
	{
		get {return empID;}
		set 
		{
			// Just to prove the point. Uncomment to test.
			/*
			Console.WriteLine("value is an instance of :" 
							  + value.GetType());
			
			Console.WriteLine("value as string :" 
							  + value.ToString());
			*/

			// You are still free to investigate (and possibly transform)
			// the incoming value before making an assignment.  
			if (empID != value) 
				empID = value;
		}
	}
	
	// Property for the empID.
	public float Pay 
	{
		get {return currPay;}
		set 
		{
			if (currPay != value) 
				currPay = value;
		}
	}

	// Another property.
	public string SSN
	{
		get { return ssn; }
		set { ssn = value;}
	}

	// ERROR!  Uncomment to test.
	// public string get_SSN() { return ssn;}
	// public void set_SSN(string val) { ssn = val;}

	// If you override the freebe default constructor,
	// you must explicitly redefine it, or else you cannot
	// create an instance using as so:
	// Employee e = new Employee();

	// Default ctor.
	public Employee(){}

	// Custom ctor
    public Employee(string FullName, int empID, float currPay, string ssn)
    {
		Console.WriteLine("Employee ctor!");
		// Assign internal state data.
		// Note use of 'this' keyword.
		this.fullName = FullName;
		this.empID = empID;
		this.currPay = currPay;
		this.ssn = ssn;
    }

	static Employee()
	{
		CompName = "Intertech, Inc";
	}

	// If the user calls this ctor, forward to the 4-arg version
	// using arbitrary values...
	public Employee(string fullName) 
		: this(fullName, 3333, 0.0F, "") {}

	// Show state.
	public virtual void DisplayStats()
	{
		Console.WriteLine("Name: {0}", fullName);
		Console.WriteLine("Pay: {0}", currPay);
		Console.WriteLine("ID: {0}", empID);
		Console.WriteLine("SSN: {0}", ssn);
	}

	// A static property.
	private static string CompName;
	public static string Company
	{
		get { return CompName; }
		set { CompName = value;}
	}
	public readonly string SSNField = "111-11-1111";
}
}
