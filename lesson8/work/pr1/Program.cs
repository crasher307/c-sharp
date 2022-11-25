using func;

// Задача 53. Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

// -------------------------------------------------------------------

T[,] changeMatrix<T>(T[,] matrix) {
	var length = matrix.GetLength(0);
	var arrayStringFirst = new T[length];
	var arrayStringLast = new T[length];
	for (int i = 0; i < length; i++) {
		arrayStringFirst[i] = matrix[0, i];
		arrayStringLast[i] = matrix[length - 1, i];
	}
	for (int i = 0; i < length; i++) {
		matrix[0, i] = arrayStringLast[i];
		matrix[length - 1, i] = arrayStringFirst[i];
	}
	return matrix;
}

var matrix = new int[rw.getInt("Число строк", true), rw.getInt("Число столбцов", true)];
ar.initMatrix(matrix, -9, 9);
ar.echoMatrix(matrix);

matrix = changeMatrix(matrix);
ar.echoMatrix(matrix);

// -------------------------------------------------------------------

/*
// Задача 53:
// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

int GetNumber(string msg)
{
    Console.Write(msg);
    int userNumber = Convert.ToInt32(Console.ReadLine());;
    return userNumber;
}

int[,] InitArray(int m, int n)
{
    int [,] tempArray = new int[m,n];
    Random rnd = new Random();
    for (int i = 0; i < tempArray.GetLength(0); i++)
    {
        for (int j = 0; j < tempArray.GetLength(1); j++)
        {
            tempArray[i, j] = rnd.Next(0, 100);
        }
    }

    return tempArray;
}

void PrintArray(int [,] tempArray)
{
    for (int i = 0; i < tempArray.GetLength(0); i++)
    {
        for (int j = 0; j < tempArray.GetLength(1); j++)
        {
            Console.Write($"{tempArray[i,j]} ");
        }
        Console.WriteLine();
    }
}

int[,] ChangeArray(int[,] array, int m, int n)
{
    int [,] tempArray = new int[m,n];
    
    for (int i = 0; i < tempArray.GetLength(0); i++)
    {
        for (int j = 0; j < tempArray.GetLength(1); j++)
        {
            if(i == 0)
            tempArray[i, j] = array[m - 1, j];
            else if(i == (tempArray.GetLength(0) - 1))
            tempArray[i, j] = array[0, j];
            else
            tempArray[i, j] = array[i, j];
        }   
    }

    return tempArray;
}

int m = GetNumber("Введите число строк: ");
int n = GetNumber("Введите число столбцов: ");
int[,] firstArray = InitArray(m, n);
PrintArray(firstArray);
Console.WriteLine();
int[,] newArray = ChangeArray(array: firstArray, m, n);
PrintArray(newArray);
*/