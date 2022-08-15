/* Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */

int coordinate(string coord, string point)
{
    Console.Write($"Введите координату {coord} точки {point}: ");
    return Convert.ToInt32(Console.ReadLine());
}
int x1 = coordinate("x", "a");
int y1 = coordinate("y", "a");
int z1 = coordinate("z", "a");
int x2 = coordinate("x", "b");
int y2 = coordinate("y", "b");
int z2 = coordinate("z", "b");
double calc(double x1, double x2, 
            double y1, double y2, 
            double z1, double z2)
{
  return Math.Sqrt(Math.Pow((x2-x1), 2) + 
                   Math.Pow((y2-y1), 2) + 
                   Math.Pow((z2-z1), 2));
}
double length =  Math.Round(calc(x1, x2, y1, y2, z1, z2), 2 );
Console.WriteLine($"Длина отрезка  {length}");