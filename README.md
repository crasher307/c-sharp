Знакомство с языками программирования (C#)
-----------------------------------------------

```bash
sh start.sh # запуск проекта (если проекта не существует - создает)

############## START.SH ##############
# 1. Ввод: Устанавливаем папку проекта ("y" - work | "n" - homework)
# 2. Ввод: Устанавливаем папку урока (<number> - lesson<number>)
#    ?? спросит создать ли папку урока, если она отсутствует
# 3. бесконечный цикл; выход: (Ctrl + C)
# 3.1. Ввод: Устанавливаем номер проекта (<number> - lesson*/[home]work/pr<number>)
#      ?? спросит создать ли проект, если он отсутствует (тж. подключит библиотеку классов)
# 3.2. Компиляция библиотеки классов
# 3.3. Запуск проекта
######################################

# DotNet
dotnet new console                                    # новый проект
dotnet new classlib                                   # новая библиотека классов
dotnet add reference "<folder_lib>/<file_lib>.csproj" # подключить библиотеку
dotnet run                                            # запуск проекта
```

### Практическая часть (семинары)

- Используемая [библиотека классов](https://github.com/crasher307/c-sharp/tree/master/func)

- <details><summary>Урок 1. Знакомство с языком программирования С#</summary>

	Напишите программу, которая:
	- [Работа во время семинара](https://github.com/crasher307/c-sharp/blob/master/lesson1/work)
		- [pr1](https://github.com/crasher307/c-sharp/blob/master/lesson1/work/pr1/Program.cs) - на вход принимает число и выдаёт его квадрат (число умноженное на само себя).
		- [pr2](https://github.com/crasher307/c-sharp/blob/master/lesson1/work/pr2/Program.cs) - на вход принимает два числа и проверяет, является ли первое число квадратом второго.
		- [pr3](https://github.com/crasher307/c-sharp/blob/master/lesson1/work/pr3/Program.cs) - будет выдавать название дня недели по заданному номеру.
		- [pr4](https://github.com/crasher307/c-sharp/blob/master/lesson1/work/pr4/Program.cs) - на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
		- [pr5](https://github.com/crasher307/c-sharp/blob/master/lesson1/work/pr5/Program.cs) - принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
	- [Домашнее задание](https://github.com/crasher307/c-sharp/blob/master/lesson2/homework)
		- [pr1](https://github.com/crasher307/c-sharp/blob/master/lesson2/homework/pr1/Program.cs) - на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
		- [pr2](https://github.com/crasher307/c-sharp/blob/master/lesson2/homework/pr2/Program.cs) - принимает на вход три числа и выдаёт максимальное из этих чисел.
		- [pr3](https://github.com/crasher307/c-sharp/blob/master/lesson2/homework/pr3/Program.cs) - на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
		- [pr4](https://github.com/crasher307/c-sharp/blob/master/lesson2/homework/pr4/Program.cs) - на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
	</details>

- <details><summary>Урок 2. Массивы и функции в программировании</summary>

	Напишите программу, которая:
	- [работа во время семинара](https://github.com/crasher307/c-sharp/tree/master/lesson2/work)
		- [pr1](https://github.com/crasher307/c-sharp/blob/master/lesson2/work/pr1/Program.cs) - выводит случайное число из отрезка [10,99] и показывает наибольшую цифру числа.
		- [pr2](https://github.com/crasher307/c-sharp/blob/master/lesson2/work/pr2/Program.cs) - выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
		- [pr3](https://github.com/crasher307/c-sharp/blob/master/lesson2/work/pr3/Program.cs) - будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
		- [pr4](https://github.com/crasher307/c-sharp/blob/master/lesson2/work/pr4/Program.cs) - принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
		- [pr5](https://github.com/crasher307/c-sharp/blob/master/lesson2/work/pr5/Program.cs) - принимает на вход два числа и проверяет, является ли одно число квадратом другого.
	- [домашнее задание](https://github.com/crasher307/c-sharp/tree/master/lesson2/homework)
		- [pr1](https://github.com/crasher307/c-sharp/blob/master/lesson2/homework/pr1/Program.cs) - принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
		- [pr2](https://github.com/crasher307/c-sharp/blob/master/lesson2/homework/pr2/Program.cs) - выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
		- [pr3](https://github.com/crasher307/c-sharp/blob/master/lesson2/homework/pr3/Program.cs) - принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
	</details>

- <details><summary>Урок 3. Массивы и функции в программировании</summary>

	Напишите программу, которая:
    - [работа во время семинара](https://github.com/crasher307/c-sharp/tree/master/lesson3/work)
        - [pr1](https://github.com/crasher307/c-sharp/blob/master/lesson3/work/pr1/Program.cs) - принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
        - [pr2](https://github.com/crasher307/c-sharp/blob/master/lesson3/work/pr2/Program.cs) - по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
        - [pr3](https://github.com/crasher307/c-sharp/blob/master/lesson3/work/pr3/Program.cs) - принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
        - [pr4](https://github.com/crasher307/c-sharp/blob/master/lesson3/work/pr4/Program.cs) - принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
    - [домашнее задание](https://github.com/crasher307/c-sharp/tree/master/lesson3/homework)
        - [pr1](https://github.com/crasher307/c-sharp/blob/master/lesson3/homework/pr1/Program.cs) - принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
        - [pr2](https://github.com/crasher307/c-sharp/blob/master/lesson3/homework/pr2/Program.cs) - принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
        - [pr3](https://github.com/crasher307/c-sharp/blob/master/lesson3/homework/pr3/Program.cs) - принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
	</details>

- <details><summary>Урок 4. Функции продолжение</summary>

	Напишите программу, которая:
    - [работа во время семинара](https://github.com/crasher307/c-sharp/tree/master/lesson4/work)
        - [pr1](https://github.com/crasher307/c-sharp/blob/master/lesson4/work/pr1/Program.cs) - принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
        - [pr2](https://github.com/crasher307/c-sharp/blob/master/lesson4/work/pr2/Program.cs) - принимает на вход число и выдаёт количество цифр в числе.
        - [pr3](https://github.com/crasher307/c-sharp/blob/master/lesson4/work/pr3/Program.cs) - принимает на вход число N и выдаёт произведение чисел от 1 до N.
        - [pr4](https://github.com/crasher307/c-sharp/blob/master/lesson4/work/pr4/Program.cs) - выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
    - [домашнее задание](https://github.com/crasher307/c-sharp/blob/master/lesson4/homework)
        - [pr1](https://github.com/crasher307/c-sharp/blob/master/lesson4/homework/pr1/Program.cs) - принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
        - [pr2](https://github.com/crasher307/c-sharp/blob/master/lesson4/homework/pr2/Program.cs) - принимает на вход число и выдаёт сумму цифр в числе.
        - [pr3](https://github.com/crasher307/c-sharp/blob/master/lesson4/homework/pr3/Program.cs) - задаёт массив из 8 элементов и выводит их на экран.
	</details>