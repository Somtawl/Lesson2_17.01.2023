Console.WriteLine("Введите число ");
int num = int.Parse(Console.ReadLine());
if (num < 0 )
{
    num = -num;
}
Console.WriteLine(num);
string num1 = Convert.ToString(num);
if (num1.Length < 3)
{
    Console.WriteLine("Число не имеет третьего символа");
}
else
{
        Console.WriteLine("Третий символ {0}",num1[2]);
}