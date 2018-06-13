using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
	class Program
	{
		static void Main(string[] args)
		{
			/*
			Console.WriteLine("Add a number");
			var firstNumber = int.Parse(Console.ReadLine());
			Console.WriteLine("Add a second number");
			var secondNumber = int.Parse(Console.ReadLine());

			Console.WriteLine("Add or multiply?");
			var answer = Console.ReadLine();

			if (answer == "add" || (answer == "Add"))
			{
				Console.WriteLine(firstNumber + secondNumber);
			}
			else
			{
				Console.WriteLine(firstNumber * secondNumber);
			}
			*/

			/*
			var firstNumber = int.Parse(Console.ReadLine());
			var secondNumber = int.Parse(Console.ReadLine());

			Console.WriteLine(firstNumber + secondNumber);
			Console.WriteLine(firstNumber - secondNumber);
			Console.WriteLine(firstNumber * secondNumber);
			

			if (secondNumber == 0 || (firstNumber == 0))
			{
				Console.WriteLine("Can't divide by zero!");
			}
			else
			{
				Console.WriteLine(firstNumber / secondNumber);
			}
			*/

			/*
			int count = int.Parse(Console.ReadLine());
			int sum = 0;

			for (int i = 0; i < count; i++)
			{
				Console.WriteLine($"Input size of file {i + 1}:");
				sum = sum + int.Parse(Console.ReadLine());
			}
			Console.WriteLine($"Total disk space is {sum} bytes.");

	        */

			/*
			int count = int.Parse(Console.ReadLine());
			int min = int.MaxValue;

			for (int i = 0; i < count; i++)
			{
				int newNumber = int.Parse(Console.ReadLine());

				if (min > newNumber)
					min = newNumber;
			}

			Console.WriteLine($"{min}");
			*/

			/*
			Console.WriteLine("Write a number: ");
			int min = int.Parse(Console.ReadLine());
			Console.WriteLine("Write a second number: ");
			int max = int.Parse(Console.ReadLine());

			int sum = 0;

			if (min > max)
			{
				Console.WriteLine("min should be smaller than max!");
			}
			else
			{
				for (int i = min; i < max; i++)
				{
					sum += i * i;
				}

				Console.WriteLine(sum);
			}
			*/

			/*
			int charCode = Console.Read();
			char theRealChar = Convert.ToChar(charCode);

			if (char.IsDigit(theRealChar))
			{
				Console.WriteLine("Digit");
			}
			if (char.IsLetter(theRealChar))
			{
				Console.WriteLine("Letter");
			}
			else
			{
				Console.WriteLine("Not a digit and not a letter");
			}
			*/
			/*
			// This is the same as
			int count = int.Parse(Console.ReadLine());

			int rows = 0;
			while (rows++ < count)
			{
				int symbolsInRow = rows;

				while (symbolsInRow-- > 0)
					Console.Write('#');

				Console.WriteLine();
			}

			// This
			int count = int.Parse(Console.ReadLine());

			for (int i = 0; i < count; ++i)
			{
				for (int j = 0; j <= i; ++j)
					Console.Write('#');

				Console.WriteLine();
			}
			*/

			

			Console.ReadLine();
			

		}
	}
}
