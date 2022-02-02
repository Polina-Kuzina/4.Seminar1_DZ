// 8. Показать четные числа от 1 до N
Console.Write("Задайте значение N: ");
int N = int.Parse(Console.ReadLine());
int num = 1;
while(num <= N)
{
    int b = num % 2;
    if(b == 0)
{
    Console.WriteLine(num);
}
    num++;
}
