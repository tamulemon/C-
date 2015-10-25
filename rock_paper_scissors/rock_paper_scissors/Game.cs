using System;

namespace rock_paper_scissors
{
	public class Game
	{
		public string PlayerName { get; set;}
		public int computerChoice { get; set;}
		public string userChoice { get; set; }
		private int win = 0 , Lost = 0, tie = 0;
		private Random rng;

		public Game () {
			// initiate rng in constructor
			rng = new Random ();
		}
			
//		private int _computer = 2;

//		Random rng = new Random ();
//		private int _computer =  rng.Next (0, 3); 

// 		can not do this, error. becaue rgn needs to be instantiated from Random class and Game
//		also needs to be instantiated. Compiler doesn't garantee the order of  excution. 2 options here:
//		1. instantiate Random class in the constructor to garantee it gets to run first
//		2. use a static value to assign the field. like hard code 2 
	

		private void setComputerChoice()
		{// just to set a value so, no return. will be void
			computerChoice = rng.Next (1, 4);	
		}

		// this need to be accessed from the console, so public
		public void promptUser() 
		{
			Console.WriteLine ("{0}, please Enter your choice: ", PlayerName);
		}
		// also need to be called. This is the main function that controls game flow
		public void gameFlow(string userChoice)
		{
			if (userChoice == "Q") {
				Console.WriteLine("End");
					Console.WriteLine ("{3}, your total wins: {0}\ntotal lost: {1} \ntotal ties: {2}", win, Lost, tie, PlayerName);
			} else if (userChoice == "R" || userChoice == "P" || userChoice == "S") {
				setComputerChoice ();
				determinWin (computerChoice, userChoice);
			} else {
				Console.WriteLine ("Invalid input.");
				}
		}

		// all the logic don't need to be exposed, so private
		private void determinWin (int computerChoice, string userChoice)
		{
			int userChoiceNum  = TranslateString (userChoice);
			string computerChoiceString = TranslateNumber (computerChoice);

			if(computerChoice == userChoiceNum) {
				tie += 1;
				Console.WriteLine("It's a tie, you and the computer both choose {0}.", userChoice);
			} else if ((userChoiceNum - computerChoice) % 3 == 1) {
				win += 1;
				Console.WriteLine("Computer's choice is {0} and your choice is {1}. You won!", computerChoiceString, userChoice);
			} else {
				Lost += 1;
				Console.WriteLine("Computer's choice is {0} and your choice is {1}. You lost!", computerChoiceString, userChoice);
			}
		}

		private string TranslateNumber(int x)
		{ 
			string y;
			if (x == 1) {
				y = "R";
			} else if (x == 2) {
				y = "P";
			} else {
				y = "S";
			}
			return y;
		}

		private int TranslateString(string x)
		{
			int y;
			if (x == "R") {
				y = 1;
			} else if (x == "P") {
				y = 2;
			} else {
				y = 3;
			}
			return y;
		}

	}
}

