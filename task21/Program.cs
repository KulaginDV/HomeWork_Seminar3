/*
Задача 21
Напишите программу, которая принимает на вход координаты 
двух точек и находит расстояние между ними 
в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

int InputCoord (string coord)
{
    Console.Write(coord);
    return Convert.ToInt32(Console.ReadLine());
}

int x1 = InputCoord ("Input coordinate x1: ");
int y1 = InputCoord ("Input coordinate y1 ");
int z1 = InputCoord ("Input coordinate z1: ");
int x2 = InputCoord ("Input coordinate x2: ");
int y2 = InputCoord ("Input coordinate y2: ");
int z2 = InputCoord ("Input coordinate z2: ");

double distance = Math.Sqrt((x2-x1)*(x2-x1) + (y2-y1)*(y2-y1) + (z1-z2)*(z1-z2));
distance = Math.Round(distance, 2);
Console.WriteLine($"Distance between points {distance}");
