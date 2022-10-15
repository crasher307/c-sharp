// 7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 	456 -> 6
// 	782 -> 2
// 	918 -> 8

Console.WriteLine("Введите 3х значное число:");
int num = Math.Abs(int.Parse(Console.ReadLine()));

if (num < 100 || num > 999) {
	Console.WriteLine("Введено не 3х значное число");
} else {
	string result = num.ToString();
	Console.WriteLine(result[2]);
}