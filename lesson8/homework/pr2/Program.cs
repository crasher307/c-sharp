using func;

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// -------------------------------------------------------------------

var matrix = new int[rw.getInt("Введите кол-во строк", true), rw.getInt("Введите кол-во столбцов", true)];
ar.initMatrix(matrix, 0, 9);
ar.echoMatrix(matrix);

int minString = 0;
double? sumString, minSumString = null;
for (int i = 0; i < matrix.GetLength(0); i++) {
	sumString = 0;
	for (int k = 0; k < matrix.GetLength(1); k++) sumString += matrix[i, k];
	if (minSumString == null || sumString < minSumString) {
		minSumString = sumString;
		minString = i;
	}
}

rw.echo($"Строка {minString + 1} содержит мин. сумму - {minSumString}");

// -------------------------------------------------------------------