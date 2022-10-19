// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

bool getStr(string message, out string? variable) {
	Console.Write($"{message}: ");
	string str = Console.ReadLine();
	bool result = int.TryParse(str, out int num);
	variable = result ? $"{num}" : null;
	return result;
}

string? number = null;
while (!getStr("Введите число", out number)) {
	Console.WriteLine("-- Попробуйте снова --");
}

Console.WriteLine($"number - {number}; result - " + (number.Length > 2 ? $"{number[2]}" : "третьей цифры нет"));