/*
Напишите программу, которая выводит
случайное число из отрезка [10,99] и показывает
наибольшую цифру числа.
78 -> 8
12 -> 2
85 -> 8
*/

Random rnd = new Random();
int number = rnd.Next(10, 100);
int[] digit = {number / 10, number % 10};

if (digit[1] > digit[0]) {
	(digit[0], digit[1]) = (digit[1], digit[0]);
}

if (digit[0] == digit[1]) {
	Console.WriteLine($"Цифры числа {number} равны");
} else {
	Console.WriteLine($"Наибольшая цифра числа {number} = {digit[0]}");
}