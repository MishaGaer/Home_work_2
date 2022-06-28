/*Задача 10: 
Напишите программу, 
которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

Console.WriteLine("Введите трехзначное число:");
string newNumber = Console.ReadLine();
int number = int.Parse(newNumber);
int numberMod = Math.Abs(number);

if (numberMod > 99 && number < 1000)
{
    int digit = numberMod / 10;
    Console.WriteLine($"Второй цифрой числа {newNumber} является {digit % 10}");
}
else
{
    Console.WriteLine("Пожалуйста, перезапустите программу и убедитесь что вводите трехзначное число!");
}