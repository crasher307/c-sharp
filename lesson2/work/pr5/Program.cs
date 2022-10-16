// 16. Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

int rd(int num) {
	Console.Write($"Введите {num} число: ");
	return int.Parse(Console.ReadLine());
}

int num1 = rd(1);
int num2 = rd(2);

if (num1 > num2) (num1, num2) = (num2, num1);
bool result = (Math.Pow(num1, 2) == num2);

Console.WriteLine((result ? "Да" : "Нет") + $", Число {num2} " + (result ? "" : "не ") + $"является квадратом числа {num1}");