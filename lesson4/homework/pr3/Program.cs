using func;

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// пример из 5 элементов:
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// получить все 8 чисел за одно нажатие Enter от пользователя.подсказка: использовать метод Split();

// -------------------------------------------------------------------

string[] arr = new string[8];
arr = rw.getStr("Введите 8 эл-ов через запятую").Split(",");
for (int i = 0; i < 8; i++) {
	if (i != 0) rw.echo(", ", false);
	rw.echo(arr[i].Trim(' '), false);
}

// -------------------------------------------------------------------