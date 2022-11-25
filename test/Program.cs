using System;

namespace Lab4._1
{
	class Program
	{
		
		static void Main(string[] args)
		{

			double a, b, z;

			Console.WriteLine("Введите первое число");
			a = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Введите второе число");
			b = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Выберите действие: 1. Сложение. 2. Вычитание. 3. Умножение. 4. Деление");
			z = Convert.ToInt32(Console.ReadLine());
			switch (z)
			{
				case 1:
					Console.WriteLine(a + b);
					break;
				case 2:
					Console.WriteLine(a - b);
					break;
				case 3:
					Console.WriteLine(a * b);
					break;
				case 4:
					Console.WriteLine(a / b);
					break;



			}
			





		}

	
	



	}
}

	

