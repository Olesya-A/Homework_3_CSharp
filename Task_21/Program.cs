// 21 Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты X Y Z точки a:");
string XYZa = Console.ReadLine()!;
string[] parts1 = XYZa.Split(',');
int Xa = int.Parse(parts1[0]);
int Ya = int.Parse(parts1[1]);
int Za = int.Parse(parts1[2]);

Console.WriteLine("Введите координаты X Y Z точки b:");
string XYZb = Console.ReadLine()!;
string[] parts2 = XYZb.Split(',');
int Xb = int.Parse(parts2[0]);
int Yb = int.Parse(parts2[1]);
int Zb = int.Parse(parts2[2]);

double distanseAB = Math.Sqrt(Math.Pow((Xb - Xa), 2) + Math.Pow((Yb - Ya), 2)+ Math.Pow((Zb - Za), 2));
Console.WriteLine(distanseAB - distanseAB % 0.01); 