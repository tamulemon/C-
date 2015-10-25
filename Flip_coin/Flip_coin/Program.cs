using System;

namespace Flip_coin
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int coin;
			string userGuess;
			Random rng = new Random ();

			coin = rng.Next (0, 2);
			Console.Write ("Please enter T or H ");
			userGuess = Console.ReadLine ();

			if ((coin == 0 && userGuess == "H") || (coin == 1 && userGuess == "T")) {
				Console.WriteLine ("It was {0}, and your guess was {1}. You won.", coin, userGuess);
			} else {
				Console.WriteLine ("It was {0}, and your guess was {}. You lost.", coin, userGuess);
			}
		}
	}
}
