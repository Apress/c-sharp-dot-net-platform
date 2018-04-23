namespace MultiThreadSharedData
{
    using System;
	using System.Threading;

// Feel free to use this type...
	public class IHaveNoIdea
	{
		private long refCount = 0;
		
		public void AddRef()
		{
			Interlocked.Increment(ref refCount);
		}
        
		public void Release()
		{
			if(Interlocked.Decrement(ref refCount) == 0)
			{
				GC.Collect();
			}
		}
	}


	internal class WorkerClass
	{
		public void DoSomeWork()
		{
			/*
			lock(this)
			{
				// Do the work.
				for(int i = 0; i < 5; i++)
				{
					Console.WriteLine("Worker says: " + i + ", ");
				}
			}
			*/

			// The C# lock statmement is really...
			Monitor.Enter(this);
			try
			{
				// Do the work.
				for(int i = 0; i < 5; i++)
				{
					Console.WriteLine("Worker says: " + i + ", ");
				}
			}
			finally
			{
				Monitor.Exit(this);
			}
		}
	}

    public class MainClass
    {

        public static int Main(string[] args)
        {
			// Make the worker object.
			WorkerClass w = new WorkerClass();

			// Create three secondard threads,
			// each of which makes calls to the same 
			// shared object.
			Thread workerThreadA = new Thread(new ThreadStart(w.DoSomeWork));
			Thread workerThreadB = new Thread(new ThreadStart(w.DoSomeWork));
			Thread workerThreadC = new Thread(new ThreadStart(w.DoSomeWork));
			
			// Now start each one.
			workerThreadA.Start();
			workerThreadB.Start();
			workerThreadC.Start();
			
            return 0;
        }
    }
}
