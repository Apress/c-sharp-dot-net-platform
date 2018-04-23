namespace CustomSerialization
{
    using System;
	using System.IO;
	using System.Runtime.Serialization.Formatters.Binary;
    public class Class1
    {

        public static int Main(string[] args)
        {
			// Make a car and listen to the tunes.
			Console.WriteLine("Making car...");
			CustomCarType myAuto = new CustomCarType("Siddhartha", 50);
			
			// Create a file stream.
			Console.WriteLine("Making *.dat file...");
			Stream myStream = File.Create("CarData.dat");
			
			// Move our graph into the stream using a binary format.
			Console.WriteLine("Saving to file.");
			BinaryFormatter myBinaryFormat = new BinaryFormatter();
			myBinaryFormat.Serialize(myStream, myAuto);
			myStream.Close();

			Console.WriteLine("Reading from file.");
			myStream = File.OpenRead("CarData.dat");

			CustomCarType carFromDisk = 
			(CustomCarType)myBinaryFormat.Deserialize(myStream);

			Console.WriteLine(carFromDisk.petName + " is alive!");
			myStream.Close();

            return 0;
        }
    }
}
