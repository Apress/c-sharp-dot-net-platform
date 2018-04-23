namespace Employees
{
using System;

public sealed class PTSalesPerson : SalesPerson
{
	public PTSalesPerson(string FullName, int empID, 
		float currPay, string ssn, int numbOfSales) 
			: base(FullName, empID, currPay, ssn, numbOfSales)
    {
    }
}

// Uncomment to test...
/*
public class ReallyPTSalesPerson : PTSalesPerson
{
    public ReallyPTSalesPerson()
    {
    }
}
*/
}
