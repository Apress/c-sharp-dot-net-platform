namespace SimpleMultiThreadApp
{
    using System;
	using System.Threading;
	using System.Windows.Forms;

    public class MainClass
    {
        public static int Main(string[] args)
        {
			Console.Write("Do you want [1] or [2] threads? ");
			string threadCount = Console.ReadLine();

			// Name the current thread.
			Thread primaryThread = Thread.CurrentThread;
			primaryThread.Name = "Boss man";			
			Console.WriteLine("ID of {0} is: {1}", 
								primaryThread.Name,
								primaryThread.GetHashCode());
			
			// Make worker class.
			WorkerClass w = new WorkerClass();

			if(threadCount == "2")	
			{
				// Now make the thread.
				Thread backgroundThread = 
					new Thread(new ThreadStart(w.DoSomeWork));
				backgroundThread.Start();
			}
			else
			{
				w.DoSomeWork();
			}
 	
			// Do some additional work.
			MessageBox.Show("I'm buzy");
            
			return 0;
        }
    }

	internal class WorkerClass
	{
		public void DoSomeWork()
		{
			// Get some information about the worker thread.
			Console.WriteLine("ID of worker thread is: {0}",
							  Thread.CurrentThread.GetHashCode());	

			// Do the work.
			Console.Write("Worker says: ");
			for(int i = 0; i < 30; i++)
			{
				Console.Write(i + ", ");
				Thread.Sleep(500);
			}
			Console.WriteLine();
		}
	}
}
