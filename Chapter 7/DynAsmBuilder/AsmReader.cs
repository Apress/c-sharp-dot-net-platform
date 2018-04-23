namespace DynAsmBuilder
{
    using System;
	using System.Reflection.Emit;
	using System.Reflection;
	using System.Threading;

    public class AsmReader
    {
		public static int Main(string[] args)
		{
			// Get the current application domain.
			AppDomain curAppDomain = Thread.GetDomain();
		
			// Create the dynamic assembly!
			MyAsmBuilder asmBuilder = new MyAsmBuilder();
			asmBuilder.CreateMyAsm(curAppDomain);

			// Now load it and trigger logic.
   			Assembly a = null;
			try
			{
				a = Assembly.Load("MyAssembly");
			}
			catch
			{
				Console.WriteLine("Can't find assembly...");
			}
	
			// Get the HelloWorld type.
			Type hello = a.GetType("MyAssembly.HelloWorld");
		
			// Create HelloWorld object and call the correct ctor.
			object[] ctorArgs = new object[1];
			ctorArgs[0] = "My amazing message...";
			object obj = Activator.CreateInstance(hello, ctorArgs); 

			MethodInfo mi = hello.GetMethod("SayHello");	
			mi.Invoke(obj, null);

			mi = hello.GetMethod("GetMsg");
			Console.WriteLine(mi.Invoke(obj, null));

			return 0;
		}
    }
}
