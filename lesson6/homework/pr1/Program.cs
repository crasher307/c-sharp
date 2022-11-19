using func;

// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// -------------------------------------------------------------------

string[] read = rw.getStr("Введите числа через пробел").Split(" ");
int[] numbers = new int[read.Length];
int countPositive = 0;
for (int i = 0; i < read.Length; i++) {
	int.TryParse(read[i], out numbers[i]);
	if (numbers[i] > 0) countPositive++;
}

rw.echo($"Положительных чисел: {countPositive}");

// -------------------------------------------------------------------