namespace func;

public class ar : baseFunc {
	// Вывод массива (TODO *1 Переписать на 1 ф-цию)
	public static void echoArray<T>(T[] array, string message = "Массив") {
		rw.echo($"{message}: {String.Join("; ", array)};");
	}

	// Вывод матрицы (TODO *1)
	public static void echoMatrix<T>(T[,] matrix, string message = "Матрица") {
		var view = matrix.GetEnumerator();
		int cols = matrix.GetLength(matrix.Rank - 1);

		rw.echo($"{message}:");
		for (int i = 1; view.MoveNext(); i++) {
			if (i > cols) i = 1;
			rw.echoObject("{0}\t", view.Current, i == cols);
		}
	}

	// Генерация массива (TODO *2 Переписать на 1 ф-цию)
	public static void init<T>(T[] array, int minValue = 0, int maxValue = 1) {
		// var numbersArray = new int[??] | new double[??];
		// ar.init(numbersArray, 100, 999);

		for (int i = 0; i < array.Length; i++) {
			array[i] = rand.init<T>(minValue, maxValue);
		}
	}

	// Генерация матрицы (TODO *2)
	public static void initMatrix<T>(T[,] array, int minValue = 0, int maxValue = 1) {
		// var matrix = new int[??, ??] | new double[??, ??];
		// ar.initMatrix(matrix, 100, 999);
		
		for (int i = 0; i < array.GetLength(0); i++) {
			for (int k = 0; k < array.GetLength(1); k++) {
				array[i, k] = rand.init<T>(minValue, maxValue);
			}
		}
	}
}