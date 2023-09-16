// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// int FillNumber(string message){
//     Console.WriteLine($"Введите число {message} :");
//     int num = int.Parse(Console.ReadLine());
//     return num;
// }
// int GetPow(int num1, int num2){
//     int pow = num1;
//     for (int i = 1; i < num2; i++){
//         pow*=num1;
//     }
//     return pow;
// }


// int numA = FillNumber("A");
// int numB = FillNumber("B");

// Console.WriteLine($"Ответ : {GetPow(numA, numB)}");

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// int FillNumber(string message){
//     Console.WriteLine($"Введите число {message} :");
//     int num = int.Parse(Console.ReadLine());
//     return num;
// }

// int GetSumNumbers(int num){
//     int  result = 0;
//     for (int i = 0; i<=num ; i++){
//         int ostat = num % 10;
//         Console.WriteLine(ostat);
//         num = num/10;
//         result += ostat;
//     }
//     return result;
// }
// int number = FillNumber(" ");

// Console.WriteLine($"Ответ : {GetSumNumbers(number)}");

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


int size = 8;

int FillNumber(string message){
    Console.WriteLine($"Введите число {message}:");
    int num = int.Parse(Console.ReadLine());
    return num;
}

int [] GenerateMassive(int length, int min, int max){
    int[] array = new int[length];
    Random random = new Random();
    for (int i = 0; i < length; i++){
        array[i] = random.Next (min, max +1);
    }
    return array;
}

void PrintArray(int[] array){
    for (int i = 0; i < array.Length; i++){
        Console.Write($"{array[i]} ");
    }
}


int min = FillNumber("минимальное");
int max = FillNumber("максимальное");

int [] massive = GenerateMassive(size, min, max);

PrintArray(massive);