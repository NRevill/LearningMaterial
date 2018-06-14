using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciFun
{
	class FibonacciCalculator
	{
		static void Main(string[] args)
		{
			int beforePrevious = 1;
			int previous = 1;
			int next = 0;

			int count = int.Parse(Console.ReadLine());

			Console.Write("1 1 ");

			for (int i = 0; i < count - 2; i++)
			{
				next = GetNextFibonacci(beforePrevious, previous);
				Console.Write(next + " ");
				beforePrevious = previous;
				previous = next;
			}
			
			Console.ReadLine();
		}
		static int GetNextFibonacci(int x, int y)
		{
			int next = x + y;

			return next;
		}
	
	}
}
