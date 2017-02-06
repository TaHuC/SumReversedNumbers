using System;
using System.Linq;
using System.Collections.Generic;

namespace SumReversedNumbers
{
	public class MainClass
	{
		public static void Main()
		{
			var numbers = Console.ReadLine()
			                     .Split(' ');

			int sum = 0;

			for (var i = 0; i < numbers.Length; i++)
			{
				string currNum = numbers[i];

				string reverseNum = string.Join("", currNum.Reverse());

				int toIntNum = int.Parse(reverseNum);

				sum += toIntNum;

			}

			Console.Write($"{sum}");

		}
	}
}
