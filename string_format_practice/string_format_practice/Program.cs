using System;

namespace string_format_practice
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");
			Console.WriteLine ("start");

			stringReplace ();
			AlignLeft ();
			AlignRight ();
			formatNumber ();
			stringFormat ();
		}

		// use string replacement. 0 based.
		static void stringReplace() 
		{
			var string1 = "Meng Chen";
			var string2 = "35";
			Console.WriteLine ("My name is {0}, and I'm {1} years old.", string1, string2);
		}

		// use nagative int to align text to the left. number indicate the max length of this column. 
		// if more char than specified, will overflow
		static void AlignLeft() 
		{
			Console.WriteLine (4000D);
			var leftAlignFormat = "{0, -15} {1, -15} {2, -3} {3, -5}";
			Console.WriteLine (leftAlignFormat, "First Name", "Last Name", "Age", "Zip");
			Console.WriteLine (leftAlignFormat, "Meng", "Chen", "35", "98033");
			Console.WriteLine (leftAlignFormat, "Livia Yuxuan", "Wang", "9", "98033");
			Console.WriteLine (leftAlignFormat, "Noah O. Y.", "Wang", "35", "98033");
			Console.WriteLine ();
		}


		// use positive number to align to the right
		// C indicate it is 'currency' format
		static void AlignRight() 
		{
			var rightAlignFormat = "{0, -15} {1, 9:C}";
			Console.WriteLine (rightAlignFormat, "Name", "Balance");
			Console.WriteLine (rightAlignFormat, "Meng Chen", "45677");
			Console.WriteLine (rightAlignFormat, "Xiaoming Wang", "2340000");
//			Console.ReadLine ();
//			Console.Clear ();
		}

		static void formatNumber() 
		{
			Console.WriteLine("The value 12345 in various formats:\n");
			Console.WriteLine("c format: {0:c}", 12345); //system default currency
			Console.WriteLine("d format: {0:d8}", 12345); //will fill up with 0 to the left to 8 digits
			Console.WriteLine("f format: {0:f3}", 12345); // fixed to 3 decimal points
			Console.WriteLine("n format: {0:n1}", 12345); // format as number. will add a ',' every 3 digits. also fixed to 1 decimal points

			Console.WriteLine("E format: {0:E}", 12345); // Exponential(scientific) notation, denoted as E
			Console.WriteLine("e format: {0:e}", 12345); // use e

			Console.WriteLine ("p format: {0:P}", 1); // percentage. Defalt to 2 decimal points 

			Console.WriteLine ("X format: {0:X}", 255); //hexadecimal
		}

		static void stringFormat()
		{
			var outputString = string.Format ("{0:c}", 25.39); // convert to a string and format it and save as a string
			Console.WriteLine (outputString);
		}
	}
}
