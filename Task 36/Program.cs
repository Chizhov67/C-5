namespace ConsoleAppTask36
{
	internal class Program
	{
		static void createArray(int[] array)
		{
			Random rnd = new Random();
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = rnd.Next(-100, 101);
			}
		}

		static void printArray(int[] array)
		{
			foreach (int element in array)
			{
				Console.Write(element + " ");
			}
		}

		static int sumOdd(int[] array)
		{
			int sum = 0;

			for(int i = 1; i < array.Length; i+=2)
			{
				sum += array[i];
			}

			return sum;
		}


		static void Main(string[] args)
		{
			int N;

			Console.Write("Введите количество элементов в массиве: ");

			while (!int.TryParse(Console.ReadLine(), out N))
			{
				Console.Write("\nНеверный ввод!\n\nВведите количество элементов в массиве:");
			}

			int[] array = new int[N];

			createArray(array);
			printArray(array);

			Console.WriteLine("\n\nСумма элементов на нечетных позициях = " + sumOdd(array));

			Console.ReadLine();
		}
	}
}
