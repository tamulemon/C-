using System;

namespace primative_reference
{
	// Case 2: to mimic a global variabl. use a static class with static variables.
	// however static member can not be passed as parametrs. change it directly in the function
	public static class Globals 
	{
		public static int x { get; set;}
	}

	// Case 3: a non-static class. can be passed as parameter.
	public class Globals2 // namespace element can not be declased as private/protected. have to be public. the 'public' can be omit. like in Main

	{
		public int x { get; set;}
	}

	class MainClass
	{
		private static int y = 5; // have to define 'static', otherwise y couldn't be accessed by the static method 'Main'

		public static void Main (string[] args)
		{
			// Case 1:
			int x = 6; // can not declare public/private/static on this, why?
			int z = 900;
			changeValue (x); // x is a internal variable to the Main method.
			changeValueRef (ref z); // ref will force z be treated as reference type. The "ref" key word need exist in function and when called

			changeValue (y); // y is another static member on the Main class.

			Console.WriteLine ("primiate value make a copy, x: {0}", x); // x is still 6. because they are primative
			Console.WriteLine ("primiate value make a copy, y: {0}", y); // y is still 5
			Console.WriteLine ("primiate value make a copy, z: {0}", z); // z will be changed to 10

			// Case 2: 
			changeGlobalValue ();
			Console.WriteLine ("use public static class to mimic global variables, x: {0}", Globals.x);
		
			// Case 3:
			Globals2 g2 = new Globals2 ();
			changeGlobalValue2 (g2);
			Console.WriteLine ("Pass non-static class as variable, but need instantiate, g2.x: {0}", g2.x);
		}

		// Case 1: 
		// declare as static so can be accessed by "Main"
		private static int changeValue(int x) 
		{
			x = 10;
			return x;
		}

		private static int changeValueRef(ref int x) 
		{
			x = 10;
			return x;
		}

		// Case 2: because static, can not be passes in as parameters. don't need to instantiate
		private static int changeGlobalValue()
		{
			Globals.x = 10; 
			return Globals.x;
		}

		private static int changeGlobalValue2(Globals2 g) 
		// Case 3:
		// a non-static class can be passed in as parameter. but need to be instantiat when called
		{
			g.x = 56; 
			return g.x;
		}
	}
}
