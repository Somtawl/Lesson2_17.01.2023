﻿Console.WriteLine("Введите число соответствующее дню недели, где 1 это понедельник, a 7 это воскресенье");
int num = int.Parse(Console.ReadLine());
string[] days = {"заглушка","Понедельник","Вторник","Среда","Четверг","Пятница","Суббота","Воскресенье"};
if (num >= 1 && num <= 7)
{
    Console.WriteLine("Цифра {0} соответсвует дню недели {1}",num,days[num]);
}
else
{
    Console.WriteLine("Вы ввели не верное число");
}
