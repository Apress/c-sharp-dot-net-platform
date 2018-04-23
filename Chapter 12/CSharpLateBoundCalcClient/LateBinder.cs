namespace CSharpLateBoundCalcClient
{
    using System;
	using System.Reflection;

    public class LateBinder
    {
        public static int Main(string[] args)
        {
			// Using late binding...
			
			// First get IDispatch reference from coclass.
			Type calcObj = 
				Type.GetTypeFromProgID("PainfullySimpleVBCOMServer.CoCalc");
			object calcDisp = Activator.CreateInstance(calcObj);

			// Make the array of args.
			object[] addArgs = { 100, 34 };

			// Invoke the Add() method.
			object sum = null;
			sum = calcObj.InvokeMember("Add", BindingFlags.InvokeMethod, 
									   null, calcDisp, addArgs);

			Console.WriteLine("Late bound adding:\n100 + 24 is: " + sum);
			return 0;
        }
    }
}
