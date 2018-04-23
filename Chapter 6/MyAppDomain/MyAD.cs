namespace MyAppDomain
{
    using System;
	using System.Reflection;
	using System.Windows.Forms;

    public class MyAppDomain
    {
		public static void PrintAllAssemblies()
		{
			AppDomain ad = AppDomain.CurrentDomain;
			Assembly[] loadedAssemblies = ad.GetAssemblies();
			
			Console.WriteLine("Here are the assemblies loaded in this appdomain\n");
			foreach(Assembly a in loadedAssemblies)
			{
				Console.WriteLine(a.FullName);
			}
		}

        public static int Main(string[] args)
        {
			MessageBox.Show("This call loaded System.Windows.Forms.dll");
			PrintAllAssemblies();
            return 0;
        }
    }
}
