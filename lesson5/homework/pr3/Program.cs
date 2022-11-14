using func;

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// -------------------------------------------------------------------

(double min, double max, double diff) search(double[] arr) {
	double min = arr[0], max = arr[0];
	foreach (var item in arr) {
		if (item < min) min = item;
		if (item > max) max = item;
	}
	return (min, max, Math.Round(max - min, 2));
}

var numbersArray = new double[rw.getInt("Введите кол-во эл-ов", true)];
ar.init(numbersArray, -99, 99);
(double min, double max, double diff) = search(numbersArray);

ar.echoArray(numbersArray);
rw.echo($"Разница между максимальным ({max}) и минимальным ({min}) эл-ами массива: {diff}");

// -------------------------------------------------------------------