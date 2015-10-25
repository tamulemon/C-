using System;

namespace @interface
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Let's start an interface. Please enter your message: ");
			var message = Console.ReadLine ();

			//factory is static. so no instantiation
			IloggerFactory.setLogger ();

			Ilogger newLogger = IloggerFactory.getLogger ();

			newLogger.writeLog (message);

		}
	}
}
