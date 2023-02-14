// See https://aka.ms/new-console-template for more information

// Начало работы:
// 1) создаем новую папку
// 2) открываем в СООТВЕТСТВУЮЩЕМ ТЕРМИНАЛЕ или через команду cd 
// 3)инициируем документ командой: dotnet new console
// 4) убеждаемся, что работает: dotnet run

// //Освоение простых команд:   
// 1) Закомментировать абзац command + /

// Console.Write(); вывод в одну строку
// Console.WriteLine(); вывод и переход на новую строку
// Console.ReadLine(); считать строку из терминала 

// Приветствие:
// Console.WriteLine("Введите ваше имя");
// string username = Console.ReadLine();
// Console.WriteLine("Привет, ");
// Console.WriteLine(username);


// Сложение двух чисел:
//  1) определяем перемнную и кладем в нее какое-значение, например 3:
//  numberA = 3;
//  2) говорим компьютеру, сколько памяти надо выделить и определяем тип числа, например целое число:
//  int numberB = 5;
//  3) запускаем алгоритм сложения 1:
// int numberA = 3;
// int numberB = 5;
// Console.WriteLine(numberA + numberB);
//  3) запускаем алгоритм сложения 2:
// int numberA = 3;
// int numberB = 5;
// int result = numberA + numberB;
// Console.WriteLine(result);

// Делените двух цлых чисел:
//  1) определяем перемннуые и кладем в них значения:
// int numberA = 12;
// int numberB = 5;
//  2) запускаем алгоритм деления:
// int numberA = 12;
// int numberB = 5;
// Console.WriteLine(numberA / numberB);

// // Делените двух вещественных чисел:
// double numberA = 12;
// double numberB = 5;
// Console.WriteLine(numberA / numberB);

// Использование генератора случайных чисел при сложении 
// int numberA = new Random() .Next(1, 10); //1234...9
// Console.WriteLine(numberA);
// int numberB = new Random() .Next(1, 10); 
// Console.WriteLine(numberB);
// int result = numberA + numberB;
// Console.WriteLine(result);


// Возведение в степень:
// Console.WriteLine("Введите число");
// string answer = Console.ReadLine();
// int number = Convert.ToInt32(answer);
// Console.WriteLine(number*number);


 // Приветствие, использование конструкции ветвления.
// Задание:
// Начало
// Ввести имя пользователя
// Если имя пользователя совпадает с Маша, приветствовать по-особенному (используем команду нижнего регистра)
// Иначе приветствовать по-обычному ("Привет ")
// Конец 

// Console.WriteLine("Введите имя пользователя:   ");
// string username = Console.ReadLine();

// if(username.ToLower() == "маша")

// {
//     Console.WriteLine("Ура! Это же Маша!");
// }
// else 
// {
// Console.Write ("Привет, "); 
// Console.WriteLine(username);
// }

// Для решения следующей задачи создаю новую докумпент: task1

// Решение задачи с гирями, которые нужно сравнить. 

int a = 1;
int b = 2;
int c = 6;
int d = 8;
int e = 4;

int max = a;

if  (a > max) max = a;
if  (b > max) max = b;
if  (c > max) max = c;
if  (d > max) max = d;
if  (e > max) max = e;

Console.Write("max = "); 
Console.WriteLine(max);



