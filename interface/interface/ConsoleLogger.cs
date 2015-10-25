using System;

namespace @interface
{
	class ConsoleLogger : Ilogger
	{
		//To implement an interface member, the corresponding member of the implementing class must be public, non-static,
		// and have the same name and signature as the interface member.
		public void writeLog (string input) // this is the method refered in interface Ilogger
		{
			Console.WriteLine (input);
		}
	}
}

