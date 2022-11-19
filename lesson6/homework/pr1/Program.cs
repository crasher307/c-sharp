using func;

// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// -------------------------------------------------------------------

bool check(string[] read, out int[] numbers) {
	var length = read.Length;
	var isInt = new bool[length];
	numbers = new int[length];
	for (int i = 0; i < length; i++) isInt[i] = int.TryParse(read[i], out numbers[i]);
	return isInt.Contains(false);
}

int[] numbers;
while (check(rw.getStr("Введите числа через пробел").Split(" "), out numbers)) rw.echo("-- Попробуйте снова --");

int positive = 0;
foreach (var item in numbers) if (item > 0) positive++;

rw.echo($"Положительных чисел: {positive}");

// -------------------------------------------------------------------