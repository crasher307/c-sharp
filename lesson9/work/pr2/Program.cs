using func;

// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

// -------------------------------------------------------------------

void numbers(ref int[] result, int idx, int min) {
	idx--;
	result[idx] = min + idx;
	if (idx > 0) numbers(ref result, idx, min);
}

int min = rw.getInt("Введите мин. значение", true),
	max = rw.getInt("Введите макс. значение", true);
var result = new int[max - min + 1];
numbers(ref result, result.Length, min);

ar.echoArray(result);

// -------------------------------------------------------------------

/*
// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"


int GetNumber(string msg)
{
    Console.WriteLine(msg);
    int userNumber = Convert.ToInt32(Console.ReadLine());
    return userNumber;
}

void PrintNimbers(int number, int count)
{
    if(count<=number)
    {
    Console.Write($"{count} ");
    PrintNimbers(number, count+1);
    }
}

int userNumberM = GetNumber("Введите число M:");
int userNumberN = GetNumber("Введите число N:");
PrintNimbers(userNumberN,userNumberM);
*/