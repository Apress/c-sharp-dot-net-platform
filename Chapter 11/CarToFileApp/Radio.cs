namespace CarToFileApp
{
    using System;
	using System.Windows.Forms;

	[Serializable]
    public class Radio
    {
		[NonSerialized]
		private int objectIDNumber = 9;

        public Radio(){}
		public void On(bool state)
		{
			if(state == true)
				MessageBox.Show("Music is on...");
			else
				MessageBox.Show("No tunes...");				
		}
    }
}
