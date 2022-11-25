using func;

// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.

// -------------------------------------------------------------------

var matrix = new int[rw.getInt("Число строк", true), rw.getInt("Число столбцов", true)];
ar.initMatrix(matrix, -9, 9);
ar.echoMatrix(matrix);

var newMatrix = new int[matrix.GetLength(1), matrix.GetLength(0)];
for (int i = 0; i < newMatrix.GetLength(0); i++) {
	for (int k = 0; k < newMatrix.GetLength(1); k++) {
		newMatrix[i, k] = matrix[k, i];
	}
}
ar.echoMatrix(newMatrix);

// -------------------------------------------------------------------

/*
// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
//  В случае, если это невозможно, программа должна вывести сообщение для пользователя.

int[,] InitMatrix(int m, int n)
{
    Random rnd = new Random();
    int[,] mtrx = new int[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            mtrx[i,j] = rnd.Next(0,10);
        }
    }
    return mtrx;
}

void PrintMatrix(int[,] mtrx)
{
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            Console.Write($"{mtrx[i,j]}  ");
        }
        Console.WriteLine();
    }
}

int[,] Trasponirovanie(int[,] matrix)
{
    int[,] resultMatrix = new int[matrix.GetLength(1),matrix.GetLength(0)];
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            resultMatrix[i,j] = matrix[j,i];
        }
    }
    return resultMatrix;
}
Console.WriteLine("Введите кол-во строк матрицы: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов матрицы: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = InitMatrix(m,n);
PrintMatrix(matrix);
Console.WriteLine("----------------------");
int[,] resultMtrx = Trasponirovanie(matrix);
PrintMatrix(resultMtrx);
*/