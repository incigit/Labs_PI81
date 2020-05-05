using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task2
{
	class Program
	{
		static void Main()
		{
			string rawUrl = @"http://lib.istu.edu.ua/index.php?p=30&amp;id_f=114";
			string buffer = string.Empty;
			
			foreach (char e in rawUrl.SkipWhile(c => c != '.'))
			{
				buffer += e;
			}

			string result = string.Empty;
			foreach (char e in buffer.TakeWhile(c => c != '/'))
			{
				result += e;
			}

			result = result.TrimStart('.');
			


			Console.WriteLine(result);
			Console.ReadKey();
		}
	}
}
