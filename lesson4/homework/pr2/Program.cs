using func;

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// -------------------------------------------------------------------

string num = rw.getInt().ToString();
char[] numArr = num.ToCharArray();

int res = 0, tmp;
foreach (var item in numArr) {
	int.TryParse(item.ToString(), out tmp);
	res += tmp;
}

rw.echo($"Сумма чисел числа {num} = {res}");

// -------------------------------------------------------------------