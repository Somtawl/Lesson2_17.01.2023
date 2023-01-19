Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());
if (num > 99)
{
    int numbers = (int)Math.Log10(num) - 2;
    int ZeroCount = 0;
    int divisor  = 1;
    while (ZeroCount < numbers)
    {
        divisor = divisor * 10;
        ZeroCount++;
    }
    int result = num / divisor % 10;
    Console.WriteLine("Третий символ число {0} равен {1}",num,result);
}
else
{
    Console.WriteLine("В числе {0} менее 3х символов",num);
}