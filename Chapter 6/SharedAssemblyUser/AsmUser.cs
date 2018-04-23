namespace SharedLibUser
{
using System;
using SharedAssembly;

public class SharedAsmUser
{
    public static int Main(string[] args)
    {
		try
		{
			VWMiniVan v = new VWMiniVan();
			v.Play60sTunes();
		} 
		catch(TypeLoadException e)
		{
			// Can't find assembly in GAC!
			Console.WriteLine(e.Message);
		}
        return 0;
    }
}
}
