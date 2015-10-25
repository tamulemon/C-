using System;
using System.IO;

namespace @interface
{
	class FileLogger : Ilogger // FileLogger is an implementation of Ilogger
	{
		//To implement an interface member, the corresponding member of the implementing class must be public, non-static,
		// and have the same name and signature as the interface member.
		public void writeLog (string input) // this is the method refered in interface Ilogger. has to be public because interface is public
		{
			var fileWriter = File.AppendText ("MengLog.txt"); //takes file name, will default to current wrk dir if not specify path
			fileWriter.WriteLine (input); // the content 
			fileWriter.Close (); // need to close the file
		}
	}
}

