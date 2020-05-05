using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task1
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine(
				"Enter the Login. It must be from 2 to 10 characters, only letters or digits and can not start with a digit.");
			string attemptedLogin = Console.ReadLine();

			try
			{
				if (attemptedLogin.Length > 10) throw new Exception("Login is too long.");
				if (attemptedLogin.Length < 2) throw new Exception("Login is too short");
				if (!attemptedLogin.All(char.IsLetterOrDigit))
					throw new Exception("Login must contain only letters or digits");
				if (char.IsDigit(attemptedLogin.First())) throw new Exception("Login can't start with a digit.");

				Console.WriteLine($"Login \"{attemptedLogin}\" is valid.");
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
			finally
			{
				Console.ReadKey();
			}
		}
	}
}