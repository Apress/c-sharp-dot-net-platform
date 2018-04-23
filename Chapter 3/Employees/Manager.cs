namespace Employees
{
using System;

public class Manager : Employee
{
	private ulong numberOfOptions;
	public ulong NumbOpts 
	{
		get {return numberOfOptions;}
		set 
		{
			if (numberOfOptions!= value) 
				numberOfOptions = value;
		}
	}
    
	public Manager(){}

	public Manager(string FullName, int empID, 
		float currPay, string ssn, ulong numbOfOpts) 
			: base(FullName, empID, currPay, ssn)
    {
		Console.WriteLine("Manager ctor!");
		// This point of data belongs with us!
		numberOfOptions = numbOfOpts;		
    }

	public override void GiveBonus(float amount)
	{
		// Increase salary.
		base.GiveBonus(amount);

		// And give some new stock options...
		Random r = new Random();
		numberOfOptions += (ulong)r.Next(500);
	}

	public override void DisplayStats()
	{
		base.DisplayStats();
		Console.WriteLine("Number of stock options: " + numberOfOptions);
	}

}
}
