namespace AttribDotNetObjects
{
    using System;
	using System.Runtime.InteropServices;
	using System.Windows.Forms;

	// This .NET interface has been
	// adorned with various attributes
	// which will be used by the tlbimp.exe utility.
	[GuidAttribute("47430E06-718D-42c6-9E45-78A99673C43C"),
	 InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IBasicMath
	{
		[DispId(777)] int Add(int x, int y);
	}

	[GuidAttribute("C08F4261-C0C0-46ac-87F3-EDE306984ACC")]
    public class DotNetCalc : IBasicMath
    {
        public DotNetCalc()
        {}
				
		public int Add(int x, int y) { return x + y;}			

		// This attribute configures this method
		// to be called during the registration of the 
		// assembly.
		[ComRegisterFunctionAttribute]
		public static void AddExtraRegLogic(string regLoc)
		{
			// Could assign this type to a given CATID...
			// ...or add company specific info...
			// ...or just put up a message box!
			MessageBox.Show("Inside AddExtraRegLogic f(x)",".NET assembly says:");
			MessageBox.Show(regLoc,"String param is:");
		}
		[ComUnregisterFunctionAttribute]
		public static void RemoveExtraRegLogic(string regLoc)
		{
			// Could assign this type to a given CATID...
			// ...or add company specific info...
			// ...or just put up a message box!
			MessageBox.Show("Inside RemoveExtraRegLogic f(x)",".NET assembly says:");
			MessageBox.Show(regLoc,"String param is:");
		}
    }
}
