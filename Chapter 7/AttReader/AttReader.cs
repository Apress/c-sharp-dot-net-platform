namespace AttReader
{
using System;
using CustomAtt;

public class AttReader
{

    public static int Main(string[] args)
    {
		// Get the Type of winnebago.
		Type t = typeof(Winnebago);
		
		// Get all attributes in the assembly.
		object[] customAtts = t.GetCustomAttributes(false);
		
		// List all info.
		foreach(VehicleDescriptionAttribute v in customAtts)
			Console.WriteLine(v.Desc);	

		return 0;
    }
}
}
