namespace SecondaryCourseWorks.Works;

internal class PW52 : BasePracticalWork
{
	public override string Number => "5.2";
	protected override string RawDescription => @"
		Дан одномерный массив. Найдите разность наибольшего и наименьшего
		чисел в этом массиве, указать их индексы. Поменять местами 2-ой и
		7-ой элементы. 

		Дан одномерный массив. Удалить первый отрицательный элемент, если
		таковой имеется. Если отрицательных элементов нет, то выдать
		соответствующее сообщение.

		Задать случайным образом N элементов числового массива.
		Вставить число 25 перед чётными элементами массива.
	";

	public override void Execute()
	{
		var arr = CreateRandomArray(15, -30, 30);
		Console.WriteLine($"In array: {arr.Repr()}\nLength: {arr.Length}");
		Part1(arr);
		Part2(ref arr);
		Part3(ref arr);
		Console.WriteLine($"Out array: {arr.Repr()}\nLength: {arr.Length}");
	}

	void Part1(int[] arr)
	{
		int min = int.MaxValue, max = int.MinValue;
		int indexOfMin = -1, indexOfMax = -1;

		for (int i = 0; i < arr.Length; i++)
		{
			int val = arr[i];
			if (val < min) { min = val; indexOfMin = i; }
			if (val > max) { max = val; indexOfMax = i; }
		}

		Console.WriteLine($"Index of min: {indexOfMin}");
		Console.WriteLine($"Index of max: {indexOfMax}");

		// Меняется переданный arr!
		arr[indexOfMin] = max;
		arr[indexOfMax] = min;
	}

	void Part2(ref int[] arr)
	{
		int[] newArr = new int[arr.Length - 1];
		bool isNegativeSeen = false;
		int i = 0;
		foreach (int num in arr)
		{
			// Негативных чисел не было
			if (i == newArr.Length) break;
			if (num < 0 && !isNegativeSeen)
			{
				isNegativeSeen = true;
				continue;
			}
			newArr[i] = num;
			i++;
		}
		if (!isNegativeSeen)
			Console.WriteLine("Массив состоял только из положительных чисел.");

		// Меняем исходный массив
		arr = newArr.ToArray();
	}

	void Part3(ref int[] arr)
	{
		// Реализовано в CreateRandomArray

		int countOfEvenNumbers = 0;

		foreach (var num in arr) if (num % 2 == 0)
			countOfEvenNumbers++;

		var procArr = new int[arr.Length + countOfEvenNumbers];
		int j = 0;
		for (int i = 0; i < arr.Length; i++)
		{
			var num = arr[i];
			if (num % 2 == 0)
			{
				procArr[j] = 25;
				j++;
			}
			procArr[j] = num;
			j++;
		}

		arr = procArr;
		/*

		List<int> newArr = [];
		foreach (int num in arr)
		{
			if (num % 2 == 0)
				newArr.Add(25);
			newArr.Add(num);
		}

		arr = newArr.ToArray();
		*/
	}
}
