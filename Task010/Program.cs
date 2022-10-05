// Задача 19:
// Напишите программу, которая принимает на вход пятизначное число
//  и проверяет, является ли оно палиндромом.


// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пяизначное число: ");
string num = Console.ReadLine();
int app = num.Length;

if (app == 5)
{
    if (num[0] == num[4] && num[1] == num[3])
    {
        Console.WriteLine($"{num} -> да");
    }
    else
    {
        Console.WriteLine($"{num} -> нет");
    }
}
else
{
    Console.WriteLine($"Это:  -> не пятизначное число!");
} 

