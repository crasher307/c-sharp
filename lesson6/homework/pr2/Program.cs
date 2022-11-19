using func;

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// -------------------------------------------------------------------
// x = (b1 - b2) / (k2 - k1)
// y = k2 * x + b2

(double x, double y) intersect(point point1, point point2) {
	double x = Math.Round((double) (point1.b - point2.b) / (point2.k - point1.k), 2);
	double y = Math.Round((double) point2.k * x + point2.b, 2);
	return (x, y);
}

var point1 = new point(rw.getInt("Введите B1"), rw.getInt("Введите K1"));
var point2 = new point(rw.getInt("Введите B2"), rw.getInt("Введите K2"));
var point = new double[2];
(point[0], point[1]) = intersect(point1, point2);

rw.echo($"Точка пересечения: ({String.Join("; ", point)})");
// -------------------------------------------------------------------
class point {
	public int b, k;
	public point(int b, int k) {
		this.b = b;
		this.k = k;
	}
}