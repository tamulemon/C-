using System;

namespace array_practice
{
	class array_practice
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("array test");
			singleDimentionArray ();
			autoInitialize ();
			Console.WriteLine ("---------------------------------------------");
			arr2D ();
			Console.WriteLine ("---------------------------------------------");
			Console.WriteLine("useing params {0}", sumAll (1, 3, 5, 7));

		}

		static void singleDimentionArray()
		{
			int[] numbers = new int[3]; // initiate int array with length 3
			numbers[0] = 1;
			numbers [1] = 2;
			// numbers[2] has not been assigned, so defaults to 0

			// pass array as argument
			printArry (numbers);

			// arr reverse method
			Array.Reverse(numbers);
			printArry (numbers);
		}

		static void autoInitialize()
		{	// initialize inline, don't need to specify length
			string[] stringArr = new [] { "one", "two" };
			// can not print here because printArry only takes int array)
			//printArry (stringArr);
			for (int i = 0; i < stringArr.Length; i++) {
				Console.WriteLine ("{0}, {1}", i, stringArr [i]);
			}

			//foreach loop
			foreach (var item in stringArr) {
				Console.WriteLine("foreach loop: {0}", item);
			}

			// don't even need the new key word
			bool[] booleanArr = { false, true, true };
			for (int i = 0; i < booleanArr.Length; i++) {
				Console.WriteLine ("{0}, {1}", i, booleanArr [i]);
			}

			// initialize with new keyword, len, and value. make sure every element need to be assigned a vlue. otherwise error
			int[] newIntArr = new int[3] { 2, 34, 124 };
			for (int i = 0; i < newIntArr.Length; i++) {
				Console.WriteLine ("{0}, {1}", i, newIntArr [i]);
			}
   
		}

		// 2d array
		static void arr2D ()
		{
			int[,] arr2D = new int[2, 3];
			arr2D [0, 0] = 23;
			arr2D [0, 1] = 12;
			arr2D [0, 2] = 2;
			arr2D [1, 0] = 9;
			arr2D [1, 1] = 17;
			arr2D [1, 2] = 45;
			for (int i = 0; i < arr2D.GetLength(0); i++) { // for 2D array. getlength of 1st dimention and 2nd dimention. Rank = total dimentions
				for (int j = 0; j < arr2D.GetLength(1); j++) {
					Console.WriteLine ("[{0}, {1}], {2}", i, j, arr2D [i, j]);
				}
			}
		}

		// pass array as a parameter
		static void printArry (int[] arr) // when passed in as parameters, don't need to specify array length
		{
			for (int i = 0; i < arr.Length; i++) {
				Console.WriteLine ("{0}, {1}", i, arr[i]);
			}
		}

		// using params

		static int sumAll(params int[] list)
		{
			int baseNum = 0;
			foreach (var item in list) {
				baseNum += item;
			}
			return baseNum;
		}
	}
}
