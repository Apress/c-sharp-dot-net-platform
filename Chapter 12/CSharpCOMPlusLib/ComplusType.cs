namespace COMPlusAssembly
{
    using System;
	using Microsoft.ComServices;
	using System.WinForms;
	using System.Runtime.InteropServices;
	
	// This object is poolable and supports a ctor string.
	[ObjectPooling(5, 100)] 
	[ConstructionEnabledAttribute(true)]
    internal class MyCOMPlusClass : ServicedComponent,
								    IObjectConstruct
    {
		// Impl of IObjectConstruct.
		public void Construct(object o)
		{
			// Get IOCS intreface.
			IObjectConstructString ics = (IObjectConstructString)o;
			MessageBox.Show(ics.ConstructString, 
							"Ctor string is");			
		}

		// Impl of inherited abstract members.
		public override void Activate()
		{
			base.Activate();
			MessageBox.Show("In activate!");
		}
		
		public override void Deactivate()
		{
			MessageBox.Show("In deactivate!");
			base.Deactivate();
		}

		public override bool CanBePooled()
		{
			return true;	
		}

        public MyCOMPlusClass(){}

		// The sole method of the COM+ aware .NET type.
		public void RemoveCar(int id)
		{
			try
			{				
				// Make use of ADO(.NET) to open the 
				// data source and remove the correct
				// car.
				ContextUtil.SetComplete();	
			}
			catch
			{
				ContextUtil.SetAbort();	
			}			
		}
    }
}
