// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();

string[] week = { "понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресение" };

Console.WriteLine("Введите номер дня недели");
int num = int.Parse(Console.ReadLine());

if (num > 7)
{
    Console.WriteLine("В неделе вроде 7 дней?");
}
else if (num > 5)
{
    Console.WriteLine($"Сегодня {week[num - 1]}, выходной!");
}
else
{
    Console.WriteLine($"Сегодня {week[num - 1]}, рабочий день :(");
}