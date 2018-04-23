namespace DotNetComPlusServer
{
    using System;
	using System.EnterpriseServices;
	using System.Windows.Forms;
	using System.Runtime.InteropServices;

	/* The IObjectConstruct interface has now been defined as
	 * an inaccessable type.  To implement your Construct() method,
	 * simply override the inherited Construct() method.
	 * Also note, that the sig of this method takes a string, 
	 * rather than an object.  Therefore, you do not have to 
	 * ask for IObjectConstructionString (which is also hidden).
	 */

	[ObjectPooling(true, 5, 100)] 
	[ConstructionEnabledAttribute(true)]
	[ClassInterface(ClassInterfaceType.AutoDual)]
    public class ComPlusType : ServicedComponent //,
							   // IObjectConstruct
    {
        public ComPlusType(){}

		protected override void Construct(/*object*/ string o)
		{
			// Get IOCS intreface.
			MessageBox.Show(o, "Ctor string is");			
		}
		
		[AutoComplete]
		protected void DeleteCar(int id)
		{
			MessageBox.Show("deleting car number " + id.ToString(), 
							"Delete car");
		}

		// Impl of inherited abstract members.
		protected override void Activate()
		{
			base.Activate();
			MessageBox.Show("In activate!");
		}
		
		protected override void Deactivate()
		{
			MessageBox.Show("In deactivate!");
			base.Deactivate();
		}

		protected override bool CanBePooled()
		{
			return true;	
		}
    }
}