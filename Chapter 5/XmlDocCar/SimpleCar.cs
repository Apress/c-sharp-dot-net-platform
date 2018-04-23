namespace XmlDocCar
{
    using System;

    /// <summary>
    ///    This is a simple Car which illustrates
    ///    working with XML style documentation.
    /// </summary>
    public class SimpleCar
    {
		/// <summary>
		/// Do you have a sunroof?
		/// </summary>
		private bool hasSunroof = false;
		
		/// <summary>
		/// The ctor lets you set the sunroofedness.
		/// </summary>
		/// <param name="hasSunroof"> </param>
        public SimpleCar(bool hasSunroof)
        {
			this.hasSunroof = hasSunroof;
        }

		/// <summary>
		/// This method allows you to open your sunroof.
		/// </summary>
		/// <param name="state"> </param>
		public void OpenSunroof(bool state)
		{
			if(state == true && hasSunroof == true)
			{
				Console.WriteLine("Put sunscreen on that bald head!");
			}
			else
			{
				Console.WriteLine("Sorry...");
			}
		}
        
		/// <summary>
		/// Entry point to application.
		/// </summary>
		public static void Main()
        {
			SimpleCar c = new SimpleCar(true);
			c.OpenSunroof(true);
        }
    }
}
