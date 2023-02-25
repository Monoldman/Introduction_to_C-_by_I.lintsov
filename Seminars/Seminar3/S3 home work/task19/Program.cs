// Задача 19: 
// Напишите программу, которая принимает на вход 
// пятизначное число и проверяет, является ли оно палиндромом

Console.WriteLine("Введите пятизначное число");
int userNumber = Convert.ToInt32(Console.ReadLine());

if (userNumber < 10000 || userNumber > 99999 ) Console.WriteLine("Введите именно пятизначное число");

else if (userNumber/10000 == userNumber % 10 && userNumber/1000%10 == userNumber / 10 % 10) Console.WriteLine("Да, это число палиндром");

else {Console.WriteLine("Это число не палиндром");}


