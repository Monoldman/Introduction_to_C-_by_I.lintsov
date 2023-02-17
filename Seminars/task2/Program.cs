// Seminar2 by I.Lintsov

// Работа с МАССИВАМИ

// int number = Random.Shared.Next(); 
// если в скобках не указать число, то массив будет от 0 до max от int; 
// посмотреть max можно через: 'int. MaxValue'
// посмотреть min можно через: 'int. MinValue'
 



// Задача 1 смеминар 2 условие:
// Напишите программу, которая выводит случайное число 
// из отрезка [10, 99] и показывает наибольшую цифру числа.
// Например:
// 78 -> 8
// 12-> 2
// 85 -> 8


// Задача 1 смеминар 2 решение:

// int number = Random.Shared.Next(10, 100);
// // в этом диапазоне будут только двузначные числа 
// //  при генерации случайных чисел метод Random.Shared.Next 
// //  включает 1е число и не включает последнее, 
// //  поэтому добавляем 1 если хотим его включить
//  Console.WriteLine(number);

// int lastDigit = number % 10;
// // Console.WriteLine(lastDigit);

// int firstDigit = number /   10;
// // Console.WriteLine(firstDigit);


// //  вывод решения +  ИНТЕРПОЛЯЦИЯ СТРОК: 
// //  Console.WriteLine($"min {firstDigit}, max {lastDigit}");
//  if(lastDigit > firstDigit)Console.WriteLine($"min {firstDigit}, max {lastDigit}");
// // {Console.WriteLine(firstDigit);}

// else Console.WriteLine($"min {lastDigit}, max {firstDigit}");
// // {Console.WriteLine(firstDigit);}






// Задача 11 смеминар 2 условие:
// Напишите программу, которая выводит случайное трехзначное число
//  и удаляет вторую цифру этого числа.
// Например:
// 456 -> 46
// 782 -> 72
// 918 -> 98


// Задача 11 смеминар 2 решение:

// int userNumber = Random.Shared.Next(100, 1000);
//  Console.WriteLine(userNumber);

// int userNumber1 = userNumber / 100;
// int userNumber3 = userNumber % 10;

// Console.WriteLine((userNumber1*10) + userNumber3);






// Задача 12 смеминар 2 условие:
// Напишите программу, которая будет принимать на вход два числа 
// и выводить, является ли второе число кратным первому. 
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// Например:
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно


// Задача 12 смеминар 2 решение:

// Console.WriteLine("Введите число");
// int userNumber1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите второе число");
// int userNumber2 = Convert.ToInt32(Console.ReadLine());

// if (userNumber1 % userNumber2 == 0)Console.WriteLine("Кратно");
// else {Console.WriteLine("нет, не кратно, остаток " + userNumber1 % userNumber2);}






// Задача 14 смеминар 2 условие:
// Напишите программу, которая принимает на вход число и проверяет, 
// кратно ли оно одновременно 7 и 23.
// 14 -> нет 
// 46 -> нет 
// 161 -> да


// Задача 14 смеминар 2 решение:
// Console.WriteLine("Введите число");
// int userNumber = Convert.ToInt32(Console.ReadLine());

// if (userNumber % 7 == 0 && userNumber % 23 == 0)Console.WriteLine("Да, Кратно");
// else {Console.WriteLine("нет, не кратно");}





// Задача 16 смеминар 2 условие:
// Напишите программу, которая принимает на вход два числа 
// и проверяет, является ли одно число квадратом другого.
// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет


// Задача 16 смеминар 2 решение:

// Console.WriteLine("Введите число");
// int userNumber1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите второе число");
// int userNumber2 = Convert.ToInt32(Console.ReadLine());

// if (userNumber1 / userNumber2 == userNumber2 || userNumber2 / userNumber1 == userNumber1)Console.WriteLine("Да, является");
// else {Console.WriteLine("нет, не является");}





// HOME WORK (Seminar2)

// Задача 10 смеминар 2 условие:
// Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает вторую цифру этого числа.
// Например:
// 456 -> 5
// 782 -> 8 
// 918 -> 1


// Задача 10 смеминар 2 решение:
// Console.WriteLine("Введите техзначное число");
// int userNumber = Convert.ToInt32(Console.ReadLine());

// if (userNumber < 100 || userNumber > 999 ) Console.WriteLine("Введите именно техзначное число");

// else {Console.WriteLine((userNumber%100)/10);}









