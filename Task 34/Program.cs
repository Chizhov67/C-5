namespace ConsoleAppTask34
{
	internal class Program
	{
		static void createArray(int[] array)
		{
			Random rnd = new Random();
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = rnd.Next(100, 1000);
			}
		}

		static void printArray(int[] array)
		{
			foreach (int element in array)
			{
				Console.Write(element + " ");
			}
		}

		static int countEven(int[] array)
		{
			int countEven = 0;

			foreach (int element in array)
			{
				if (element % 2 == 0)
				{
					countEven++;
				}
			}

			return countEven;
		}

		static void Main(string[] args)
		{
			int N;

			Console.Write("Введите количество элементов в массиве: ");

			while(!int.TryParse(Console.ReadLine(), out N))
			{
				Console.Write("\nНеверный ввод!\n\nВведите количество элементов в массиве:");
			}

			int[] array = new int[N];

			createArray(array);
			printArray(array);

			Console.WriteLine("\nКоличество четных элементов - " + countEven(array));

			Console.ReadLine();
		}
	}
}



