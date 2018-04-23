namespace DotNetClassLib
{
	using System;
	using System.Runtime.InteropServices;

	public interface IAdvancedMath
	{
		int Multiple(int x, int y);
		int Divide(int x, int y);
	}

	[ClassInterface(ClassInterfaceType.AutoDual)]
	public class CSharpCalc: IAdvancedMath
	{
		public CSharpCalc(){}

		public int Add(int x, int y)
		{
			return x + y;	
		}
		public int Subtract(int x, int y)
		{
			return x - y;
		}

		int IAdvancedMath.Multiple(int x, int y)
		{
			return x * y;
		}
		
		int IAdvancedMath.Divide(int x, int y)
		{
			if(y == 0)
				throw new DivideByZeroException();

			return x / y;
		}
	}
}
