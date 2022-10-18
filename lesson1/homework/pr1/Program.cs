// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

int count = 2; // Кол-во вводимых чисел

int[] num = new int[count];
for (int i = 1; i <= count; i++) {
	num[i - 1] = int.Parse(get("int", $"Введите {i} число"));
}
minMax(num, out int? min, out int? max);
if (min == max)
	Console.WriteLine($"Числа равны ({min})");
else
	Console.WriteLine($"Мин: {min}; Макс: {max}");

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

// Получение вводимых данных
string get(string needType, string message) {
	string? read = null;
	string? type = null;

	Console.Clear();
	while (type != needType) {
		if (read != null)
			error("Error type", $"Требуется тип \"{needType}\"; Используемый \"{type}\"");
		Console.Write($"{message}: ");
		read = Console.ReadLine();
		type = checkType(read);
	}

	Console.Clear();
	return read != null ? read : "";
}

// checkType.cs - Проверка типа вводимых данных
string checkType(string? str) {
	string type = "string";

	if (str == null)
		type = "null";
	else if (bool.TryParse(str, out bool tmpBool))
		type = "bool";
	else if (int.TryParse(str, out int tmpInt))
		type = "int";
	else if (float.TryParse(str, out float tmpFloat))
		type = "float";

	return type;
}

// error.cs - Вывод ошибок
void error(string type, string message) {
	Console.Clear();
	Console.BackgroundColor = ConsoleColor.Red;
	Console.Write($" {type} ");
	Console.BackgroundColor = ConsoleColor.Gray;
	Console.WriteLine($" {message} ");
	Console.ResetColor();
}