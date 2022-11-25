Знакомство с языками программирования (C#)
-----------------------------------------------

```bash
sh start.sh # запуск проекта (если проекта не существует - создает)

sh workRun.sh <lessonNumber> <projectNumber> # Запуск проекта из папки lesson<num>/work/pr<num>
sh homeRun.sh <lessonNumber> <projectNumber> # Запуск проекта из папки lesson<num>/homework/pr<num>

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

- <details><summary>Урок 5. Функции продолжение</summary>

	Напишите программу, которая:
    - [работа во время семинара](https://github.com/crasher307/c-sharp/tree/master/lesson5/work)
        - [pr1](https://github.com/crasher307/c-sharp/blob/master/lesson5/work/pr1/Program.cs) - задает массив из 12 случайных элементов [-9, 9], ищет сумму отриц. и положит. элементов массива.
        - [pr2](https://github.com/crasher307/c-sharp/blob/master/lesson5/work/pr2/Program.cs) - заменяет положительные на соответствующие отрицательные элементы массива, и наоборот.
        - [pr3](https://github.com/crasher307/c-sharp/blob/master/lesson5/work/pr3/Program.cs) - определяет, присутствует ли заданное число в заданном массиве.
        - [pr4](https://github.com/crasher307/c-sharp/blob/master/lesson5/work/pr4/Program.cs) - задает массив из 123 случайных чисел, ищет кол-во эл. массива, значения которых лежат в отрезке [10, 99].
        - [pr5](https://github.com/crasher307/c-sharp/blob/master/lesson5/work/pr5/Program.cs) - ищет произведение пар чисел в одномерном массиве. (парой считаем 1 и последний, 2 и предпоследний, ...), результат записывает в новый массив.
    - [домашнее задание](https://github.com/crasher307/c-sharp/blob/master/lesson5/homework)
        - [pr1](https://github.com/crasher307/c-sharp/blob/master/lesson5/homework/pr1/Program.cs) - задает массив случайных положит. трёхзнач. чисел, показывает кол-во чётных чисел в массиве.
        - [pr2](https://github.com/crasher307/c-sharp/blob/master/lesson5/homework/pr2/Program.cs) - задает массив случайных чисел, ищет сумму элементов, стоящих на нечётных позициях.
        - [pr3](https://github.com/crasher307/c-sharp/blob/master/lesson5/homework/pr3/Program.cs) - задает массив вещественных чисел, ищет разницу между максимальным и минимальным элементами массива.
	</details>

- <details><summary>Урок 6. Двумерные массивы и рекурсия</summary>

	Напишите программу, которая:
    - [работа во время семинара](https://github.com/crasher307/c-sharp/tree/master/lesson6/work)
        - [pr1](https://github.com/crasher307/c-sharp/blob/master/lesson6/work/pr1/Program.cs) - принимает на вход 3 числа и проверяет, может ли существовать треугольник со сторонами такой длины.
        - [pr2](https://github.com/crasher307/c-sharp/blob/master/lesson6/work/pr2/Program.cs) - будет преобразовывать десятичное число в двоичное.
        - [pr3](https://github.com/crasher307/c-sharp/blob/master/lesson6/work/pr3/Program.cs) - не используя рекурсию, выводит первые N чисел Фибоначчи.
        - [pr4](https://github.com/crasher307/c-sharp/blob/master/lesson6/work/pr4/Program.cs) - будет создавать копию заданного массива с помощью поэлементного копирования.
    - [домашнее задание](https://github.com/crasher307/c-sharp/blob/master/lesson6/homework)
        - [pr1](https://github.com/crasher307/c-sharp/blob/master/lesson6/homework/pr1/Program.cs) - принимает на вход N чисел, считает, сколько чисел больше 0 ввёл пользователь.
        - [pr2](https://github.com/crasher307/c-sharp/blob/master/lesson6/homework/pr2/Program.cs) - найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
	</details>

- <details><summary>Урок 7. Как не нужно писать код. Часть 1</summary>

	Напишите программу, которая:
    - [работа во время семинара](https://github.com/crasher307/c-sharp/tree/master/lesson7/work)
        - [pr1](https://github.com/crasher307/c-sharp/blob/master/lesson7/work/pr1/Program.cs) - задает двумерный массив размером m*n, заполненный случайными целыми числами.
        - [pr2](https://github.com/crasher307/c-sharp/blob/master/lesson7/work/pr2/Program.cs) - задает двумерный массив размера m*n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n.
        - [pr3](https://github.com/crasher307/c-sharp/blob/master/lesson7/work/pr3/Program.cs) - ищет элементы, у которых оба индекса чётные, и меняет эти элементы на их квадраты.
        - [pr4](https://github.com/crasher307/c-sharp/blob/master/lesson7/work/pr4/Program.cs) - ищет сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
    - [домашнее задание](https://github.com/crasher307/c-sharp/blob/master/lesson7/homework)
        - [pr1](https://github.com/crasher307/c-sharp/blob/master/lesson7/homework/pr1/Program.cs) - задает двумерный массив размером m*n, заполненный случайными вещественными числами.
        - [pr2](https://github.com/crasher307/c-sharp/blob/master/lesson7/homework/pr2/Program.cs) - на вход принимает позиции элемента в двумерном массиве, и возвращает значение/"элемента нет".
        - [pr3](https://github.com/crasher307/c-sharp/blob/master/lesson7/homework/pr3/Program.cs) - задает двумерный массив из целых чисел, ищет среднее арифметическое в каждом столбце.
	</details>

- <details><summary>Урок 8. Как не нужно писать код. Часть 2</summary>

	Напишите программу, которая:
    - [работа во время семинара](https://github.com/crasher307/c-sharp/tree/master/lesson8/work)
        - [pr1](https://github.com/crasher307/c-sharp/blob/master/lesson8/work/pr1/Program.cs) - поменяет местами первую и последнюю строку двумерного массива.
        - [pr2](https://github.com/crasher307/c-sharp/blob/master/lesson8/work/pr2/Program.cs) - заменяет строки на столбцы.
        - [pr3](https://github.com/crasher307/c-sharp/blob/master/lesson8/work/pr3/Program.cs) - составляет частотный словарь элементов двумерного массива.
        - [pr4](https://github.com/crasher307/c-sharp/blob/master/lesson8/work/pr4/Program.cs) - удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
    - [домашнее задание](https://github.com/crasher307/c-sharp/blob/master/lesson8/homework)
        - [pr1](https://github.com/crasher307/c-sharp/blob/master/lesson8/homework/pr1/Program.cs) - упорядочит по убыванию элементы каждой строки двумерного массива.
        - [pr2](https://github.com/crasher307/c-sharp/blob/master/lesson8/homework/pr2/Program.cs) - будет находить строку с наименьшей суммой элементов.
        - [pr3](https://github.com/crasher307/c-sharp/blob/master/lesson8/homework/pr3/Program.cs) - будет находить произведение двух матриц.
        - [pr4](https://github.com/crasher307/c-sharp/blob/master/lesson8/homework/pr4/Program.cs) - будет построчно выводить массив, добавляя индексы каждого элемента.
        - [pr5](https://github.com/crasher307/c-sharp/blob/master/lesson8/homework/pr5/Program.cs) - заполнит спирально массив 4 на 4.
	</details>