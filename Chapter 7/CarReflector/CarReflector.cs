namespace CarReflector
{
using System;
using System.Reflection;
using System.IO;

public class CarReflector
{
	// Here are the methods to check out all types.
	private static void ListAllTypes(Assembly a)
	{
		Console.WriteLine("Listing all types in {0}", a.FullName);
		Type[] types = a.GetTypes();
		foreach(Type t in types)
			Console.WriteLine("Type: {0}", t);
		Console.WriteLine();
	}

	private static void ListAllMembers(Assembly a)
	{
		Type miniVan = a.GetType("CarLibrary.MiniVan");
	
		Console.WriteLine("Listing all members for {0}", miniVan);

		MemberInfo[] mi = miniVan.GetMembers();
		foreach(MemberInfo m in mi)
			Console.WriteLine("Type {0}: {1} ",
					m.MemberType.ToString(), m);
	}

	private static void GetParams(Assembly a)
	{
		Type miniVan = a.GetType("CarLibrary.MiniVan");
		MethodInfo mi = miniVan.GetMethod("TurnOnRadio");	
		Console.WriteLine("Here are the params for {0}", mi.Name);
 
		// Show number of params.
		ParameterInfo[] myParams = mi.GetParameters();
		Console.WriteLine("Method has {0} params", myParams.Length);
		
		// Show info about param.
		foreach(ParameterInfo pi in myParams)
		{
			Console.WriteLine("Param name: {0}", pi.Name);
			Console.WriteLine("Position in method: {0}", pi.Position);				
			Console.WriteLine("Param type: {0}", pi.ParameterType);
		}
	}

	// This application dynamically loads 
	// an assembly and investigates the types.
    public static int Main(string[] args)
    {
		// Use Assembly class to load the CarLibrary.
		Assembly a = null;
		try
		{
			// You can use a string...
			//a = Assembly.Load(@"CarLibrary, Ver=1.0.454.30104, SN=null, Loc=""");

			// ...or AssemblyName reference...
			AssemblyName asmName;
			asmName = new AssemblyName();
			asmName.Name = "CarLibrary";
			Version v = new Version("1.0.454.30104");
			asmName.Version = v;

			// ...to load an assembly!
			a = Assembly.Load(asmName);

		}
		catch(FileNotFoundException e)
		{Console.WriteLine(e.Message);}

		// Check everything out.
		ListAllTypes(a);
		Console.WriteLine();
		ListAllMembers(a);
		Console.WriteLine();
		GetParams(a);
		return 0;
    }
}
}
