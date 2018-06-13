using System;

namespace WhileLoop
{
	class AntivirusScan
	{

		static void Main(string[] args)
		{
			int number = 1;
			bool scanning = true;
			string answer;

			if (scanning)
			{
				while (scanning)
				{
					answer = Console.ReadLine();

					if (answer == "scan")
					{
						Console.WriteLine($"scanning file {number}");
						number++;
					}
					else if (answer == "hide")
					{
						scanning = false;
						while (!scanning)
						{
							answer = Console.ReadLine();
							if (answer == "scan")
								Console.WriteLine($"can't scan files for viruses");

							else if (answer == "unhide")
								scanning = true;
						}
					}
					else
					{
						scanning = false;
						Console.WriteLine("run");
					}
				}
			}
		}
	}
}