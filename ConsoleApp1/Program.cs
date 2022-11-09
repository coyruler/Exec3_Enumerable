using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			IEnumerable<int> value = Enumerable.Range(1, 10);
			foreach (int i in value)
			{
				Console.WriteLine(i);
			}

			Console.WriteLine("\r");

			IEnumerable<int> value2 = Enumerable.Range(10, 6);
			foreach (int i in value2)
			{
				Console.WriteLine(i);
			}
		}
	}
}
