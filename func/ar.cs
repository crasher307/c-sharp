namespace func;

public class ar : baseFunc {
	// Генерация массива
	public static int[] init(int count = 10, int minValue = 0, int maxValue = 1) {
		maxValue++;
		Random rnd = new Random();

		int[] array = new int[count];
		for (int i = 0; i < array.Length; i++) array[i] = rnd.Next(minValue, maxValue);
		return array;
	}
	
	// Вывод массива
	public static void echoArrayInt(int[] array, string message = "Массив чисел") {
		string result = String.Join(", ", array);
		rw.echo($"{message}: {result}");
	}
}