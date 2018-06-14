using System;

namespace FunctionCaller
{
	class FunctionalModule
	{
		static void Main(string[] args)
		{
			string command = Console.ReadLine();

			while (command != "exit")
			{
				char first = command[0];
				char.ToLower(first);

				if ((first >= 'a' && first <= 'f') || (first >= 'A' && first <= 'F'))
				{
					FromAToF(command);
				}
				else if ((first >= 'g' && first <= 'l') || (first >= 'G' && first <= 'L'))
				{
					FromGToL(command);
				}
				else if ((first >= 'm' && first <= 'r') || (first >= 'M' && first <= 'R'))
				{
					FromMToR(command);
				}
				else if ((first >= 's' && first <= 'z') || (first >= 'S' && first <= 'Z'))
				{
					FromSToZ(command);
				}
				command = Console.ReadLine();
			}
			

		}

		static void FromAToF(string command)
		{
			Console.WriteLine($"FromAToF executes {command}.");
		}

		static void FromGToL(string command)
		{
			Console.WriteLine($"FromGToL executes {command}.");
		}

		static void FromMToR(string command)
		{
			Console.WriteLine($"FromMToR executes {command}.");
		}

		static void FromSToZ(string command)
		{
			Console.WriteLine($"FromSToZ executes {command}.");
		}
	}
}