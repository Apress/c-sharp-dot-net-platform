namespace CarToFileApp
{
    using System;

	// The Car class is serializable!
	[Serializable]
    public class Car
    {
		// State data.
		protected string petName;
		protected int maxSpeed;
		protected Radio theRadio = new Radio();

		// Ctors.
        public Car(string petName, int maxSpeed)
        {
			this.petName = petName;
			this.maxSpeed = maxSpeed;
        }
		public Car() {}

		// Some properties.
		public String PetName
		{
			get { return petName; }
			set { petName = value; }
		}
		public int MaxSpeed
		{
			get { return maxSpeed; }
			set { maxSpeed = value; }
		}

		// A simple method.
		public void TurnOnRadio(bool state)
		{
			theRadio.On(state);
		}
    }
}
