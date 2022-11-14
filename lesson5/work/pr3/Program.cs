using func;

// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

// -------------------------------------------------------------------

bool search(int need, int[] array) => array.Contains(need) || array.Contains(-need);

int[] arr = {6, 7, 19, 345, 3};
int srch = rw.getInt("Введите искомое число");

ar.echoArray(arr);
rw.echo($"Искомое: {srch}; " + (search(srch, arr) ? "" : "не ") + "найдено");

// -------------------------------------------------------------------

/*
int[] InitArray(int n)
{
    int[] result = new int[n];
    Random rnd = new Random();
    for (int i = 0; i < n; i++)
    {
        result[i] = rnd.Next(-9,10);
    }
    return result;
}

void Print(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

Console.WriteLine("Введите число, которое надо найти в массиве");
var number = int.Parse(Console.ReadLine());

bool numberIsExist = false;

int[] array = InitArray(10);
Print(array);
for (int i = 0; i < array.Length; i++)
{
    if(number == array[i])
    {
        numberIsExist = true;
        break;    
    }
}

if(numberIsExist)
{
    Console.WriteLine("Да.");
}
else
{
    Console.WriteLine("Нет.");
}
*/