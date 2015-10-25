using System;

namespace Stop_watch  //the 2 classes have the same namespace 
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Stopwatch newStopwatch = new Stopwatch (); // one instance of the stopwatch, reasign variables in the for loop

			for (int i = 0; i < 3; i++) {
				Console.WriteLine ("Hit Enter to start the Timer");
				Console.ReadLine ();
				newStopwatch.StartTimer ();

				Console.WriteLine ("Hit Enter to stop the Timer");
				Console.ReadLine ();
				newStopwatch.StopTimer ();	
			}

		}
	}
		
}
