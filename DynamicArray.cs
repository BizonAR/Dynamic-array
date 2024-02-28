using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArray
{
	internal class DynamicArray
	{
		static void Main(string[] args)
		{
			const string CommandExit = "exit";
			const string CommandSum = "sum";

			int[] arrayNumbers = new int[0];

			bool isProgramActive = true;

			Console.WriteLine("Добро пожаловать в приложение сумма чисел!");

			while (isProgramActive)
			{
				Console.WriteLine("Вы можете вводить числа и потом посчитать их сумму\n");
				Console.WriteLine("Список команд \n" +
					 $"1. {CommandExit} - выход из программы\n" +
					 $"2. {CommandSum} - сумма введённых чисел");

				Console.Write("Введите команду или число: ");
				string input = Console.ReadLine();

				Console.WriteLine();

				switch (input)
				{
					case CommandExit:
						isProgramActive = false;
						break;

					case CommandSum:
						int sum = 0;

						for (int i = 0; i < arrayNumbers.Length; i++)
							sum += arrayNumbers[i];

						Console.WriteLine($"Полученная сумма: {sum}\n");
						break;

					default:
						if (int.TryParse(input, out int number))
						{
							int[] updatedArray = new int[arrayNumbers.Length + 1];

							for (int i = 0; i < arrayNumbers.Length; i++)
								updatedArray[i] = arrayNumbers[i];

							updatedArray[updatedArray.Length - 1] = number;
							arrayNumbers = updatedArray;
						}
						else
						{
							Console.WriteLine("Некорректный ввод. Введите число или команду.\n");
						}
						break;
				}
			}
			Console.WriteLine("Программа завершена.");
		}
	}
}
