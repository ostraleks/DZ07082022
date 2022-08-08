/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6

Console.Write("Введите число ");
string inputNumber = Console.ReadLine();
int length = inputNumber.Length;
if (length>2)
{
    Console.WriteLine($"Третья цифра: {inputNumber[2]}");
}
else Console.WriteLine($"Третьей цифры нет");*/

Console.Write("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100) Console.WriteLine("Третьей цифры нет");
else
if (number > 99 && number < 1000) Console.WriteLine($"Третья цифра  {number % 100 % 10}");
else
{
    while (number >= 1000)
{
    number = number / 10;
}
Console.WriteLine($"Третья цифра  {number % 100 % 10}");
}

