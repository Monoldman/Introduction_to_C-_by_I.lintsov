
// Задача №17. 
// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

Console.WriteLine("Введите число X");
int userNumberX = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число Y");
int userNumberY = Convert.ToInt32(Console.ReadLine());

if (userNumberX == 0 || userNumberY ==) Console.WriteLine("Введите числа, которые не равны 0 ");


else if (userNumberX > 0 && userNumberY > 0) Console.WriteLine("Ваши координаты расположены во второй четверти");
else if (userNumberX > 0 && userNumberY < 0) Console.WriteLine("Ваши координаты расположены в первой четверти");
else if (userNumberX < 0 && userNumberY < 0) Console.WriteLine("Ваши координаты расположены в третьей четверти");
else if (userNumberX > 0 && userNumberY> 0) Console.WriteLine("Ваши координаты расположены в четвертой четверти");



// else if (userNumber == 6 || userNumber == 7) Console.WriteLine("Это выходной день");
// else {Console.WriteLine("Это рабочий день");}