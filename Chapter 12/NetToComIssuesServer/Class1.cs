namespace NetToComIssuesServer
{
	using System;
	using System.Runtime.InteropServices;

	[ClassInterface(ClassInterfaceType.AutoDual)]
	public class BaseClass
	{
		// State data.
		private int memberVar;
		public string fieldOne;

		// Constructors.
		public BaseClass(){}
		public BaseClass(int m, string f)
		{ memberVar = m; fieldOne = f;}

		// virtual method.
		public virtual void VirMethod()
		{
			Console.WriteLine("Base VirMethod impl");
		}
	}

	[ClassInterface(ClassInterfaceType.AutoDual)]
	public class DerivedClass : BaseClass
	{
		// state data.
		public float fieldTwo;

		// Constructor.
		DerivedClass(int m, string f)
			:base(m, f) {}

		// Overridden method.
		public override void VirMethod()
		{
			Console.WriteLine("Derived VirMethod impl");
			base.VirMethod();
		}

		// overloaded memebers
		public void SomeMethod(){}
		public void SomeMethod(int x){}
		public void SomeMethod(int x, object o){}
		public void SomeMethod(int x, float f){}
	}
}
