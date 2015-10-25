using System;

namespace Stop_watch //the 2 classes have the same namespace 
{
	public class Stopwatch // explicityly call the 'public class'. class defaults to 'internal'. In this case, because the 2 classes exist in the
	// same namespace, whether call it public doesn't make difference
	{
		private DateTime _startTime;

		public void StartTimer() 
		{
			_startTime = DateTime.Now;
		}

		public void StopTimer()
		{
			TimeSpan elapseTime = DateTime.Now - _startTime;
			Console.WriteLine ("Timer has run for {0} s and {1} ms.", elapseTime.Seconds, elapseTime.Milliseconds);
			Console.ReadLine ();
		}
	}
}

