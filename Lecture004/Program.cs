Console.Write("Ввведите значение: ");
int x = Convert.ToInt32(Console.ReadLine());
int y = 0 - x;
while (y <= x)
{
    Console.WriteLine(y);
    y++;
}