namespace Indexer
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
		carArray = new Car[10];
    }

	// The indexer.
	public Car this[int pos]
	{
		get
		{	if(pos < 0 || pos > 10)
				throw new IndexOutOfRangeException("Hey! Index out of range");
			else
				return (carArray[pos]);
		}
		set
		{
			carArray[pos] = value;
		}
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
