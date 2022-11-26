using func;

// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

// -------------------------------------------------------------------

// Решить с пом. рекурсии
void numbers(int count, ref int[] result) {
	result[count - 1] = count--;
	if (count > 0) numbers(count, ref result);
}

var result = new int[rw.getInt("Введите кол-во элементов", true)];
numbers(result.Length, ref result);

ar.echoArray(result);

// -------------------------------------------------------------------

/*
// Задача 63:
// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

int GetNumber(string msg)
{
    Console.Write(msg);
    int userNumber = Convert.ToInt32(Console.ReadLine());;
    return userNumber;
}

string Stringrecursion(int number)
{
   if (number == 1) return number.ToString();
   
   return Stringrecursion(number - 1) + " " + number;
}

int userNumber = GetNumber("Введите число: ");
Console.WriteLine();
Console.Write(Stringrecursion(number: userNumber));
*/