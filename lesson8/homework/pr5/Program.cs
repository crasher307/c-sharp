using func;

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// -------------------------------------------------------------------

int x = 0, y = 0;
while ((y = rw.getInt("Введите кол-во строк")) < 2) rw.error("Мин. строк = 2");
while ((x = rw.getInt("Введите кол-во столбцов")) < 2) rw.error("Мин. столбцов = 2");

var mtx = new data(y, x);
for (int number = 1, step = 0; mtx.isNull(); number++) {
	mtx.set(number);
	switch (step) {
		case 0: if (mtx.step(true, true)) step++; break;
		case 1: if (mtx.step(true, false)) step++; break;
		case 2: if (mtx.step(false, true)) step++; break;
		case 3: if (mtx.step(false, false)) step = 0; break;
	}
}
ar.echoMatrix(mtx.get());

// -------------------------------------------------------------------

class data {
	private string[,] matrix;
	private (int x, int y) point = (0, 0);
	private (int x, int y) min = (0, 0);
	private (int x, int y) max = (0, 0);
	public data(int y = 4, int x = 4) {
		this.max.x = x - 1;
		this.max.y = y - 1;
		this.matrix = new string[y, x];
	}
	public string[,] get() {
		return this.matrix;
	}
	public void set(int value) {
		this.matrix[this.point.y, this.point.x] = ($"{value}").PadLeft(2, '0');
	}
	public bool isNull() {
		return this.matrix[this.point.y, this.point.x] == null;
	}
	public bool step(bool up, bool xPoint) {
		bool result = false;
		if (xPoint) this.point.x += (up ? 1 : -1); else this.point.y += (up ? 1 : -1);
		if (xPoint ? this.point.x == (up ? this.max.x : this.min.x) : this.point.y == (up ? this.max.y : this.min.y)) {
			if (up && xPoint) this.min.y++;
			else if (up && !xPoint) this.max.x--;
			else if (!up && xPoint) this.max.y--;
			else if (!up && !xPoint) this.min.x++;
			result = true;
		}
		return result;
	}
}