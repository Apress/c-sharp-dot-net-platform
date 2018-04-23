namespace CarToFileApp
{
    using System;
	using System.Windows.Forms;

	[Serializable]
    public class JamesBondCar : Car
    {
		protected bool isFlightWorthy;
		protected bool isSeaWorthy;

		public JamesBondCar(string petName, int maxSpeed, 
							bool canFly, bool canSubmerge)
			: base(petName, maxSpeed)
        {
			this.isFlightWorthy = canFly;
			this.isSeaWorthy = canSubmerge;
		}
		public JamesBondCar(){}

		public void Fly()
		{
			if(isFlightWorthy)
				MessageBox.Show("Taking off!");
			else
				MessageBox.Show("Falling off cliff!");
		}

		public void GoUnderWater()
		{
			if(isSeaWorthy)
				MessageBox.Show("Diving....");
			else
				MessageBox.Show("Drowning!!!");			
		}
    }
}
