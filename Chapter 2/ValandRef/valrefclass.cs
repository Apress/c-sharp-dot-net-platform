namespace ValandRef
{
using System;

struct FOO	// Change struct to class to see the different behaviors.
{
	public int x, y;
}

// A value type.
struct PERSON
{
	public string Name;
	public int Age;
	public override string ToString()
	{
		return "Name: " + Name + ", Age: " + Age;
	}
	public PERSON(string n, int a)
	{
		Name = n; Age = a;
	}
};

// A reference type.
class Person
{
	public string Name;
	public int Age;
	public override string ToString()
	{
		return "Name: " + Name + ", Age: " + Age;
	}
	public Person(string n, int a)
	{
		Name = n; Age = a;
	}
};

class ValRefClass
{
    public static int Main(string[] args)
    {
		FOO f1 = new FOO();
		f1.x = 100;
		f1.y = 100;

		FOO f2 = f1;
		
		// Here is F1.
		Console.WriteLine("F1.x = {0}", f1.x);
		Console.WriteLine("F1.y = {0}", f1.y);
			
		// Here is F2.
		Console.WriteLine("F2.x = {0}", f2.x);
		Console.WriteLine("F2.y = {0}", f2.y);

		// Change f2.x.  This will NOT change f1.x.
		Console.WriteLine("Changing f2.x");	
		f2.x = 900;

		// Print again.
		Console.WriteLine("F2.x = {0}", f2.x);
		Console.WriteLine("F1.x = {0}", f1.x);

		// Now some people.
		// Create an object reference on the managed heap.
		Person fred = new Person("Fred", 9);
		Console.WriteLine(fred);

		// Create a value on the stack.
		PERSON mary = new PERSON("Mary", 48);
		Console.WriteLine(mary);

		// This performs a bit copy, resulting in two structures on the stack.
		PERSON jane = mary;
		jane.Age = 2000;
		Console.WriteLine(jane);
		Console.WriteLine(mary);

		// This performs a shallow copy, resulting in two references to the 
		// same object on the heap.
		Person fredRef = fred;
		fred.Age = 2000;
		Console.WriteLine(fred);
		Console.WriteLine(fredRef);	
		return 0;
    }
}
}
