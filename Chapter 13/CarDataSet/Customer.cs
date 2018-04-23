namespace CarDataSet
{
    using System;

    public class Customer
    {
        public Customer(string fName, string lName, int currentOrder)
        {
			this.firstName= fName;
			this.lastName = lName;
			this.currCarOrder = currentOrder;
        }

		// K.I.S.S.
		public string firstName, lastName;
		public int currCarOrder;
    }
}
