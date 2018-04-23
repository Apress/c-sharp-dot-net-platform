namespace DynAsmBuilder
{
    using System;
	using System.Reflection.Emit;
	using System.Reflection;

    // This class builds an assembly on the fly,
	// adds a class (with a method)
	// and saves it to disk.

    public class MyAsmBuilder
    {
		public int CreateMyAsm(AppDomain curAppDomain)
		{
			// Create a name for the assembly.
			AssemblyName assemblyName = new AssemblyName();
			assemblyName.Name = "MyAssembly";
			assemblyName.Version = new Version("1.0.0.0");

			// Create the assembly in memory.
			AssemblyBuilder assembly 
				= curAppDomain.DefineDynamicAssembly(assemblyName, 
													 AssemblyBuilderAccess.Save);
			
			// Here, we are building a single file
			// assembly, so the name of the module
			// is the same as the assembly.
			ModuleBuilder module = 
				assembly.DefineDynamicModule("MyAssembly", "MyAssembly.dll");
						
			// Define a public class named "HelloWorld".
			TypeBuilder helloWorldClass = module.DefineType("MyAssembly.HelloWorld", 
															TypeAttributes.Public);

			// Define a private String member variable named "Msg":
			// private string msg;
			FieldBuilder msgField = helloWorldClass.DefineField("Msg", 
										 Type.GetType("System.String"), 
										 FieldAttributes.Private);

			// Create the constructor:
			// HelloWorld(String s).
			Type[] constructorArgs = new Type[1];
			constructorArgs[0] = Type.GetType("System.String");
			ConstructorBuilder constructor = 
				helloWorldClass.DefineConstructor(MethodAttributes.Public, 
												  CallingConventions.Standard, 
												  constructorArgs);
    
			ILGenerator constructorIL = constructor.GetILGenerator();
			constructorIL.Emit(OpCodes.Ldarg_0);
			Type objectClass = Type.GetType("System.Object");
			ConstructorInfo superConstructor = objectClass.GetConstructor(new Type[0]);
			constructorIL.Emit(OpCodes.Call, superConstructor);
			constructorIL.Emit(OpCodes.Ldarg_0);
			constructorIL.Emit(OpCodes.Ldarg_1);
			constructorIL.Emit(OpCodes.Stfld, msgField);
			constructorIL.Emit(OpCodes.Ret);

			// Now created the GetMsg method:
			// public string GetMsg().
			MethodBuilder getMsgMethod = 
				helloWorldClass.DefineMethod("GetMsg", MethodAttributes.Public, 
										  Type.GetType("System.String"), null);

			ILGenerator methodIL = getMsgMethod.GetILGenerator();
			methodIL.Emit(OpCodes.Ldarg_0);
			methodIL.Emit(OpCodes.Ldfld, msgField);
			methodIL.Emit(OpCodes.Ret);

			// Create the SayHello method:
			// public void SayHello().
			MethodBuilder sayHiMethod = 
				helloWorldClass.DefineMethod("SayHello", 
										 MethodAttributes.Public, null, null);
			methodIL = sayHiMethod.GetILGenerator();
			methodIL.EmitWriteLine("Hello there!");
			methodIL.Emit(OpCodes.Ret);

			// 'Bake' the class HelloWorld.
			// (baking a type is a cute way to say,
			// "make it so!").
			helloWorldClass.CreateType();

			// Save the assembly to disk.
			assembly.Save("MyAssembly.dll");

			return 0;
		}
    }
}
