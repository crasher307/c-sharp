using func;

// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.

// -------------------------------------------------------------------

double conv<T>(T value) => value == null ? 0 : (double) Convert.ChangeType(value, typeof(double));
(int x, int y) minMax<T>(T[,] matrix) {
	(int x, int y) idx = (0, 0);
	double min = conv(matrix[0, 0]);
	double val = 0;

	for (int i = 0; i < matrix.GetLength(0); i++) {
		for (int k = 0; k < matrix.GetLength(1); k++) {
			val = conv(matrix[i, k]);
			if (val < min) {
				min = val;
				idx = (i, k);
			}
		}
	}

	return idx;
}

var matrix = new int[rw.getInt("Число строк", true), rw.getInt("Число столбцов", true)];
ar.initMatrix(matrix, 0, 9);
ar.echoMatrix(matrix);

var minItem = minMax(matrix);
rw.echo($"Наименьший эл-т [{minItem.x}, {minItem.y}] = {matrix[minItem.x, minItem.y]}");

var newMatrix = new string[matrix.GetLength(0), matrix.GetLength(1)];
for (int i = 0; i < newMatrix.GetLength(0); i++) {
	for (int k = 0; k < newMatrix.GetLength(1); k++) {
		if (i == minItem.x || k == minItem.y) newMatrix[i, k] = " ";
		else newMatrix[i, k] = $"{matrix[i, k]}";
	}
}

ar.echoMatrix(newMatrix);

// -------------------------------------------------------------------

/*
// Задача 59: Задайте двумерный массив из целых чисел.
//  Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.

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

int[] FindMinOfMatrix(int[,] mtrx)
{
    int minElement = mtrx[0,0];
    int[] min = new int[2]{0,0};
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            if(mtrx[i,j]<minElement)
            {
                minElement = mtrx[i,j];
                min[0] = i;
                min[1] = j;
            }       
        }
    }
    return min;
}

int[,] ResultMatrix(int[,] mtrx, int[] pos)
{
    int countI = 0;
    int countJ = 0;
    int[,] resultMatrix = new int[mtrx.GetLength(0)-1,mtrx.GetLength(1)-1];
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        if(i != pos[0])
        {
            for (int j = 0; j < mtrx.GetLength(1); j++)
            {
                if(j != pos[1])
                {
                    resultMatrix[countI,countJ] = mtrx[i,j];
                    countJ++;
                }
            }
            countJ=0;
            countI++;
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
Console.WriteLine();
int[] posMin = FindMinOfMatrix(matrix);
int[,] resultMtrx = ResultMatrix(matrix, posMin);
PrintMatrix(resultMtrx);
*/