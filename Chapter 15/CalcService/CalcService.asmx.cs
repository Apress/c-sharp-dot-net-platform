namespace CalcWebService
{
    using System;
    using System.Collections;
    using System.ComponentModel;
    using System.Data;
    using System.Diagnostics;
    using System.Web;
    using System.Web.Services;

    /// <summary>
    ///    Summary description for Service1.
    /// </summary>
	[WebService( Description = "The painfully simple web service" )]
    public class Service1 : System.Web.Services.WebService
    {
	
        public Service1()
        {
            //CODEGEN: This call is required by the ASP.NET Web Services Designer
            InitializeComponent();
			Application["SimplePI"] = 3.14F;
        }

		#region Component Designer generated code
		
		//Required by the Web Services Designer 
		private IContainer components = null;
				
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if(disposing && components != null)
			{
				components.Dispose();
			}
			base.Dispose(disposing);		
		}
		#endregion 

		[WebMethod(Description = "Add 2 integers.")]
		public int Add(int x, int y){ return x + y; }

		[WebMethod(Description = "Add 2 floats.", MessageName = "AddFloats")]
		public float Add(float x, float y){ return x + y; }

		[WebMethod(Description = "Subtract 2 ints.")]
		public int Subtract(int x, int y){ return x - y; }

		[WebMethod(Description = "Multiply 2 ints.")]
		public int Multiply(int x, int y){ return x * y; }

		[WebMethod(Description = "Divide 2 ints.")]
		public int Divide(int x, int y)
		{
			if(y == 0)
			{
				throw new DivideByZeroException("Dude, can't divide by zero!");
			}
			return x / y; 
		}

		[WebMethod(Description = "Get value of PI.")]
		public float GetSimplePI()
		{ return (float)Application["SimplePI"]; }
    }
}
