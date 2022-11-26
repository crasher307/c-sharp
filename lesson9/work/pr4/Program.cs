using func;

// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

// -------------------------------------------------------------------

double pow(int a, int b) => b == 1 ? a : a * pow(a, b - 1);
rw.echo($"{pow(rw.getInt("Введите число A"), rw.getInt("Введите число B"))}");

// -------------------------------------------------------------------

/*
// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8


int GetNumber(string msg)
{
    Console.WriteLine(msg);
    int userNumber = Convert.ToInt32(Console.ReadLine());
    return userNumber;
}

int DegreeOfDigit(int numberA, int numberB)
{
    if(numberB == 1) return numberA;
    else{
        return numberA*DegreeOfDigit(numberA,numberB - 1);
    }
}

int userNumberM = GetNumber("Введите число A:");
int userNumberN = GetNumber("Введите число B:");

int result = DegreeOfDigit(userNumberM, userNumberN);
Console.WriteLine(result);
*/