// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.WriteLine("Введите 5 значное число :");
// string strNum = Console.ReadLine();
// int num = int.Parse(strNum);

// int sum = 0;
// int result = num;

// while (num != 0) {
//     int r = num % 10;
//     sum = sum*10 + r;
//     num = num / 10;
// }
// if (result == sum) {
//     Console.WriteLine($"Число {result} является полиндромом");
// }else{
//     Console.WriteLine($"Число {result} не является полиндромом");
// }


// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125



// Console.WriteLine("Введите число N :");
// string strNum = Console.ReadLine();
// int N = int.Parse(strNum);
// int i = 1;
// while (i <= N) {

//     int num = i * i * i;
//     Console.WriteLine(num);
//     i+=1;
// }



// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// AB = sqrt(Az-Ay-Ax)^2 + (Bz-by-bx)^2

// Console.WriteLine("Введите число Ax :");
// int Ax = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите число Ay :");
// int Ay = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите число Az :");
// int Az = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите число Bx :");
// int Bx = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите число By :");
// int By = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите число Bz :");
// int Bz = int.Parse(Console.ReadLine());

// double result = Math.Sqrt(Math.Pow(Bx - Ax , 2) + Math.Pow(By - Ay, 2) + Math.Pow(Bz - Az, 2));

// Console.WriteLine($"Ответ {result}");



