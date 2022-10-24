Знакомство с языками программирования (C#)
-----------------------------------------------

### Практическая часть (семинары)
1. Знакомство с языком программирования С#
	- [работа во время семинара](https://github.com/crasher307/c-sharp/tree/master/lesson1/work)
	- [домашнее задание](https://github.com/crasher307/c-sharp/tree/master/lesson1/homework)
2. Массивы и функции в программировании
	- [работа во время семинара](https://github.com/crasher307/c-sharp/tree/master/lesson2/work)
	- [домашнее задание](https://github.com/crasher307/c-sharp/tree/master/lesson2/homework)
3. Массивы и функции в программировании
	- [работа во время семинара](https://github.com/crasher307/c-sharp/tree/master/lesson3/work)
4. Функции продолжение
	- [работа во время семинара](https://github.com/crasher307/c-sharp/tree/master/lesson4/work)

<br>

#### Bash скрипты для создания/запуска проектов
- [create.sh](https://github.com/crasher307/c-sharp/blob/master/create.sh)
	- Создает и переходит в папку с новым проектом
	- Запускает создание проекта `dotnet new console`
	- Подключает библиотеку классов `dotnet add reference *` из `/func`
	- Запускает проект для проверки `dotnet run`
- [run.sh](https://github.com/crasher307/c-sharp/blob/master/run.sh)
	- Переходит в папку с проектом
	- Запускает проект `dotnet run`

<br>

#### Используемые ф-ции
- [baseFunc.*](https://github.com/crasher307/c-sharp/blob/master/func/baseFunc.cs)
- [rw.* (наследуется от baseFunc)](https://github.com/crasher307/c-sharp/blob/master/func/rw.cs)

<br>

```bash
# Парамеры для работы скриптов вводятся по ходу
sh create.sh # создание нового проекта
sh run.sh    # запуск проекта

# DotNet
dotnet new console                            # новый проект
dotnet new classlib                           # новая библиотека классов
dotnet add reference "<folder>/<file>.csproj" # подключить библиотеку
dotnet run                                    # запуск проекта
```