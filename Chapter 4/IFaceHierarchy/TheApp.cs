namespace IFaceHierarchy
{
using System;

public class TheApp
{
    public static int Main(string[] args)
    {
		SuperImage si = new SuperImage();
		
		// Get IDraw.
		IDraw itfDraw = (IDraw)si;
		itfDraw.Draw();
		
		// Now get IDraw3.
		if(itfDraw is IDraw3)
		{
			IDraw3 itfDraw3 = (IDraw3)itfDraw;
			itfDraw3.DrawToMetaFile();
			itfDraw3.DrawToPrinter();
		}

		JBCar j = new JBCar();
		if(j is IJamesBondCar)
		{			
			((IJamesBondCar)j).Drive();
			((IJamesBondCar)j).TurboBoost();
			((IJamesBondCar)j).Dive();
		}

		return 0;
    }
}
}
