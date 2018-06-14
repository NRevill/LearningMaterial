using System;

namespace Methods
{
	class SimpleCalculator
	{
		static void Main(string[] args)
		{
			string type = Console.ReadLine();
			int firstNumber = int.Parse(Console.ReadLine());
			int secondNumber = int.Parse(Console.ReadLine());

			if (type == "add")
				Console.WriteLine(Add(firstNumber, secondNumber));
			else if (type == "subtract")
				Console.WriteLine(Add(firstNumber, secondNumber));
			else if (type == "multiply")
				Console.WriteLine(Add(firstNumber, secondNumber));
			else if (type == "divide")
				Console.WriteLine(Add(firstNumber, secondNumber));

			Console.ReadLine();
		}

		static int Add(int x, int y)
		{
			return x + y;
		}

		static int Subtract(int x, int y)
		{
			return x - y;
		}

		static int Multiply(int x, int y)
		{
			return x * y;
		}

		static int Divide(int x, int y)
		{
			return x / y;
		}
	}
}