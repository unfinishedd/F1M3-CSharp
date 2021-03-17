using System;

namespace CS_lessen
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] names = new string[]
			{
				"Kyrie",
				"Mike hock",
				"Sam",
				"LeBron",
				"Laptop",
				"Time",
				"Liftoff",
				"Joe",
				"Mama",
				"Migos"
			};
			string nameToFind = "Joe";
			FindStringIndex(nameToFind, names);
			Console.ReadKey();
		}
		public static void FindStringIndex(string nameToFind, string[] names)
		{
			for (int i = 0; i < names.Length; i++)
			{
				if (names[i] == nameToFind)
				{
					Console.WriteLine($"Joe zit op index: {i}");
				}
			}
		}
	}
}