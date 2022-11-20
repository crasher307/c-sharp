using func;

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// -------------------------------------------------------------------

(int x, int y) size = (rw.getInt("Число строк", true), rw.getInt("Число столбцов", true));

var matrix = new int[size.x, size.y];
ar.initMatrix(matrix, 2, 5);

var average = new double[matrix.GetLength(1)];
for (int k = 0; k < matrix.GetLength(1); k++) {
	average[k] = 0;
	for (int i = 0; i < matrix.GetLength(0); i++) {
		average[k] += matrix[i, k];
	}
	average[k] = Math.Round(average[k] / matrix.GetLength(0), 2);
}

ar.echoMatrix(matrix);
rw.echo("Среднее арифметическое:");
rw.echo(String.Join("\t", average));

// -------------------------------------------------------------------