using func;

// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
// [4, 5, 6] -> true
// [12, 6, 6] -> false

// -------------------------------------------------------------------

bool checkTriangle<type>(type[] triangle) {
	int[] value = new int[triangle.Length];
	bool[] check = new bool[triangle.Length];
	for (int i = 0; i < value.Length; i++) int.TryParse($"{triangle[i]}", out value[i]); // Парсим в int -> value
	for (int i = 0; i < check.Length; i++) check[i] = value[i] < (value.Sum() - value[i]);
	return !check.Contains(false);
}

int notUse;
bool[] isInt = {false, false, false};
bool allInt = false;
string[] triangle;
do {
    triangle = rw.getStr("Введите 3 стороны треугольника через пробел").Split(" ");
    for (int i = 0; i < triangle.Length; i++) isInt[i] = (bool) int.TryParse($"{triangle[i]}", out notUse);
    allInt = !isInt.Contains(false);
    if (triangle.Length != 3) rw.echo("-- Нужно ввести 3 стороны --");
    else if (!allInt) rw.echo("-- Нужно ввести целые числа --");
} while (triangle.Length != 3 || !allInt);

rw.echo($"Треугольник со сторонами [{String.Join(", ", triangle)}] " + (checkTriangle(triangle) ? "" : "не ") + "существует");

// -------------------------------------------------------------------

/*
// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.


int GetNumber(string msg)
{
    Console.Write(msg);
    int message = Convert.ToInt32(Console.ReadLine());
    return message;
}

void Check(int a, int b, int c)
{
    if(a < (b + c) && b < (a + c) && c<(a + b))
    Console.WriteLine("Такой треугольник существует");
    else 
    Console.WriteLine("Такой треугольник НЕ существует");
}


int numberA = GetNumber("Введите первое число:");
int numberB = GetNumber("Введите второе число:");
int numberC = GetNumber("Введите третье число:");

Check(numberA, numberB, numberC);
*/