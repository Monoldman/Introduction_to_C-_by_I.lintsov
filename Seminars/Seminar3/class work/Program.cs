﻿
// Задача №17. 
// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

// Console.WriteLine("Введите число X");
// int userNumberX = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число Y");
// int userNumberY = Convert.ToInt32(Console.ReadLine());

// if (userNumberX == 0 || userNumberY ==0) Console.WriteLine("Введите числа, которые не равны 0 ");


// else if (userNumberX > 0 && userNumberY > 0) Console.WriteLine("Ваши координаты расположены во второй четверти");
// else if (userNumberX > 0 && userNumberY < 0) Console.WriteLine("Ваши координаты расположены в первой четверти");
// else if (userNumberX < 0 && userNumberY < 0) Console.WriteLine("Ваши координаты расположены в третьей четверти");
// else if (userNumberX < 0 && userNumberY > 0) Console.WriteLine("Ваши координаты расположены в четвертой четверти");

//  else {Console.WriteLine("Невозможно определить координаты");}

//  Более краткий вариант записи задачи:

// Console.WriteLine("Введите число X");
// int X = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число Y");
// int Y = Convert.ToInt32(Console.ReadLine());
// if (X == 0 || Y ==0) Console.WriteLine("Введите числа, которые не равны 0 ");

// Console.WriteLine(
// X > 0 && Y > 0 ? "Ваши координаты расположены во второй четверти":
// X > 0 && Y < 0 ? "Ваши координаты расположены в первой четверти":
// X < 0 && Y < 0 ? "Ваши координаты расположены в третьей четверти":
// X < 0 && Y > 0 ? "Ваши координаты расположены в четвертой четверти":
// "Невозможно определить координаты"
// );


// Задача №18. 
// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).
// 1 -> “x > 0 && y > 0” 
// 2 -> “x < 0 && y > 0” 
// 3 -> “x < 0 && y < 0” 
// 4 -> “x > 0 && y < 0”
// 5 -> “Неверно введен номер четверти” 


//  


                                //  Math.Pow(a, b);   ВОЗВЕДЕНИЕ В СТЕПЕНЬ
                                //  Math.Sqrt(a);     КВАДРАТНЫЙ КОРЕНЬ
// double A = 3;
// double B = 2;
// // если я хочу ввести число С, которое будет результаом возведения числа A в степень B, используется Math

// double C = Math.Pow(A, B);

// // -  этот модуль принимает на вход число и степень, в которую нужно возвести: A -число **  B -степень
// // В  Math  можно вставлять целые выражения double C = Math.Pow(A*B, B); AxB ** B 



// Задача №21.
//  Напишите программу, которая принимает на вход координаты двух точек
//   и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21
//   Формула нахождения расстояния между 2 точками:  d = √ (X1 - X2)**2 + (Y1 - Y2)**2 

// Console.WriteLine("Введите координаты первой точки по оси X");
// double X1 = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Введите координаты второй точки по оси Y");
// double Y1 = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Введите координаты второй точки X");
// double X2 = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Введите координаты второй точки Y");
// double Y2 = Convert.ToDouble(Console.ReadLine());

// double d = Math.Sqrt(Math.Pow (X2 - X1, 2) + Math.Pow(Y2 - Y1, 2));
// Console.WriteLine(d);
 



// Задача №22.

//  Напишите программу, которая принимает на вход число (N) 
//  и выдаёт таблицу квадратов чисел от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.WriteLine("Введите число");
int userNumber = Convert.ToInt32(Console.ReadLine());

N = 