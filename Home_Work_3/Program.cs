/*Напишите программу, 
которая принимает на вход цифру, 
обозначающую день недели, и проверяет, 
является ли этот день выходным.

6 -> да
7 -> да
1 -> нет*/

Console.WriteLine("Введите цифру обозначающую день недели:");
string dayStr = Console.ReadLine();
int day = int.Parse(dayStr);

if (day > 0 && day < 8)
{
    if (day < 6)
    {
        Console.WriteLine("Это будний день!");
    }
    else
    {
        Console.WriteLine("Это выходной день!");
    }
}
else
{
    Console.WriteLine("Такого дня в неделе не существует!");
}