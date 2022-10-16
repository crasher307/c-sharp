// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

Random rnd = new Random();
int number = rnd.Next(100, 1000);

int[] digit = {number / 100, number % 10};
int result = int.Parse($"{digit[0]}{digit[1]}");

Console.WriteLine($"base - {number}; end - {result}");