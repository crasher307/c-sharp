// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите поочередно 2 числа:");
int[] num = new int[2];
num[0] = int.Parse(Console.ReadLine());
num[1] = int.Parse(Console.ReadLine());

if (num[0] == num[1]) {
	Console.WriteLine($"Числа {num[0]}, {num[1]} равны");
} else {
	if (num[0] < num[1]) (num[0], num[1]) = (num[1], num[0]);
	Console.WriteLine($"Число {num[0]} больше {num[1]}");
}