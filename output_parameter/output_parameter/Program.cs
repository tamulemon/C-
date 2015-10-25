using System;

namespace output_parameter
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Input your age: ");
			int age = getuserAge ();
			Console.WriteLine ("You entered age: {0}.", age);
		}

		public static int getuserAge()
		{
			int age;
			string userInput = Console.ReadLine ();

			// tryparse won't throw error if can not parse. will return true/false
			// tryparse takes 2 parameters. 2nd is the output parameter if it can parse
			if (int.TryParse (userInput, out age)) {
				age = int.Parse (userInput);	
			} else {
				Console.WriteLine ("invalid input");
			}
			return age; // if else is excuted, age will default to 0
		}
	}
}
