using System;
using System.Configuration;

namespace ReadingConfigurationData
{
	class Program
	{
		static void Main(string[] args)
		{
			string message = ConfigurationManager.AppSettings["Message"];

			Console.WriteLine("The message is: {0}", message);

			Console.ReadLine();
		}
	}
}
