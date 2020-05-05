using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10._6
{
	class Program
	{
		static void Main()
		{
			Console.OutputEncoding = Encoding.Unicode;
			var firstSemester = new List<string>()
				{"Матаналіз", "Програмування", "Філософія", "Історія", "Компютерні мережі", "Теорія алгоритмів"};
			var secondSemester = new List<string>()
			{
				"Теорія ймовірності", "Програмування", "Економіка", "Психологія", "Компютерні мережі",
				"Теорія алгоритмів"
			};

			var union = firstSemester.Union(secondSemester);
			var intersection = firstSemester.Intersect(secondSemester);
			var subctraction = firstSemester.Except(secondSemester);

			Console.WriteLine("Перший семестр:");
			PrintSet(firstSemester);
			Console.WriteLine("Другий семестр:");
			PrintSet(secondSemester);
			Console.WriteLine("Об'єднання");
			PrintSet(union);
			Console.WriteLine("Перетин:");
			PrintSet(intersection);
			Console.WriteLine("Різниця");
			PrintSet(subctraction);
			Console.ReadKey();

		}

		static void PrintSet(IEnumerable<string> set)
		{
			foreach (var s in set)
			{
				Console.WriteLine(s);
			}

			Console.WriteLine();
		}
	}
}