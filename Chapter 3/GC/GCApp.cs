namespace GC
{
using System;

public class GCApp
{
    public static int Main(string[] args)
    {		
		Console.WriteLine("Current heap memory: " 
			+ GC.GetTotalMemory(false).ToString());

		// Add these cars to the managed heap.
		Car c1, c2, c3, c4;

		c1 = new Car("Car one", 40, 10);
		c2 = new Car("Car two", 70, 5);
		c3 = new Car("Car three", 200, 100);
		c4 = new Car("Car four", 140, 80);
		
		// Display current generations.
		Console.WriteLine("C1 is gen {0}", GC.GetGeneration(c1));
		Console.WriteLine("C2 is gen {0}", GC.GetGeneration(c2));
		Console.WriteLine("C3 is gen {0}", GC.GetGeneration(c3));
		Console.WriteLine("C4 is gen {0}", GC.GetGeneration(c4));

		// manually dispose some.
		c1.Dispose();
		c3.Dispose();

		// Clean up gen 0?
		GC.Collect(0);	

		// Display generations (gen 0 advances to gen 1)
		Console.WriteLine("C1 is gen {0}", GC.GetGeneration(c1));
		Console.WriteLine("C2 is gen {0}", GC.GetGeneration(c2));
		Console.WriteLine("C3 is gen {0}", GC.GetGeneration(c3));
		Console.WriteLine("C4 is gen {0}", GC.GetGeneration(c4));
		
		// Clean up gen 1?
		GC.Collect(1);	

		// Display generations (gen 1 becomes gen 2)
		Console.WriteLine("C1 is gen {0}", GC.GetGeneration(c1));
		Console.WriteLine("C2 is gen {0}", GC.GetGeneration(c2));
		Console.WriteLine("C3 is gen {0}", GC.GetGeneration(c3));
		Console.WriteLine("C4 is gen {0}", GC.GetGeneration(c4));

		// Clean up gen 2?
		GC.Collect(2);	

		// Display generations (stays at gen 2 -- there is no gen 3 :-)
		Console.WriteLine("C1 is gen {0}", GC.GetGeneration(c1));
		Console.WriteLine("C2 is gen {0}", GC.GetGeneration(c2));
		Console.WriteLine("C3 is gen {0}", GC.GetGeneration(c3));
		Console.WriteLine("C4 is gen {0}", GC.GetGeneration(c4));

		// Call destructors for all objects on Q.
		GC.Collect();

		Console.WriteLine("Heap memory in use: " 
			+ GC.GetTotalMemory(false).ToString());

		return 0;
    }
}
}

