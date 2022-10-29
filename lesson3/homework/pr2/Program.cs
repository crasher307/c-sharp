using func;

// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// -------------------------------------------------------------------

(int x, int y, int z) getCoord(string numPoint) {
	int x = 0;
	int y = 0;
	int z = 0;
	while (x == 0 || y == 0) {
		if (x == 0) x = rw.getInt($"[{numPoint}] Введите координаты X");
		if (y == 0) y = rw.getInt($"[{numPoint}] Введите координаты Y");
		if (z == 0) z = rw.getInt($"[{numPoint}] Введите координаты Z");
	}
	return (x, y, z);
}

double getDist((int x, int y, int z) p1, (int x, int y, int z) p2) {
    // AB = √((xb - xa)^2 + (yb - ya)^2 + (zb - za)^2)
	return Math.Sqrt(Math.Pow(p2.x - p1.x, 2) + Math.Pow(p2.y - p1.y, 2) + Math.Pow(p2.z - p1.z, 2));
}

var p1 = getCoord("1-ая точка");
var p2 = getCoord("2-ая точка");
var dist = Math.Round(getDist(p1, p2), 2);

rw.echo($"Расстояние между точками {p1} и {p2} = {dist}");

// -------------------------------------------------------------------