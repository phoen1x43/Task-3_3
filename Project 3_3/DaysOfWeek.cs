using System;

namespace Task3_3;

public class DaysOfWeek : IPrinter
{
    public void Print()
    {
        Console.WriteLine("Понедельник, Вторник, Среда, Четверг, Пятница, Суббота, Воскресенье");
    }
}