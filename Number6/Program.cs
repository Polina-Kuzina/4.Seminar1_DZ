// 6. Выяснить является ли число чётным
Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());
int b = a % 2;
if(b == 0)
{
    Console.WriteLine("Это число четное");
}
else
{
    Console.WriteLine("Это число нечетное");
}

