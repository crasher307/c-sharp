// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

bool getStr(string message, out string? variable) {
	Console.Write($"{message}: ");
	string str = Console.ReadLine();
	bool result = int.TryParse(str, out int num);
	variable = result ? str : null;
	return result;
}

int day = -1;
string? number = null;

while (day == null || day < 0) {
	while (!getStr("Введите номер дня недели", out number) || number.Length != 1) {
		Console.WriteLine("-- Попробуйте снова --");
	}
	day = int.Parse(number) - 1;
}

string[] week = {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};
bool res = day < 5;

Console.WriteLine((res ? "Нет" : "Да") + $", {week[day]} - " + (res ? "не " : "") + "выходной");