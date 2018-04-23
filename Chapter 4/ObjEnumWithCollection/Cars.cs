namespace ObjEnumWithCollection
{
using System;
using System.Collections;

public class Cars : IEnumerable
{
	// This class maintains an array of cars.
	private ArrayList carList;
	
    public Cars()
	{carList = new ArrayList();}
	
	// Expose select methods of the ObjectList
	// to the outside world.
	public void AddCar(Car c)
	{ carList.Add(c);}
	
	public void RemoveCar(int carToRemove) 
	{ carList.RemoveAt(carToRemove);}
	
	public int CarCount
	{ get{ return carList.Count;} }

	public void ClearAllCars()
	{ carList.Clear(); }

	public bool CarIsPresent(Car c)
	{ return carList.Contains(c); }

	// IEnumerable implemtation.
	public IEnumerator GetEnumerator()
	{ return carList.GetEnumerator();}
}
}
