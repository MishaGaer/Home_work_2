/*Задача 13: 
Напишите программу, 
которая выводит третью цифру заданного числа или сообщает, 
что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6*/

Console.WriteLine("Введите число:");
string numberStr = Console.ReadLine();
int number = int.Parse(numberStr);

if (number > 99)
{
while (number > 999)
{
    number = number / 10;
}
Console.WriteLine($"Третьей цифрой числа {numberStr} является {number % 10}.");
}
else
{
    Console.WriteLine("В заданном числе нет третьей цифры!");
}