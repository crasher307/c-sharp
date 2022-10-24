using func;

// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// -------------------------------------------------------------------

int count = 2; // Кол-во вводимых чисел

int[] num = new int[count];
for (int i = 1; i <= count; i++) {
	num[i - 1] = rw.getInt($"Введите {i} число");
}

minMax(num, out int? min, out int? max);

if (min == max)
	rw.echo($"Числа равны ({min})");
else
	rw.echo($"Мин: {min}; Макс: {max};");

// -------------------------------------------------------------------

// Получение min/max
void minMax(int[] arr, out int? min, out int? max) {
	min = null;
	max = null;

	foreach (int a in arr) {
		if (a < min || min == null) min = a;
		if (a > max || max == null) max = a;
	}
}