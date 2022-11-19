namespace func;

public class ar : baseFunc {
	// Вывод массива
	public static void echoArray<T>(T[] array, string message = "Массив") {
		rw.echo($"{message}: {String.Join("; ", array)};");
	}

	// Вывод матрицы
	public static void echoMatrix<T>(T[,] matrix, string message = "Матрица") {
		var view = matrix.GetEnumerator();
		int cols = matrix.GetLength(matrix.Rank - 1);

		rw.echo($"{message}:");
		for (int i = 1; view.MoveNext(); i++) {
			if (i > cols) i = 1;
			rw.echoObject("{0}\t", view.Current, i == cols);
		}
	}

	// Генерация массива
	public static void init<T>(T[] array, int minValue = 0, int maxValue = 1) {
		// var numbersArray = new int[??] | new double[??];
		// ar.initNew(numbersArray, 100, 999);
		maxValue++;
		Random rnd = new Random();

		bool isDouble = typeof(T).Name == "Double";
		string[] types = {"Int16", "Int32", "Double"};

		if ((types).Contains(typeof(T).Name)) {
			double num;
			for (int i = 0; i < array.Length; i++) {
				num = rnd.Next(minValue, maxValue);
				if (isDouble) {
					if (num < 0) num += rnd.NextDouble();
					if (num > 0) num -= rnd.NextDouble();
				}
				array[i] = (T) Convert.ChangeType(Math.Round(num, isDouble ? 2 : 0), typeof(T));
			}
		}
	}
}