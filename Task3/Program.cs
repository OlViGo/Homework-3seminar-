// Задача 19
// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
// [0][1][2][3][4]
// 1   4  2  1  2 
Console.WriteLine("Введите число: ");
string num = Console.ReadLine();
int size = num.Length;
if (size == 5)
{
    if (num[0] == num[4] && num[1] == num[3])
    {
        Console.WriteLine($"{num} - Палиндром");
    }
    else
    {
        Console.WriteLine($"{num} -не является палиндромом");
    }
}
