// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
Console.WriteLine("Введите любое число");
int num = int.Parse(Console.ReadLine());
if (num < 100)
    {
    Console.WriteLine("В этом числе нет третьей цифры!");
    }
else
{
     while (num > 1000)
    {
        num = num/10;
    }
    Console.WriteLine($"{num % 10} Отлично!");
}
