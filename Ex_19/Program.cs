/* Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */

Console.WriteLine("Является ли число палиндромом?");
int size = 5;
Console.Write("Введите пятизначное число: ");
string number = Console.ReadLine();
if (number.Length < 1 || number.Length > size)
{
    Console.WriteLine("Введено некорректное число.");
}
else
{
    if (number[0] == number[size-1] && number[1] == number[size-2])
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }
}