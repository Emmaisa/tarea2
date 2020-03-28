using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_2
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			double suma = 0, total;
			double[] num = new double[10];

			for (int i = 0; i < num.Length; i++)
			{
				Console.WriteLine("Ingrese la nota en pocision" + i);
				num[i] = double.Parse(Console.ReadLine());
			}
			suma = num();

			Console.WriteLine("El total es de: ", suma);
		}
	}
}
