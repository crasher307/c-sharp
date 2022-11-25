using func;

// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// -------------------------------------------------------------------

var matrix = new int[rw.getInt("Введите кол-во строк", true), rw.getInt("Введите кол-во столбцов", true)];
ar.initMatrix(matrix, 0, 9);
ar.echoMatrix(matrix);

int[] arrSort;
int length = matrix.GetLength(1);
for (int i = 0; i < matrix.GetLength(0); i++) {
	arrSort = new int[length];
	for (int k = 0; k < length; k++) arrSort[k] = matrix[i, k];
	Array.Sort(arrSort);
	for (int k = 0, j = length - 1; k < length; k++, j--) matrix[i, j] = arrSort[k];
}
ar.echoMatrix(matrix, "Сортировка по убыванию");

// -------------------------------------------------------------------