Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int num1 = 0;
while (num > 0)
{
    num1 += num % 10;
    num = num / 10;
}

Console.WriteLine(num1);
