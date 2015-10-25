using System;

namespace generic_type
{
	class MainClass
	{
		
		public static void Main (string[] args)
		{
			// one generic function handles 2 different types of arrays

			char [] charArr = {'a', '1', '/', '*'};
			int [] intArr = {1, 3, 5, 7, 9};
			logger (charArr);
			logger (intArr);
		}

	
		// use <T> after the method name, indicating generic type. use T as placeholder in the body of the method where a realy type
		// key word will be used. 
		// can also place hold for 2 generic types
		// private U logger<U, T> (U arg)
		// { return T.....}
		private static void logger<T>  (T [] myArr)
		{
			foreach(T item in myArr )
			{
				Console.WriteLine (typeof(T)); // can not log T directly, it's a type parameter. Have to check typeof(T)
				Console.WriteLine(item);
			}
		}
	}


}
