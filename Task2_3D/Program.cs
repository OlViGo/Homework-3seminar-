// Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
// Первый способ
// Console.Write("Введите x в точке A");
// int xa = int.Parse(Console.ReadLine());
// Console.Write("Введите x в точке B");
// int xb = int.Parse(Console.ReadLine());
// Console.Write("Введите y в точке A");
// int ya = int.Parse(Console.ReadLine());
// Console.Write("Введите y в точке B");
// int yb = int.Parse(Console.ReadLine());
// Console.Write("Введите z в точке A");
// int za = int.Parse(Console.ReadLine());
// Console.Write("Введите z в точке B");
// int zb = int.Parse(Console.ReadLine());
// int distance = (xa-xb)*(xa-xb) +(ya-yb)*(ya-yb)+(za-zb)*(za-zb);
// double result =Math.Sqrt(distance);
//  Console.WriteLine($"Растояние кординатами двух точек {result}");
// Второй способ
Console.Write("Введите x в точке A");
double xa = double.Parse(Console.ReadLine());
Console.Write("Введите x в точке B");
double xb = double.Parse(Console.ReadLine());
Console.Write("Введите y в точке A");
double ya = double.Parse(Console.ReadLine());
Console.Write("Введите y в точке B");
double yb = double.Parse(Console.ReadLine());
Console.Write("Введите z в точке A");
double za = double.Parse(Console.ReadLine());
Console.Write("Введите z в точке B");
double zb = double.Parse(Console.ReadLine());
double result = Math.Sqrt(Math.Pow((xa-xb),2)+(Math.Pow((ya-yb),2)+(Math.Pow((za-zb),2))));
Console.Write($"{result}" );

 