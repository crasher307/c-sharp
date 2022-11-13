using func;

// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

// -------------------------------------------------------------------

int[] multi(int[] array) {
	int count = array.Length / 2 + array.Length % 2;
	int[] newArr = new int[count];
	for (int i = 0, k = array.Length - 1; i < count; i++, k--) newArr[i] = (i == k) ? array[i] : array[i] * array[k];
	return newArr;
}

int[] arr = ar.initInt(5, 1, 10);
int[] arrSumm = multi(arr);

ar.echoArray(arr);
ar.echoArray(arrSumm, "Произведение пар чисел");

// -------------------------------------------------------------------

/*
int[] InitArray()
{
    Random rnd = new Random();
    int k = rnd.Next(5,11);
    int[] result = new int[k];
    
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(0,10);
    }

    return result;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void PrintP(int[] array)
{
    
    for (int i = 0; i < array.Length / 2; i++)
    {        
        Console.Write($"{array[i] * array[array.Length - i - 1]} ");
    }
    if(array.Length % 2 != 0) Console.Write(array[array.Length / 2]);
    Console.WriteLine();
}

int[] a = InitArray();
PrintArray(a);
PrintP(a);
*/