using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
	class Program
	{
		static void Main(string[] args)
		{
			/*
			List<Dollars> myList = new List<Dollars>()
			{
				new Dollars { Amount = 1000 },
				new Dollars { Amount = 2000 },
				new Dollars { Amount = 3000 },
				new Dollars { Amount = 10000 }
			};

			foreach (Dollars dollars in myList)
			{
				Console.WriteLine(dollars.Amount);
			}
			*/
			/*
			int oneThousand = 1000;
			int twoThousand = 2000;
			int threeThousand = 3000;
			int tenThousand = 10000;

			Console.WriteLine("In one year my salary is going to be " + oneThousand + " USD");
			Console.WriteLine("In one year my salary is going to be " + twoThousand + " USD");
			Console.WriteLine("In one year my salary is going to be " + threeThousand + " USD");
			Console.WriteLine("In one year my salary is going to be " + tenThousand + " USD");

			Console.ReadLine();
			*/

			for (int i = 5; i > -1; i--)
			{
				Console.WriteLine($"I can see {i} in this square");
			}
			Console.ReadLine();


		}
	}
	/*
	class Dollars
	{
		public int Amount { get; set; }
	}
	*/

}
