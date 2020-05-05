using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Task4
{
	class Program
	{
		static void Main()
		{
			string html;
			using (FileStream stream = new FileStream("HTMLPage.html", FileMode.Open))
			{
				using (StreamReader sr = new StreamReader(stream))
				{
					html = sr.ReadToEnd();
				}
			}
			Console.WriteLine(html + "\n");
			Console.WriteLine("Parsed text:");

			string pattern = @"<[^>]*?>";

			string result = Regex.Replace(html, pattern, "");
			result = result.Trim('\r', '\n');
			Console.WriteLine(result);
			Console.ReadKey();
		}

	}
}