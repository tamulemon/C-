using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
	class Program
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Starting game...");
			HangmanGame game = new HangmanGame();

	        game.Play();
			Console.ReadLine().ToUpper();
		}
	}
}
