using func;

// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

// -------------------------------------------------------------------

var array = new int[rw.getInt("Введите кол-во строк", true), rw.getInt("Введите кол-во столбцов", true)];
for (int m = 0; m < array.GetLength(0); m++) {
	for (int n = 0; n < array.GetLength(1); n++) {
		array[m, n] = m + n;
	}
}

ar.echoMatrix(array);

// -------------------------------------------------------------------

/*
// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

int[,] InitArray(int m,int n)
{
    int[,] array = new int[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i,j] = i + j;
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Введите размер m: ");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("Введите размер n: ");
int n = int.Parse(Console.ReadLine());
int[,] array = InitArray(m,n);
PrintArray(array);
*/