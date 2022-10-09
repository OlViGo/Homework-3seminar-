// Напишите программу, которая принимает на вход число (N) и 
// выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
Console.Write("Введите число");
double N =double.Parse(Console.ReadLine());
double res =1;
while (res <= N)
{
double pow =Math.Pow(res,3);
Console.Write($"{pow} ,");
res ++;
}
// Console.Write("Введите число");
// int N = int.Parse(Console.ReadLine());
// int result =1;
// while(result <=N)
// {
// Console.Write((result*result*result) + ",");
// result ++; 
// }

