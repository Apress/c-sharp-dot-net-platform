namespace TheType
{
using System;
using System.Reflection;

public class FooReader
{

	public static void ListVariousStats(Foo f)
	{
		Console.WriteLine("***** Various stats about Foo *****");
		Type t = f.GetType();
		Console.WriteLine("Full name is: {0}", t.FullName);
		Console.WriteLine("Base is: {0}", t.BaseType);
		Console.WriteLine("Is it abstract? {0}", t.IsAbstract);
		Console.WriteLine("Is it a COM object? {0}", t.IsCOMObject);
		Console.WriteLine("Is it sealed? {0}", t.IsSealed);
		Console.WriteLine("Is it a class? {0}", t.IsClass);
		Console.WriteLine("***********************************\n");
	}

	public static void ListMethods(Foo f)
	{
		Console.WriteLine("***** Methods of Foo *****");
		Type t = f.GetType();
		MethodInfo[] mi = t.GetMethods();
		foreach(MethodInfo m in mi)
			Console.WriteLine("Method: {0}", m.Name);
		Console.WriteLine("*************************\n");
	}

	public static void ListFields(Foo f)
	{
		Console.WriteLine("***** Fields of Foo *****");
		Type t = f.GetType();
		FieldInfo[] fi = t.GetFields();
		foreach(FieldInfo field in fi)
			Console.WriteLine("Field: {0}", field.Name);
		Console.WriteLine("*************************\n");
	}

	public static void ListProps(Foo f)
	{
		Console.WriteLine("***** Properties of Foo *****");
		Type t = f.GetType();
		PropertyInfo[] pi = t.GetProperties();
		foreach(PropertyInfo prop in pi)
			Console.WriteLine("Prop: {0}",  prop.Name);
		Console.WriteLine("*****************************\n");
	}

	public static void ListInterfaces(Foo f)
	{
		Console.WriteLine("***** Interfaces of Foo *****");
		Type t = f.GetType();
		Type[] ifaces = t.GetInterfaces();
		foreach(Type i in ifaces)
			Console.WriteLine("Interface: {0}", i.Name);
		Console.WriteLine("*****************************\n");	
	}

    public static int Main(string[] args)
    {
		// Make a Foo type.
		Foo theFoo = new Foo();

		// Now examine everything.
		ListVariousStats(theFoo);
		ListMethods(theFoo);
		ListFields(theFoo);
		ListProps(theFoo);
		ListInterfaces(theFoo);

        return 0;
    }
}
}
