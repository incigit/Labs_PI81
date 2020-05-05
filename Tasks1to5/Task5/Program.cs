using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task5
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter the Ukrainian phone number:");
			string number = Console.ReadLine();
			number = number.Replace("(", String.Empty).Replace(")", String.Empty).Replace("-", String.Empty)
				.Replace(" ", String.Empty);

			string[] patterns = new[]
			{
				"^[+][0-9]{12}$",
				"^[0][0-9]{9}$"
			};

			// VALID EXAMPLES:
			// +380 050 88 88 888
			// +38 (050) 88 88 888
			// 050 88 88 888
			// 050-88-88-888
			// and so on..

			bool valid = false;
			foreach (var s in patterns)
			{
				if (Regex.IsMatch(number, s))
				{
					valid = true;
					break;
				}
			}

			if (valid)
			{
				Console.WriteLine("Number is valid.");
			}
			else
			{
				Console.WriteLine("Number is invalid.");
			}

			Console.ReadKey();
		}
	}
}