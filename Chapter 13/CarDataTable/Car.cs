namespace CarDataTable
{
    using System;

    public class Car
    {
		// Make public for eazy access...
		public string petName, make, color;

        public Car(string petName, string make, string color)
        {
			this.petName = petName;
			this.color = color;
			this.make = make;
        }
    }
}
