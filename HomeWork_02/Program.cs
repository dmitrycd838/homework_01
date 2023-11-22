System.Console.Write("Введите координаты точки X и Y через пробел: ");
string[]coordinates = Console.ReadLine().Split(' ');
int x = Convert.ToInt32(coordinates[0]);
int y = Convert.ToInt32(coordinates[1]);

if (x > 0 && y > 0)
{
    Console.WriteLine("Точка находится в плоскости 1");
}
else if (x < 0 && y > 0)
{
    System.Console.WriteLine("Точка находится в плоскости 2");
}
else if (x > 0 && y < 0)
{
    System.Console.WriteLine("Точка находится в плоскости 3");
}
else if (x < 0 && y < 0)
{
    System.Console.WriteLine("Точка находится в плоскости 4");
}
else
{
    System.Console.WriteLine("Точка находится на оси координат");
}