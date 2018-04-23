namespace CSharpATLServerClient
{
    using System;
	using CLASSICATLCOMSERVERLib;
	using System.Reflection;

    public class CoCarClient
    {   
		public static void ExplodedHandler(String msg)
		{
			Console.WriteLine("\nCar says: (COM Events)\n->"
							  + msg + "\n");
		}

        public static int Main(string[] args)
        {
			// Begin by making a car.
			CoCarClass viper = new CoCarClass();
			
			// Rig into event.
			viper.Exploded += new _ICarEvents_ExplodedEventHandler(ExplodedHandler);
			
			// Set (and get) the driver name.
			viper.DriverName = "Fred";
			Console.WriteLine("Driver is named: (COM property)\n->" + 
							  viper.DriverName + "\n");

			// List type of car.
			CarType t = viper.GetCarType();			
			Console.WriteLine("Car type is: (COM enum)\n->" 
							  + t.ToString() + "\n");
						
			// Get engine & cylinders.
			IEngine e = viper.GetEngine();
			object o = e.GetCylinders();

			// Get array of strings.
			String[] cylinders = (string[])o;
			Console.WriteLine("o is really this type: " + o);

			// Print each item.
			Console.WriteLine("Your cylinders are: (COM SAFEARRAY and contained coclass) ");
			foreach(string s in cylinders)
			{
				Console.WriteLine("->" + s);	
			}
			Console.WriteLine();

			// Now speed up the car a bunch and get event.
			for(int i = 0; i < 5; i++)
			{
				try
				{					
					viper.SpeedUp(50);
					Console.WriteLine("->Curr speed is: " 
									  + viper.GetCurSpeed());
				}
				catch(Exception ex)
				{
					Console.WriteLine("->COM error! " + ex.Message + "\n");
				}
			}

            return 0;
        }
    }
}
