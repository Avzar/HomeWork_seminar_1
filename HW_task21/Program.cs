// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

// AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2

int getInt(){
    return Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Введите координаты точки A, B");
int x1 = getInt();
int y1 = getInt();
int x2 = getInt();
int y2 = getInt();
int z1 = getInt();
int z2 = getInt();
double d = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));
Console.WriteLine(d);