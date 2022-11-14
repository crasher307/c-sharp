using func;

// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

// -------------------------------------------------------------------

int search(int needMin, int needMax, int[] array) {
	int count = 0;
	foreach (var item in array) if (item >= needMin && item <= needMax) count++;
	return count;
}

int min = 10, max = 99;
var numbersArray = new int[rw.getInt("Введите кол-во эл-ов", true)];
ar.init(numbersArray, -99, 99);

int srchCount = search(min, max, numbersArray);

ar.echoArray(numbersArray);
rw.echo($"Чисел в диапазоне от {min} до {max}: {srchCount}");

// -------------------------------------------------------------------

/*
int[] InitArray()
{
    int[] result = new int[10];
    Random rnd = new Random();
    for (int i = 0; i < 10; i++)
    {
        result[i] = rnd.Next(-9,100);
    }
    return result;
}
void Print(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int Result( int[] array)

{
    int num = 0;
        for (int i = 0; i < array.Length; i++)
    {
        if (array[i] <=99 && array[i] >=10)
        {
        num++;
        }
    }
    return num;

}

int[] array = InitArray();
int result = Result(array);
Print(array);
Console.WriteLine($"{result}");
*/