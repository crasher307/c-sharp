using func;

// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

// -------------------------------------------------------------------

// TODO работает некорректно, если используются символы не из словаря

(char[] value, int count) toChars<type>(type value) {
	int count = ($"{value}").Length;
	char[] chars = new char[count];
	if (value != null) chars = ($"{value}").ToCharArray();
	return (chars, count);
}

string convertSystem<type>(type valueIn, int systemIn = 10, int systemOut = 2) { // 11, 12 ...
	bool work = (systemIn >= 2 && systemIn <= 16) && (systemOut >= 2 && systemOut <= 16);
	if (!work) rw.error("Error system", "Метод работает в диапазоне [2..16] систем счисления");

	char[] chars;
	int count;

	char[] abc16 = {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F'};
	int thisVal;
	char thisChar;

	// value10 (valueIn to 10)
	double value10 = 0;
	if (systemIn == 10) double.TryParse($"{valueIn}", out value10);
	else {
		(chars, count) = toChars(valueIn); // valueIn
		for (int i = 0, ex = count - 1; i < count; i++, ex--) {
			thisVal = Array.IndexOf(abc16, chars[i]);
			value10 += thisVal * Math.Pow(systemIn, ex);
		}
	}

	// valueOut (10 to valueOut)
	string valueOut = "";
	if (systemOut == 10) valueOut = $"{value10}";
	else {
		(chars, count) = toChars(value10); // value10
		while (value10 > 0) {
			thisChar = abc16[(int) value10 % systemOut];
			valueOut = $"{thisChar}{valueOut}";
			value10 = Math.Floor(value10 / systemOut);
		}
	}
	return valueOut;
}

string[] read;
int systemIn, systemOut;
bool sysIn, sysOut;

while (true) {
	read = rw.getStr("Введите <number> <systemIn> <systemOut>").Split(" ");
	if (read.Length != 3) rw.error("Error", "Нужно ввести 3 параметра");
	else {
		if (!(sysIn = int.TryParse(read[1], out systemIn))) rw.error("Error", "Параметр systemIn принимает целочисленные значения");
		if (!(sysOut = int.TryParse(read[2], out systemOut))) rw.error("Error", "Параметр systemOut принимает целочисленные значения");
		if (sysIn && sysOut) rw.echo($"{read[0]}({systemIn}) -> {convertSystem(read[0], systemIn, systemOut)}({systemOut})");
	}
	rw.echo("");
}

// -------------------------------------------------------------------
/* Первая реализация
string convert(int number, int system = 2) { // Добавить обработку для 16-ти ричной системы счисления
	string res = "";
	while (number > 1) {
		// number % system = 10 ~ A, 11 ~ B ...
		res = $"{number % system}{res}";
		number /= system;
	}
	res = $"{number % system}{res}";
	return res;
}

int number = rw.getInt("Введите число");
int system = rw.getInt("Введите систему счисления (число)");
string result = convert(number, system);

rw.echo($"Number: {number}(10) = {result}({system})");
*/
// -------------------------------------------------------------------

/*
// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

int GetNumber(string msg)
{
    Console.Write(msg);
    int message = Convert.ToInt32(Console.ReadLine());
    return message;
}

string NumberConvert(int userNumber)
// Надо делить на 2 пока результат от деления на 2 не будет < 2
{
string result = String.Empty;

    while(userNumber != 0)
    {
    result += userNumber % 2;
    userNumber =  userNumber / 2;
    }

return result;
}

string Revert(string a)
{
string resultA = new string(a.Reverse().ToArray());
return resultA;
}

int numberA = GetNumber("Введите число: ");
string resultOfConvert = NumberConvert(numberA);
string finalResult = Revert(resultOfConvert);
Console.Write($"Преобразованное число: {finalResult}");
*/