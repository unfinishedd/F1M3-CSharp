using System;

class spiderman
{
	static int[] array = { 10, 20, 30, 40, 50, 60 };

	// mannier van hoe je het doet 
	static int multiply()
	{
		int plus = 0;
		for (int i = 0; i < array.Length; i++)
			plus = plus + array[i];
		return plus;
	}

	public static void Main()
	{
		Console.Write(multiply());
	}
}

