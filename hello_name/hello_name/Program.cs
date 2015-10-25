using System;

namespace hello_name
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.Write ("What is your name? ");
			string name = Console.ReadLine ();
			Console.WriteLine ("Hello, " + name);
			Console.ReadLine ();
		}
	}
}
