﻿// HOME WORK (Seminar2)

// Задача 10 смеминар 2 условие:
// Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает вторую цифру этого числа.
// Например:
// 456 -> 5
// 782 -> 8 
// 918 -> 1


Console.WriteLine("Введите техзначное число");
int userNumber = Convert.ToInt32(Console.ReadLine());

if (userNumber < 100 || userNumber > 999 ) Console.WriteLine("Введите именно техзначное число");

else {Console.WriteLine((userNumber%100)/10);}