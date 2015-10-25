using System;

namespace simple_addition
{
	/// <summary>
	/// Main class.
	/// </summary>
	class MainClass
	{
		public static void Main (string[] args) // there must be a "Main" method
		{
			Console.Write ("Enter a number ");
			int number1 = int.Parse(Console.ReadLine());
			Console.Write ("Enter another number ");
			int number2 = int.Parse(Console.ReadLine());
			int sum = number1 + number2;
			Console.WriteLine ("The sum is " + sum);
			Console.WriteLine ("The sum is " + sum.ToString()); //same effect
			Console.WriteLine ("The sum is " + (number1 + number2));// use () for runtime evaluation. expression chaining
		}
	}
}
