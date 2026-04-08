namespace SecondaryCourseWorks.Works;

internal class PW62 : BasePracticalWork
{
	public override string Number => "6.2";

	protected override string RawDescription => @"
		Вставить первую строку после строк, в которых
		находится максимальный элемент. 

		Удалите столбцы, в которых есть заданный элемент.
		Если такого столбца нет, то вывести сообщение об этом.
	";

	public override void Execute()
	{
		int cols = Random.Shared.Next(6, 10);
		int rows = Random.Shared.Next(4, 6);

		int[,] matrix = CreateRandom2DMatrix(cols, rows, -15, 15);

		Console.WriteLine("Матрица:");
		matrix.PrintMatrix();
		Part1(ref matrix);

		Console.WriteLine("Матрица после 1 части:");
		matrix.PrintMatrix();
		Part2(ref matrix);

		Console.WriteLine("Итоговая матрица:");
		matrix.PrintMatrix();
	}

	void Part1(ref int[,] matrix)
	{
		var rows = matrix.GetLength(0);
		var cols = matrix.GetLength(1);

		int max = int.MinValue;
		var rowsWithMax = new List<int>(capacity: rows);

		for (int row = 0; row < rows; row++)
			for (int col = 0; col < cols; col++)
			{
				int el = matrix[row, col];
				if (max < el)
				{
					max = el;
					rowsWithMax.Clear();
					// Добавляем при нахождении
					rowsWithMax.Add(row);
				}
				// Добавляем при повторной встрече max, избегаем дублирования
				else if (el == max && rowsWithMax.LastOrDefault() != row)
					rowsWithMax.Add(row);
			}

		bool[] rowHasMax = new bool[rows];
		foreach (var row in rowsWithMax)
			rowHasMax[row] = true;

		Console.WriteLine($"Максимальный элемент: {max}\n");
		Console.WriteLine($"Строки с максимумом: {rowsWithMax.ToArray().Repr()}");

		int[,] newMatrix = new int[rows + rowsWithMax.Count, cols];
		int currentWriteRow = 0;
		for (int row = 0; row < rows; row++)
		{
			for (int col = 0; col < cols; col++)
				newMatrix[currentWriteRow, col] = matrix[row, col];
			currentWriteRow++;

			if (!rowHasMax[row]) continue;
			for (int col = 0; col < cols; col++)
				newMatrix[currentWriteRow, col] = matrix[0, col];
			currentWriteRow++;
		}
		matrix = newMatrix;
	}

	void Part2(ref int[,] matrix)
	{
		var rows = matrix.GetLength(0);
		var cols = matrix.GetLength(1);

		int targetElement = Input<int>("Элемент для поиска");

		bool[] hasColTarget = new bool[cols];
		for (int row = 0; row < rows; row++)
			for (int col = 0; col < cols; col++)
				if (matrix[row, col] == targetElement)
					hasColTarget[col] = true;

		int colsWithTargetCount = 0;
		foreach (var has in hasColTarget)
			if (has) colsWithTargetCount++;

		if (colsWithTargetCount == 0)
		{
			Console.WriteLine($"Нет столбцов с элементом {targetElement}.");
			return;
		}

		int[,] newMatrix = new int[rows, cols - colsWithTargetCount];
		int currentWriteCol = 0;
		for (int col = 0; col < cols; col++)
		{
			if (hasColTarget[col])
				continue;
			for (int row = 0; row < rows; row++)
				newMatrix[row, currentWriteCol] = matrix[row, col];
			currentWriteCol++;
		}

		matrix = newMatrix;
	}
}
