/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет*/

Console.Write("Введите номер дня недели для определения выходной день или нет ");
int numberDay = Convert.ToInt32(Console.ReadLine());
if (numberDay >7) Console.WriteLine($"{numberDay} к счастью такого дня нет");
else
if (numberDay > 5)
{
    Console.WriteLine($"{numberDay} да");
}
else Console.WriteLine($"{numberDay} к сожалению нет");
