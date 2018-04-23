using System;

class ObjTest
{
    public static int Main(string[] args)
    {

		// Make an instance of ObjTest
		// and call some inherited Object methods.
		ObjTest c1 = new ObjTest();

		Console.WriteLine("ToString: {0}", c1.ToString());
		Console.WriteLine("Hash code: {0}", c1.GetHashCode());
		Console.WriteLine("Type: {0}", c1.GetType().ToString());
		
		// Make some other references to c1.
		ObjTest c2 = c1;
		object o = c2;
		
		// Are all three of these instances
		// pointing to the same object in memory?
		if(o.Equals(c1) && c2.Equals(o))
			Console.WriteLine("Same instance!\n");


		// Now make some people and test for equality.
		// NOTE:  We want these to be identical to test
		// the Equals() method.
		Person p1 = new Person("Fred", "Jones", "222-22-2222", 98);
		Person p2 = new Person("Fred", "Jones", "222-22-2222", 98);

		// Overridden Equals()
		if(p1.Equals(p2) && p1.GetHashCode() == p2.GetHashCode())
			Console.WriteLine("P1 and P2 have same state\n");
		else
			Console.WriteLine("P1 and P2 are DIFFERENT\n");

		// Change state of p2.
		p2.age = 2;

		// Test again.
		if(p1.Equals(p2)&& p1.GetHashCode() == p2.GetHashCode())
			Console.WriteLine("P1 and P2 have same state\n");
		else
			Console.WriteLine("P1 and P2 are DIFFERENT\n");		

		// Get stringified version of objects.
		Console.WriteLine(p1.ToString());
		Console.WriteLine(p2);

		// Static members of System.Object.
		Person p3 = new Person("Sally", "Jones","333", 4);
		Person p4 = new Person("Sally", "Jones","333", 4);
		Console.WriteLine("\n\nP3 and P4 have same state: {0}", object.Equals(p3, p4));
		Console.WriteLine("P3 and P4 are pointing to same object: {0}", object.ReferenceEquals(p3, p4));

		return 0;
    }
}
