namespace LateBinding
{
using System;
using System.Reflection;
using System.IO;

public class LateBind
{
    public static int Main(string[] args)
    {
		// Use Assembly class to load the CarLibrary.
		Assembly a = null;
		try
		{
			a = Assembly.Load("CarLibrary");
		}
		catch(FileNotFoundException e)
		{Console.WriteLine(e.Message);}
		
		// Get the Minivan type.
		Type miniVan = a.GetType("CarLibrary.MiniVan");

		// Create the Minivan on the fly.
		object obj = Activator.CreateInstance(miniVan);
		
		// Get info for TurnOnRadio.
		MethodInfo mi = miniVan.GetMethod("TurboBoost");

		// Invoke method.
		mi.Invoke(obj, null);

		// Create array of params.
		object[] paramArray = new object[2];		
		paramArray[0] = "Fred";
		paramArray[1] = 4;
		mi = miniVan.GetMethod("TellChildToBeQuiet");
		mi.Invoke(obj, paramArray);

		return 0;
    }
}
}

