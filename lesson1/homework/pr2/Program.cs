// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

int count = 3;

Console.WriteLine($"Введите поочередно {count} числа(ел):");
int[] num = new int[count];
for (int i = 0; i < count; i++) {
	num[i] = int.Parse(Console.ReadLine());
}

int max = 0;
foreach (int number in num) {
	if (number > max) max = number;
}

Console.WriteLine($"Максимальное число: {max}");