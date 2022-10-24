using func;

// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
//   2  |  1
// -----------
//   3  |  4

// -------------------------------------------------------------------

(int x, int y) getCoord() {
	int x = 0;
	int y = 0;
	while (x == 0 || y == 0) {
		if (x == 0) x = rw.getInt("Введите координаты X");
		if (y == 0) y = rw.getInt("Введите координаты Y");
	}
	return (x, y);
}
int getQtr(int x, int y) {
	if (x == 0 && y == 0) return 0;
	switch (x > 0, y > 0) {
		case (true, true): return 1;
		case (false, true): return 2;
		case (false, false): return 3;
		case (true, false): return 4;
	}
}

var (x, y) = getCoord();
int qtr = getQtr(x, y);

rw.echo($"Точка с координатами ({x}, {y}) находится в {qtr} четверти");

// -------------------------------------------------------------------

// 2 типа данных:
// 1. ссылочный (resolve) - typeof (class, list, array, char ...)
// 2. значимый (value) - (int, double, datetime, struct, enum, long, bool, byte)