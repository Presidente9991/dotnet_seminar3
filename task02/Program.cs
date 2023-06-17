/*
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

Console.WriteLine("Введите координату X для точки A: ");
int aX = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату Y для точки A: ");
int aY = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату X для точки A: ");
int aZ = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату X для точки B: ");
int bX = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату Y для точки B: ");
int bY = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату X для точки B: ");
int bZ = int.Parse(Console.ReadLine()!);

double distance = Math.Sqrt(Math.Pow((bX - aX), 2) + Math.Pow((bY - aY), 2) + Math.Pow((bZ - aZ), 2));

Console.WriteLine($"{distance:f2}");