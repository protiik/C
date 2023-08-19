// See https://aka.ms/new-console-template for more information


// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1


// Console.WriteLine("Введите число :");
// string strNum1 = Console.ReadLine();
// int num1 = int.Parse(strNum1);


// int result = num1 / 10;

// Console.WriteLine(result);

// int res2 = result%10;

// Console.WriteLine(res2);


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Не использовать массив
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число :");
string strNum1 = Console.ReadLine();
int num1 = int.Parse(strNum1);

int result = 0;
    if (num1 >= 100){
            while (num1 > 999) {
                num1 = num1 / 10;
            }
            result = num1 % 10;
            Console.WriteLine(result);
        }else{
            Console.WriteLine("Нет третьей цифры");
        }



// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// Console.WriteLine("Введите число :");
// string strNum1 = Console.ReadLine();
// int num1 = int.Parse(strNum1);

// if ((num1 == 1) || (num1 == 2) || (num1 == 3)  || (num1 == 4) || (num1 == 5)) {
//     Console.WriteLine("Нет");
// }else if ((num1 == 6) || (num1 == 7)) {
//     Console.WriteLine("Да");
// }else{
//     Console.WriteLine("Число не подходит под день недели");
// }

