﻿using System;
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
			Console.WriteLine("Enter Your Name");
			var name = Console.ReadLine();
			//var msg = "{0}".Format(name);
			Console.WriteLine("Hello World");
		}
	}

	public static class StringExtensions { 
		public static string Format(this string formatString, params object[] args){
			return string.Format(formatString, args);
		}
	}
}
