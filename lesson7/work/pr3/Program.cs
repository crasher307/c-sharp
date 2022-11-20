using func;

// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, изначально массив выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Новый массив будет выглядеть вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4

// -------------------------------------------------------------------

var array = new int[rw.getInt("Введите кол-во строк", true), rw.getInt("Введите кол-во столбцов", true)];
ar.initMatrix(array, 4, 9);
ar.echoMatrix(array, "Базовая матрица");

bool usePow = false;
for (int m = 0; m < array.GetLength(0); m++) {
	for (int n = 0; n < array.GetLength(1); n++) {
		usePow = (m + 1) % 2 == 0 && (n + 1) % 2 == 0;
		if (usePow) array[m, n] = (int) Math.Pow(array[m, n], 2);
	}
}
ar.echoMatrix(array, "Измененная матрица");

// -------------------------------------------------------------------

/*
int GetConsole(string msg, int x)
{
    int result;

    while (true)
    {
        void LogWrong(string err)
        {
            Console.WriteLine(err);
        }

        Console.Write(msg);

        string str = Console.ReadLine() ?? "";

        if (int.TryParse(str, out int number) && number > x)
        {
            result = number;
            break;
        }
        else
        {
            LogWrong($"Нужно число > {x}.\n");
        }
    }

    return result;
}

int[,] InitArray(int m, int n)
{
    Random rnd = new Random();
    int b;
    int[,] arr = new int[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            b = rnd.Next(-9, 10);
            arr[i,j] = b;
        }
    }
    return arr;
}

int GetConsole(string msg, int x)
{
    int result;

    while (true)
    {
        void LogWrong(string err)
        {
            Console.WriteLine(err);
        }

        Console.Write(msg);

        string str = Console.ReadLine() ?? "";

        if (int.TryParse(str, out int number) && number > x)
        {
            result = number;
            break;
        }
        else
        {
            LogWrong($"Нужно число > {x}.\n");
        }
    }

    return result;
}

int[,] InitArray(int m, int n)
{
    Random rnd = new Random();
    int b;
    int[,] arr = new int[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            b = rnd.Next(-9, 10);
            arr[i,j] = b;
        }
    }
    return arr;
}
*/