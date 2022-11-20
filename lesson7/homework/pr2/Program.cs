using func;

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// -------------------------------------------------------------------

// Для поиска по индексам
string searchIndex<T>(T[,] matrix) {
	(int x, int y) point = (rw.getInt("Искомая строка") - 1, rw.getInt("Искомый столбец") - 1); // TODO добавить while((x = rw.getInt()) >= 0 && ...)
	bool isFound = point.x <= matrix.GetLength(0) && point.y <= matrix.GetLength(1);
	return !isFound ? String.Empty : $"[{point.x}, {point.y}] = {matrix[point.x, point.y]}";
}

// Для поиска по значению
string searchValue<T>(T[,] matrix) {
	string need = rw.getStr("Искомое значение");
	(int x, int y) point = (-1, -1);
	bool isFound = false;
	for (int i = 0; i < matrix.GetLength(0); i++) {
		for (int k = 0; k < matrix.GetLength(1); k++) {
			if ($"{matrix[i, k]}" == need) {
				point = (i, k);
				isFound = true;
				break;
			}
		}
		if (isFound) break;
	}
	isFound = point.x != -1 && point.y != -1;
	return !isFound ? String.Empty : $"[{point.x}, {point.y}] = {matrix[point.x, point.y]}";
}

var matrix = new int[3, 4];
ar.initMatrix(matrix, 0, 9);

int type;
int[] types = {1, 2};
string message = String.Empty;
while (true) {
	ar.echoMatrix(matrix);
	while (!types.Contains(type = rw.getInt("Поиск по (1 - индексу, 2 - значению)"))) rw.error("Не выбран тип поиска");
	switch (type) {
		case 1: message = searchIndex(matrix); break;
		case 2: message = searchValue(matrix); break;
		default: message = String.Empty; break;
	}
	rw.echo("Элемент " + (message == String.Empty ? " не" : "") + $"найден {message}");
}

// -------------------------------------------------------------------