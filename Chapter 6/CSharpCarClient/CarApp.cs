namespace CSharpCarClient
{
using System;

// Make use of the CarLib types.
using CarLibrary;

public class CarClient
{

    public static int Main(string[] args)
    {
		// Make a sports car.
		SportsCar viper = new SportsCar("Viper", 240, 40);
		viper.TurboBoost();

		// Make a minivan.
		MiniVan mv = new MiniVan();
		mv.TurboBoost();
		mv.TurnOnRadio(true, MusicMedia.musicCD);

        return 0;
    }
}
}
