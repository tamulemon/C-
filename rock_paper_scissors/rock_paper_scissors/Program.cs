using System;

namespace rock_paper_scissors
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Game rpsGame = new Game ();
			Console.WriteLine ("Welcome to the Rock-Paper-Scissors Game.Please Enter your name: ");
			rpsGame.PlayerName = Console.ReadLine ();
			do {
				rpsGame.promptUser ();
				rpsGame.userChoice = Console.ReadLine ();
				rpsGame.gameFlow (rpsGame.userChoice);
			} while (rpsGame.userChoice != "Q");
		}
	}
}
