using System;
using System.Windows.Forms;


// Look in "assemblyinfo.cs" for the following
//
// using System.Runtime.CompilerServices;

// Specify the strong name key for this assembly.
// See assemblyinfo.cs 
//[assembly: 
//AssemblyKeyFileAttribute
//(@"D:\CSharpBook\Labs\Chapter 6\SharedAssembly\theKey.snk")]


namespace SharedAssembly
{
// Which band do you want?
public enum BandName
{
	TonesOnTail,
	SkinnyPuppy,
	deftones,
	PTP
}
public class VWMiniVan
{
    public VWMiniVan()
	{
		MessageBox.Show("Using version 2.0.0.0!", "Shared Car");
	}
	
	public void Play60sTunes()
	{
		MessageBox.Show("What a loooong, strange trip it's been...");
	}
	
	private bool isBustedByTheFuzz = false;

	public bool Busted
	{
		get { return isBustedByTheFuzz; }
		set { isBustedByTheFuzz = value; }
	}

	public void CrankGoodTunes(BandName band)
	{
		switch(band)
		{
			case BandName.deftones:
				MessageBox.Show("So forget about me...");
				break;
			case BandName.PTP:
				MessageBox.Show("Tick tick tock...");
				break;
			case  BandName.SkinnyPuppy:
				MessageBox.Show("Water vapor, to air...");
				break;
			case  BandName.TonesOnTail:
				MessageBox.Show("Oooooh the rain. Oh the rain.");
				break;
			default:
				break;
		}			
	}
}
}

