﻿// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int FillNumber(string message){
    Console.WriteLine($"Введите число {message} :");
    int num = int.Parse(Console.ReadLine());
    return num;
}
int GetPow(int num1, int num2){
    int pow = num1;
    for (int i = 1; i < num2; i++){
        pow*=num1;
    }
    return pow;
}


int numA = FillNumber("A");
int numB = FillNumber("B");

Console.WriteLine($"Ответ : {GetPow(numA, numB)}");