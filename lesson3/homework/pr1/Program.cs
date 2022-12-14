using func;

// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// -------------------------------------------------------------------

string num;
while ((num = rw.getInt("Введите 5ти значное число", true).ToString()).Length != 5) rw.echo("-- Попробуйте снова --");

char[] reverse = num.ToCharArray();
Array.Reverse(reverse);
bool res = num == new string(reverse);

rw.echo($"Число {num} " + (res ? "" : "не ") + "является палиндромом");

// -------------------------------------------------------------------