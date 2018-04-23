namespace BinaryReaderWriterApp
{
    using System;
	using System.Drawing;
	using System.IO;

    public class ByteTweaker
    {
        public static int Main(string[] args)
        {
			Console.WriteLine("Creating a file and writing binary data...");
			// Open a bitmap file.
			FileStream myFStream 
				= new FileStream("temp.dat", 
								 FileMode.OpenOrCreate,
								 FileAccess.ReadWrite);
			
			// Write some binary info.
			BinaryWriter binWrit = new BinaryWriter(myFStream);
			binWrit.Write("Hello as binary info...");
			
			int myInt = 99;
			float myFloat = 9984.82343F;
			bool myBool = false;
			char[] myCharArray = {'H', 'e', 'l', 'l', 'o'};
			binWrit.Write(myInt);
			binWrit.Write(myFloat);
			binWrit.Write(myBool);
			binWrit.Write(myCharArray);
				
			// Reset internal position.
			binWrit.BaseStream.Position = 0;

			// Read the binary info as raw bytes.
			Console.WriteLine("Reading binary data...");
			BinaryReader binRead = new BinaryReader(myFStream);
			int temp = 0;
			while(binRead.PeekChar() != -1)
			{
				Console.Write(binRead.ReadByte());	
				temp = temp + 1;
				if(temp ==  5)
				{
					temp = 0;
					Console.WriteLine();
				}
			}

			// Clean things up.
			Console.WriteLine();
			binWrit.Close();
			binRead.Close();
			myFStream.Close();

			// Now open a bitmap.
			Console.WriteLine("Modifying a bitmap in memory");
			myFStream = new FileStream("Paint Splatter.bmp", 
										FileMode.Open,
										FileAccess.ReadWrite);
			Bitmap rawBitmap = new Bitmap(myFStream);
			
			// Draw a big 'X' over the image.
			for(int i = 0; i < rawBitmap.Width; i++)
			{
				rawBitmap.SetPixel(i, i, Color.White);
				rawBitmap.SetPixel((rawBitmap.Width - i) - 1, 
								   i - 1, Color.White);
			}

			Console.WriteLine("Saving modified bitmap to file");
			rawBitmap.Save("newImage.bmp");
			myFStream.Close();

            return 0;
        }
    }
}
