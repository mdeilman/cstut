using System;

namespace SampleApp
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");

			for (int i = 0; i < args.Length; i++)
			{
				Console.WriteLine("Arg {0} : {1}",i,args[i]);
			}

			string[] myArgs = Environment.GetCommandLineArgs();

			Console.WriteLine(string.Join(", ", myArgs));

			SayHello();

			// Console.Write("Press any key to close window...");
			// Console.ReadLine();
		}
		private static void SayHello()
		{
			string name = "";
			Console.Write("What is your name : ");
			name = Console.ReadLine();
			Console.WriteLine("Hello {0} old chap", name);
		}
	}
}