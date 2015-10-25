using System;

namespace property_get_set_practice
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Rectangle myRectangle = new Rectangle ();
			Student newStudent = new Student ();

			Console.Write ("Set sduent grade: ");
			newStudent.Grade = float.Parse(Console.ReadLine ());
			Console.WriteLine ("You've set the grade to: " + newStudent.Grade);

			Console.WriteLine ("Rectangle");
			Console.Write ("Please input width: ");
			// set

			myRectangle.Width = float.Parse(Console.ReadLine ());
			Console.Write ("Please input height: ");
			// set
			myRectangle.Height = float.Parse(Console.ReadLine ());

			Console.WriteLine ("This rectangle's area is: " + myRectangle.Area);
		}
	}

	 class Rectangle
	{
		public float Width { get; set;}
		public float Height { get; set;}

		// this doesn't work
		// because the this keyword refers to the current instance of the class and here the class hasn't been instantiated
//		{
//			return this.Width * this.Height;
//		}

		public float Area
		{
			get 
			{
				return Width * Height;
			}
		}
	}




}
