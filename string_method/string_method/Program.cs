using System;
using System.Text;

namespace string_method
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string s1 = "A,B+CD";
			string s2 = "-abcd";
			string s3 = s1 + s2;
			string s5 = s3;
			s1 = s1 + '1';
			Console.WriteLine ("Concat string s1 + s2 = {0}", s3);
			Console.WriteLine ("s1 concat {0}", s1);

			///////////////////////////////////////////////////////////

			StringBuilder s4 = new StringBuilder("abcdefghijklmn");
			s4.Append ('P', 3); //append P 3 times to the end
			s4.Insert(3, 'X'); // insert at index 3, shift everything afer it
			Console.WriteLine ("s4 is a mutable stringbuildr {0}", s4);

			/////
			/// Error. String builder can not be split
//			s4.Split();
			// split on each char , into a char array
			char[] s3Split = s3.ToCharArray();
			Console.WriteLine ("string after split, {0}", s3Split); // will log system.cahr[]
			// this will log out all chars in the array
			foreach(char chars in s3Split) 
			{
				Console.WriteLine(chars);
			}

			//////////////////////////////////////////////////
			/// split on multiple char. into a string array.
			char [] deliminator = {',', '+', '-'};
			string [] s5Split = s5.Split(deliminator); // becuase this is not split to char, will be a string array
			Console.WriteLine ("split on multiple chars"); // will log system.cahr[]
			foreach(string chars in s5Split) 
			{
				Console.WriteLine(chars);
			}

			//////////////////////////////////////////////////
			/// new string method
			String s6 = new String ('X', 30); // repeat 'X' 30 times. specify the length of string
			Console.WriteLine (s6);

		}
	}
}
