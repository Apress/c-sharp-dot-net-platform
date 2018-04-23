namespace IFaceHierarchy
{
	using System;

	public class JBCar : IJamesBondCar
	{
		public JBCar(){}
		
		// Inherited members.
		void IBasicCar.Drive(){Console.WriteLine("Speeding up...");}
		void IUnderwaterCar.Dive(){Console.WriteLine("Submerging...");}
		void IJamesBondCar.TurboBoost(){Console.WriteLine("Blast off!");}
	}
}
