Console.WriteLine("Введите трехзначное число ");
int num = int.Parse(Console.ReadLine());
string num1 = Convert.ToString(num);
if (num1.Length != 3)
{
    Console.WriteLine("Неверное количество символов");
}
else
{
    Console.WriteLine("Вторая цифра {0}",num1[1]);
}
