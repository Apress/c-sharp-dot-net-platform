using System;

// Simple class to demo params keyword.
class Person
{
	private string fullName;
	private byte age;

	public Person(string n, byte a)
	{
		fullName = n;
		age = a;
	}

	public void PrintInfo()
	{
		Console.WriteLine("{0} is {1} years old", fullName, age);
	}
}

class Methods
{
	// Looks a lot like [in] and [in, out], does it not?
	public void Add(int x,int y, out int ans)
	{
		ans = x + y;
	}

	// Same as...
	public int Add(int x, int y)
	{
		return x + y;
	}

	// reference parameter.
	public void UpperCaseThisString(ref string s)
	{
		s = s.ToUpper();
	}

	// params keyword.
	public void ArrayOfInts(string msg, params int[] list) 
	{
		Console.WriteLine(msg);

		for ( int i = 0 ; i < list.Length ; i++ )
			Console.WriteLine(list[i]);
			Console.WriteLine();
	}

	public void ArrayOfObjects(params object[] list) 
	{
		
		for ( int i = 0 ; i < list.Length ; i++ )
		{	 
			if(list[i] is Person)
			{
				((Person)list[i]).PrintInfo();
			}
			else
				Console.WriteLine(list[i]);
		}
			Console.WriteLine();
	}

	public static void Main() 
	{
		// Make a Method object.
		Methods m = new Methods();

		// Use 'out' keyword (no need to assign because it is an out).
		int ans;
		m.Add(90, 90, out ans);
		Console.WriteLine("90 + 90 = {0}", ans);

		// Use 'ref'
		string s = "Can you really have sonic hearing for $19.00?";
		Console.WriteLine("Before: " + s);
		m.UpperCaseThisString(ref s);
		Console.WriteLine("After: {0}", s);

		// Make some objects.
		Person p = new Person("Fred", 93);
		m.ArrayOfObjects(777, p, "I really am an instance of System.String"); 

		// Use 'params' keyword.
		int[] intArray = new int[3] {10,11,12};
		m.ArrayOfInts("Here is an array of ints", intArray);
		m.ArrayOfInts("Enjoy these 3 ints", 1, 2, 3);
		m.ArrayOfInts("Take some more!", 55, 4, 983, 10432, 98, 33);
   }
}
