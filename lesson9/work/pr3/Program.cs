using func;

// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

// -------------------------------------------------------------------

int sum(char[] chars, int idx = 0) {
    int.TryParse($"{chars[idx++]}", out int num);
    return idx < chars.Length ? num + sum(chars, idx) : num;
}

int number = rw.getInt();
rw.echo($"Сумма чисел числа {number} = {sum(number.ToString().ToCharArray())}");

// -------------------------------------------------------------------

/*
// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9


int GetNumber(string msg)
{
    Console.WriteLine(msg);
    int userNumber = Convert.ToInt32(Console.ReadLine());
    return userNumber;
}

int SumOfDigit(int userNumber, int sum)
{
    if(userNumber%10==0) return sum;
    else{
        sum = sum + userNumber%10;
        
    }
    return SumOfDigit(userNumber/10, sum);
}

int userNmbr = GetNumber("Введите число: ");
int sum = 0;
int sumOfDigit = SumOfDigit(userNmbr,sum);
Console.WriteLine(sumOfDigit);
*/