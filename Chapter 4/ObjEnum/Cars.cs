namespace ObjEnum
{
using System;
using System.Collections;

public class Cars : IEnumerator, IEnumerable
{
	// This class maintains an array of cars.
	private Car[] carArray;
	
	// Current position in array.
	int pos = -1;

    public Cars()
    {
		carArray = new Car[4];
		carArray[0] = new Car("FeeFee", 200, 0);
		carArray[1] = new Car("Clunker", 90, 0);
		carArray[2] = new Car("Zippy", 30, 0);
		carArray[3] = new Car("Fred", 30, 0);
    }

	// Implementation of IEnumerator.
	public bool MoveNext()
	{
		if(pos < carArray.Length)
		{
			pos++;
			return true;
		}
		else
			return false;
	}
	public void Reset()
	{
		pos = 0;
	}
	public object Current
	{
		get { return carArray[pos]; }
	}
	

	// This must be present in order to let the foreach 
	// expression to iterate over our array.
	// IEnumerable implemtation.
	public IEnumerator GetEnumerator()
	{
		return (IEnumerator)this;
	}
}
}
