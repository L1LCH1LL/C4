void Array()
{
Console.Write("Введите длину массива: ");
int len = Convert.ToInt32(Console.ReadLine());

int[] list = new int[len];

for (int i = 0; i < len; i++)
{
list[i] = new Random().Next(0, len);
Console.WriteLine($"list[{i}] = {list[i]};");
}
}

Array();
