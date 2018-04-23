// Redefined as nested class in the Car class!
// This is helpful given that it is really
// only intended to be a helper class which
// does not need to be seen by the outside world.

/*
namespace ObjComp
{
using System;
using System.Collections;

public class SortByPetName : IComparer
{
    public SortByPetName(){}

	// IComparer impl.
	int IComparer.Compare(object o1, object o2)
	{
		Car t1 = (Car)o1;
		Car t2 = (Car)o2;
		return String.Compare(t1.PetName, t2.PetName);
	}
}
}
*/
