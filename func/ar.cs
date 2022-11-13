namespace func;

public class ar : baseFunc {
	// Генерация массива
	public static int[] initInt(int count = 10, int minValue = 0, int maxValue = 1) {
		maxValue++;
		Random rnd = new Random();

		int[] array = new int[count];
		for (int i = 0; i < array.Length; i++) array[i] = rnd.Next(minValue, maxValue);
		return array;
	}
	// Генерация массива с плав. точкой
	public static double[] initDouble(int count = 10, int minValue = 0, int maxValue = 1) {
		maxValue++;
		Random rnd = new Random();

		double[] array = new double[count];
		double num;
		for (int i = 0; i < array.Length; i++) {
			num = rnd.Next(minValue, maxValue);
			if (num < 0) num += rnd.NextDouble();
			if (num > 0) num -= rnd.NextDouble();
			array[i] = Math.Round(num, 2);
		}
		return array;
	}
	
	// Вывод массива
	public static void echoArray<T>(T[] array, string message = "Массив чесел") {
		rw.echo($"{message}: {String.Join("; ", array)};");
	}
}