using func;

// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// -------------------------------------------------------------------

var rnd = new Random();

(int size, int[,,] array) initArr(int x, int y, int z) {
	var array = new int[x,y,z];
	var size = array.GetLength(0) * array.GetLength(1) * array.GetLength(2) + 1;
	int min, max;
	while (((max = rw.getInt("Введите макс. значение")) - (min = rw.getInt("Введите мин. значение"))) < size) {
		rw.error($"Разница в значениях должна составлять не менее {size}");
	}
	var random = 0;
	var used = new int[size];
	var idx = 0;
	for (int a = 0; a < array.GetLength(0); a++) {
		for (int b = 0; b < array.GetLength(1); b++) {
			for (int c = 0; c < array.GetLength(2); c++) {
				while (used.Contains(random = rnd.Next(min, max))) continue;
				used[idx++] = array[a, b, c] = random;
			}
		}
	}
	return (size, array);
}

(var size, var array) = initArr(2, 2, 2);
var view = new string[size];
for (int a = 0; a < array.GetLength(0); a++) {
	for (int b = 0; b < array.GetLength(1); b++) {
		for (int c = 0; c < array.GetLength(2); c++) {
			rw.echo($"{array[a, b, c]} ({a},{b},{c})\t", false);
		}
		rw.echo("\n", false);
	}
}

// -------------------------------------------------------------------