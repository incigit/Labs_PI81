using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10._4
{
	class Program
	{
		static void Main()
		{
			var storeSet = new SortedSet<string>(new List<string>() {"Хліб", "Молоко", "Ковбаса"});
			var productsSet = new SortedSet<string>(new List<string>()
				{"Яблука", "Сир", "Ковбаса", "Молоко", "Вода", "Хліб", "Печиво", "Чай", "Картопля", "Цибуля"});

			var requiredSet = new SortedSet<string>(productsSet);
			requiredSet.ExceptWith(storeSet);
			Console.WriteLine("Store is missing these products:");
			foreach (var t in requiredSet)
			{
				Console.WriteLine(t);
			}

			Console.ReadKey();
		}
	}
}