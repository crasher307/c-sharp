// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

bool getStr(string message, out string? variable) {
	Console.Write($"{message}: ");
	string str = Console.ReadLine();
	bool result = int.TryParse(str, out int num);
	variable = result ? str : null;
	return result;
}

string? number = null;
while (!getStr("Введите 3х значное число", out number) || number.Length != 3) {
	Console.WriteLine("-- Попробуйте снова --");
}
Console.WriteLine($"number - {number}; result - {number[1]}");