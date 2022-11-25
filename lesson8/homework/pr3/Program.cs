using func;

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// -------------------------------------------------------------------

// Умножить две матрицы можно только в том случае, если число столбцов первой (m) равняется числу строк второй (n).
// (a1) (b1) | (c1)		(a1c1 + b1c2)
// (a2) (b2) | (c2)		(a2c1 + b2c2)

int[,] multiMatrix(int[,] matrix1, int[,] matrix2) {
	var matrix3 = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
	if (matrix1.GetLength(1) != matrix2.GetLength(0)) {
		rw.error("Число столбцов первой матрицы не равняется числу строк второй");
	} else {
		for (var i = 0; i < matrix1.GetLength(0); i++) {
			for (var k = 0; k < matrix2.GetLength(1); k++) {
				matrix3[i, k] = 0;
				for (var j = 0; j < matrix1.GetLength(1); j++) matrix3[i, k] += matrix1[i, j] * matrix2[j, k];
			}
		}
	}
	return matrix3;
}

int size = rw.getInt("Введите размерность", true);
var matrix1 = new int[size, size];
var matrix2 = new int[size, size];
ar.initMatrix(matrix1, 0, 9);
ar.initMatrix(matrix2, 0, 9);
ar.echoMatrix(matrix1, "Матрица 1");
ar.echoMatrix(matrix2, "Матрица 2");

var matrix3 = multiMatrix(matrix1, matrix2);
ar.echoMatrix(matrix3, "Произведение матриц");

// -------------------------------------------------------------------