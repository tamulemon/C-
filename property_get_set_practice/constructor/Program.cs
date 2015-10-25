using System;

namespace constructorDemo
{
	class Program
	{
		public static void Main ()
		{
			Car myCar = new Car ();
			Console.WriteLine ("From Program, " + myCar);
		}
	}

	class Car
	{
		public Car()
		{
			Console.WriteLine ("Explicity empty constructor");
		}

	}
}
