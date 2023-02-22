
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

Console.WriteLine("Введите число X");
int X = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число Y");
int Y = Convert.ToInt32(Console.ReadLine());
if (X == 0 || Y ==0) Console.WriteLine("Введите числа, которые не равны 0 ");

Console.WriteLine(
X > 0 && Y > 0 ? "Ваши координаты расположены во второй четверти":
X > 0 && Y < 0 ? "Ваши координаты расположены в первой четверти":
X < 0 && Y < 0 ? "Ваши координаты расположены в третьей четверти":
X < 0 && Y > 0 ? "Ваши координаты расположены в четвертой четверти":
"Невозможно определить координаты"
);
