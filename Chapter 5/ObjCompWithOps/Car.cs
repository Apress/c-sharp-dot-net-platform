namespace ObjComp
{
using System;
using System.Collections;

// The iteration of the Car can be ordered
// based on the CarID.
public class Car : IComparable
{
	// As a nested class!		
	private class SortByPetNameHelper : IComparer
	{
		public SortByPetNameHelper(){}

		// IComparer impl.
		int IComparer.Compare(object o1, object o2)
		{
			Car t1 = (Car)o1;
			Car t2 = (Car)o2;
			return String.Compare(t1.PetName, t2.PetName);
		}
	}

	// State data.
	private int CarID;
	private string petName;

	// properties.
	public int ID
	{
		get{return CarID;}
		set{CarID = value;}
	}
	public string PetName
	{
		get{return petName;}
		set{petName = value;}
	}

    // Constructor set.
	public Car(){}
	public Car(int id, string name)
	{ this.CarID = id; this.petName = name;}

	// IComparable implementation.
	int IComparable.CompareTo(object o)
	{
		Car temp = (Car)o;
		if(this.CarID > temp.CarID)
			return 1;
		if(this.CarID < temp.CarID)
			return -1;
		else
			return 0;
	}

	// Property to return the SortByPetName comparer.
	public static IComparer SortByPetName
	{ get { return (IComparer)new SortByPetNameHelper(); } }


	// Typically, if your class implements IComparable,
	// it should also overload the following operators.
	public static bool operator < (Car c1, Car c2)
	{
		IComparable itfComp = (IComparable)c1;
		return (itfComp.CompareTo(c2) < 0);
	}

	public static bool operator > (Car c1, Car c2)
	{
		IComparable itfComp = (IComparable)c1;
		return (itfComp.CompareTo(c2) > 0);
	}

	public static bool operator <= (Car c1, Car c2)
	{
		IComparable itfComp = (IComparable)c1;
		return (itfComp.CompareTo(c2) <= 0);
	}

	public static bool operator >= (Car c1, Car c2)
	{
		IComparable itfComp = (IComparable)c1;
		return (itfComp.CompareTo(c2) >= 0);
	}
}
}
