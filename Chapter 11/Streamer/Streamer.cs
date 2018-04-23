namespace FileStreamApp
{
    using System;
	using System.IO;

    public class FileStreamer
    {
        public static int Main(string[] args)
        {
			/*************************************************/
			Console.WriteLine("Working the FileStream!");

			// Create a new file in the working directory.
			FileStream myFStream = new FileStream("test.dat", 
												  FileMode.OpenOrCreate,
												  FileAccess.ReadWrite);
				
			// Write 20 bytes to the dat file...
			for(int i = 0; i < 256; i++)
			{
				myFStream.WriteByte((byte)i);
			}

			// Reset internal position.
			myFStream.Position = 0;

			// Read 20 bytes from the dat file...
			for(int i = 0; i < 256; i++)
			{
				Console.Write(myFStream.ReadByte());	
			}
			Console.WriteLine();
			myFStream.Close();

			/*************************************************/
			Console.WriteLine("Working the MemoryStream!");

			// Create a mem stream.
			MemoryStream myMemStream = new MemoryStream();
			myMemStream.Capacity = 256;

			// Write 20 bytes to the dat file...
			for(int i = 0; i < 256; i++)
			{
				myMemStream.WriteByte((byte)i);
			}

			// Reset internal position.
			myMemStream.Position = 0;

			// Read 20 bytes from the dat file...
			for(int i = 0; i < 256; i++)
			{
				Console.Write(myMemStream.ReadByte());	
			}
			Console.WriteLine();

			// Dump memory to file.
			FileStream dumpFile = new FileStream("Dump.dat", FileMode.Create,
												 FileAccess.ReadWrite);
			myMemStream.WriteTo(dumpFile);
			byte[] bytesinMemory = myMemStream.ToArray();
			myMemStream.Close();

			for(int i = 0; i < bytesinMemory.Length; i++)
				Console.Write(bytesinMemory[i]);

			/*************************************************/
			Console.WriteLine("\nWorking the BufferedStream!");
			BufferedStream myFileBuffer = new BufferedStream(dumpFile);
			
			// Add some bytes to the buffer.
			byte[] str = {127, 0x77, 0x4, 0x0, 0x0, 0x16};
			myFileBuffer.Write(str, 0, str.Length);

			// add changes to file.
			myFileBuffer.Close();	// Flushes.
			myMemStream.Close();	// Flushes.

			return 0;
        }
    }
}
