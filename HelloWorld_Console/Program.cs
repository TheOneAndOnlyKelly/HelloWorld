using System;
using HellWorldLib;
using static System.Configuration.ConfigurationManager;

namespace HelloWorld_Console
{
	class Program
	{
		static void Main(string[] args)
		{

			var OutputMode = AppSettings["outputMode"];
			IMessage Messenger = null;

			switch (OutputMode)
			{
				case "Console":
					Messenger = new ConsoleMsg();
					break;
				case "Web":
					Messenger = new WebMsg();
					break;
				default:
					Console.WriteLine("Unable to determine output method");
					Console.WriteLine("Aborting");
					Console.ReadKey();
					return;
			}

			Console.WriteLine(Messenger.OutputMessage());

			Console.WriteLine();
			Console.WriteLine("Press any key to exit...");
			Console.ReadKey();
		}
	}
}
