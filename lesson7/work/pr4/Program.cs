using func;

// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

// -------------------------------------------------------------------
// Цитата:
// "Главной диагональю прямоугольной матрицы является диагональ, которая
// начинается в верхнем левом углу матрицы и изменяется вниз и вправо, пока
// не будет достигнут правый или нижний край матрицы."
// https://ru.wikipedia.org/wiki/Главная_диагональ#:~:text=У%20квадратной%20матрицы%20проходит%20через,достигнут%20правый%20или%20нижний%20край.

// Опираясь на вышесказанное, проверок на "квадратность" матрицы я делать НЕ БУДУ!

var array = new int[rw.getInt("Введите кол-во строк", true), rw.getInt("Введите кол-во столбцов", true)];
ar.initMatrix(array, 1, 9);
ar.echoMatrix(array, "Базовая матрица");

int summ = 0;
string[,] viewMatrix = new string[array.GetLength(0), array.GetLength(1)];
for (int m = 0; m < viewMatrix.GetLength(0); m++) {
	for (int n = 0; n < viewMatrix.GetLength(1); n++) {
		if (m != n) viewMatrix[m, n] = $"-";
		else {
			summ += array[m, n];
			viewMatrix[m, n] = $"{array[m, n]}";
		}
	}
}
ar.echoMatrix(viewMatrix, "Главная диагональ");
rw.echo($"Сумма эл-ов на гл. диагонали: {summ}");

// -------------------------------------------------------------------

/*
int[,] InitArray(int m,int n)
{
    Random rnd = new Random();
    int[,] array = new int[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i,j] = rnd.Next(-10, 11);
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

int MainDiagSum(int[,] array)
{
        int sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
         for (int j = 0; j < array.GetLength(1); j++)
            {
                if(i == j) sum = sum + array[i, j];
            }
        }
    return sum;
}

Console.WriteLine("Введите размер m: ");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("Введите размер n: ");
int n = int.Parse(Console.ReadLine());
int[,] array = InitArray(m,n);
PrintArray(array);
if(array.GetLength(0) != array.GetLength(1))
    Console.WriteLine("Матирца не квадратная");
else
    Console.WriteLine($"сумма элементов гдавной диагонали равна: {MainDiagSum(array)}");
*/