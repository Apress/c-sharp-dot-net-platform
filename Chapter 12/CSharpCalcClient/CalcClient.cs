namespace CSharpCalcClient
{
    using System;
	using SimpleAssembly;
	using System.Reflection;

    public class CalcClient	
    {
        public static int Main(string[] args)
        {
			// Make the calc!
			CoCalc c = new CoCalc();
			Console.WriteLine("30 + 99 is: " 
							  + c.Add(30, 99));

			// As named interface...
			_CoCalc icalc = c;
			Console.WriteLine(icalc.Add(9, 80));

			// Play with Object methods.
			Console.WriteLine();
			Console.WriteLine("-> CoCalc to string: " + c.ToString());

			// Extract out some type info...
			Type t = c.GetType();
			Console.WriteLine("-> COM class? : " + t.IsCOMObject);
			Console.WriteLine("-> Full name? : " + t.FullName);
			Console.WriteLine("-> CLSID? : " + t.GUID.ToString());
			Console.WriteLine("-> Is it a interface? : " + t.IsInterface);
			Console.WriteLine();
			
			return 0;
        }
    }
}
