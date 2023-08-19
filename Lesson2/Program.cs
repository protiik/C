// See https://aka.ms/new-console-template for more information


// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1


Console.WriteLine("Введите число 1 :");
string strNum1 = Console.ReadLine();
int num1 = int.Parse(strNum1);


int result = num1 / 10;

Console.WriteLine(result);

int res2 = result%10;

Console.WriteLine(res2);

