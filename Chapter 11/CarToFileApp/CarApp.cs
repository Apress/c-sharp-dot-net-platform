namespace CarToFileApp
{
    using System;
	using System.IO;
	using System.Runtime.Serialization.Formatters.Binary;
	using System.Runtime.Serialization.Formatters.Soap;

    public class CarApp
    {
		public static void Main()
		{
			// Make a car and listen to the tunes.
			Console.WriteLine("Made a James Bond Car...");
			JamesBondCar myAuto = new JamesBondCar("Fred", 50, false, true);
			myAuto.TurnOnRadio(true);
			myAuto.GoUnderWater();

			// Now save this car to a binary stream.
			FileStream myStream = File.Create("CarData.dat");
			BinaryFormatter myBinaryFormat = new BinaryFormatter();
			myBinaryFormat.Serialize(myStream, myAuto);
			myStream.Close();
			Console.WriteLine("Saved car to cardata.dat.");

			// Read in the Car from the binary stream.
			Console.WriteLine("Reading car from binary file.");
			myStream = File.OpenRead("CarData.dat");
			JamesBondCar carFromDisk = (JamesBondCar)myBinaryFormat.Deserialize(myStream);
			Console.WriteLine(carFromDisk.PetName + " is alive!");
			carFromDisk.TurnOnRadio(true);
			myStream.Close();
			
			// Save the same car into SOAP format.
			Console.WriteLine("Now saving car to XML file");
			myStream = File.Create("CarData.xml");
			SoapFormatter myXMLFormat = new SoapFormatter();
			myXMLFormat.Serialize(myStream, myAuto);
			myStream.Close();

			// Read in the Car from the XML file.
			Console.WriteLine("Reading car from XML file.");
			myStream = File.OpenRead("CarData.xml");
			JamesBondCar carFromXML = (JamesBondCar)myXMLFormat.Deserialize(myStream);
			Console.WriteLine(carFromXML.PetName + " is alive!");
			carFromXML.TurnOnRadio(true);
			myStream.Close();
		}
    }
}
