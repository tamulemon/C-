using System;
using System.Configuration;

namespace @interface
{
	static class IloggerFactory
	{
		// a private interface Ilogger
		private static Ilogger _newLogger;

		// public method to implement the logger based on config 
		public static void setLogger ()
		{
			if (ConfigurationManager.AppSettings ["logType"] == "C") {
				_newLogger = new ConsoleLogger ();
			} else {
				_newLogger = new FileLogger ();
			}
			// can not do this because ternary experssion requries both branch be the same type. But here can not determine whther they ar the same
			//_newLogger = (ConfigurationManager.AppSettings["logType"] == "C")? new ConsoleLogger (): new FileLogger ();
		}

		public static Ilogger getLogger ()
		{
			return _newLogger;
		}
	}
}

