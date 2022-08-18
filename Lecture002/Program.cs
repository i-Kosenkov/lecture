Console.Write("Введите первое значение: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе значение: ");
int y = Convert.ToInt32(Console.ReadLine());
if (y == x / y)
{
    Console.WriteLine("Первое значение является квадратом второго");
}
else
{
    Console.WriteLine("Первое значение не является квадратом второго");
}