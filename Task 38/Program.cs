namespace ConsoleAppTask38
{
	internal class Program
	{
		static void createArray(double[] array)
		{
			Random rnd = new Random();
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = Convert.ToDouble(rnd.Next(100, 10000)) / 100;
			}
		}

		static void printArray(double[] array)
		{
			foreach (double element in array)
			{
				Console.Write(element + " ");
			}
		}

		static double differenceBetween(double[] array)
		{
			double min = 10000, max = -10000;

			foreach (double element in array)
			{
				if (min > element)
				{
					min = element;
				}

				if (max < element)
				{
					max = element;
				}
			}

			return max - min;
		}

		static void Main(string[] args)
		{
			int N;

			Console.Write("Введите количество элементов в массиве: ");

			while (!int.TryParse(Console.ReadLine(), out N))
			{
				Console.Write("\nНеверный ввод!\n\nВведите количество элементов в массиве:");
			}

			double[] array = new double[N];

			createArray(array);
			printArray(array);

			Console.WriteLine("\n\nРазница между максимальным и минимальным элементом - " + differenceBetween(array));

			Console.ReadLine();
		}
	}
}
