namespace Employees
{
using System;

public class SalesPerson : Employee
{
	protected int numberOfSales;

    public SalesPerson() {}

	public SalesPerson(string FullName, int empID, 
		float currPay, string ssn, int numbOfSales) 
			: base(FullName, empID, currPay, ssn)
    {
		this.numberOfSales = numbOfSales;
    }

	public int NumbSales 
	{
		get {return numberOfSales;}
		set 
		{
			if (numberOfSales != value) 
				numberOfSales = value;
		}
	}
	
	public override void GiveBonus(float amount)
	{
		int salesBonus = 0;

		if(numberOfSales >= 0 && numberOfSales <= 100) 
			salesBonus = 10;
		else if(numberOfSales >= 101 && numberOfSales <= 200)
			salesBonus = 15;
		else
			salesBonus = 20;	// Anything greater than 200.

		base.GiveBonus(amount * salesBonus);
	}
	
	public override void DisplayStats()
	{
		base.DisplayStats();
		Console.WriteLine("Number of sales: " + numberOfSales);
	}
}
}
