
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


// та же задача,           АДАПТИРОВАННЫЙ короткий ВВОД ДАННЫХ:

// double ReadNumber(string messageToUser) 
// {
//     Console.WriteLine(messageToUser);
//     double value = double.Parse(Console.ReadLine());
//     return value;
// }

// double xa = ReadNumber("Введите координату точки A по X");
// double ya = ReadNumber("Введите координату точки A по X");
// double xb = ReadNumber("Введите координату точки B по X");
// double yb = ReadNumber("Введите координату точки B по X");

// double res = Math.Sqrt(Math.Pow(xa - xb, 2) + Math.Pow(ya - yb, 2));
// Console.WriteLine($"{res:f2}");
// команда выводит 2 знака после запятой, если ($"{res:f4}") будут 4 знака после запятой



  



// Задача №22.
// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

//   Console.WriteLine("Введите число");
// int N = Convert.ToInt32(Console.ReadLine());
// int index = 1;

// while (index <= N) 
// {
// double oneToN = Math.Pow(index, 2);
// index++;
// Console.WriteLine(oneToN);
// }

// Более короткий компактный синтаксис
// который начинает работать со строки int N = ReadNumber("Введите число"); 

int ReadNumber(string message) 
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
int N = ReadNumber("Введите число");
for (int i = 1; i <= N; i++)
{
   Console.WriteLine(i * i); 
} 
 







// Домашнее задание
 
// Задача №23.

//  Напишите программу, которая принимает на вход число (N) 
//  и выдаёт таблицу квадратов чисел от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4
 
// Console.WriteLine("Введите число");
// int N = Convert.ToInt32(Console.ReadLine());
// int index = 1;

// while (index <= N) 
// {
// double oneToN = Math.Pow(index, 3);
// index++;
// Console.WriteLine(oneToN);
// }

// Задача №19.
// Напишите программу, которая принимает на вход пятизначное число
//  и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да
