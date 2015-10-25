using System;

namespace static_nonstatic
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			float mpg;
			float km;

			Console.Write("Enter mpg: ");
			mpg = float.Parse(Console.ReadLine ());
			km = Conversion. mpgToKm (mpg);
			Console.WriteLine("To Km: {0}", km); // even Conversion is not a static class. No need to instantiate to use a static method
			//  but the static method needs to be public to be used
			Console.WriteLine("------------------------------------");

			Circle circle = new Circle ();
			circle.Radius = 2f;
			Console.WriteLine ("Radius for this circle is {0}.", circle.Radius);
			Console.WriteLine ("Area for this circle is {0}.", circle.Area);
			Console.WriteLine("------------------------------------");

			// static member can only be accessed from the class
			Console.WriteLine("Pi for this circle is {0}.", Circle.Pi);
			// this will error as the instance of 'circle' can not access Pi
//			Console.WriteLine("Pi for this circle is {0}.", circle.Pi);
		}
	}

	public class Conversion
	{
		private float _testMpg = 12.9f;

		public static float mpgToKm (float mpg)
		{

			// error: an object reference is needed. the _testMpg variable doesn't exist until Conversin is
			// instantiated
//			return _testMpg * 1.69f; 

			return mpg * 1.69034f; // have to use f here to tell it is a float, otherwise number with decimal will default to double
		}
	}

	class Circle 
	{
		public float Radius {get; set;}

		// even Pi is static, it can be accessed within the class
		// it can not be accessed from the instance
		public static float Pi
		{
			get
			{
				return 22f/7f;
			}
		}

		public float Area
		{
			get
			{
				return Radius * Radius * Pi;
			}
		}
	}
}
