Console.WriteLine("Введите число соответствующее дню недели, где 1 это понедельник, a 7 это воскресенье");
int num = int.Parse(Console.ReadLine());
if (num >= 1 && num <= 5)
{
    Console.WriteLine("Данный день недели не является выходным");
}
else if (num == 6 || num == 7)
{
    Console.WriteLine("Ура Выходной!!!");
}
else
{
    Console.WriteLine("Вы введи неверное число");
}