<Query Kind="Program" />

namespace TestUsing
{
	public class Thing : IDisposable
	{
		private string name;
		public Thing(string name) { this.name = name; }
		override public string ToString()
		{ return String.Format("Thing : " + name); }

		~Thing()
		{
			Dispose();
			Console.WriteLine("~Thing: " + name);
		}

		public void Dispose()
		{
			Console.WriteLine("Dispose: " + name);
			//GC.SuppressFinalize(this);
		}
	}

	class TestUsingApp
	{
		[STAThread]
		static void Main(string[] args)
		{
			Thing t1 = new Thing("Ethel");
			try
			{
				Console.WriteLine(t1);
			}
			finally
			{
				if (t1 != null)
					((IDisposable)t1).Dispose();
			}

			using (Thing t2 = new Thing("JimBob"))
			{
				Console.WriteLine(t2);
			}

			Console.WriteLine("\nForcing a Collection");

			GC.Collect();
			GC.WaitForPendingFinalizers();
		}
	}
}