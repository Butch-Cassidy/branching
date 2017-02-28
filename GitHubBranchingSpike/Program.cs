using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubBranchingSpike
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("What is your name?");
			var name = Console.ReadLine();

			Console.WriteLine("Hello " + (string.IsNullOrWhiteSpace(name) ? "World" : name));
			Console.WriteLine("Press enter to exit");
			Console.ReadLine();
		}
	}
}
