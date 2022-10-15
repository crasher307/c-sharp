// Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).
// Например:
// 4 -> 16 
// -3 -> 9 
// -7 -> 49

Console.WriteLine("Введите число, у которого хотите получить квадрат:");
string numberStr = Console.ReadLine(); // console write - :string
int number = int.Parse(numberStr);
int result = number * number;

Console.WriteLine($"Квадрат числа {number} равен {result}");