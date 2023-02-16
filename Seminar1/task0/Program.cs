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


//  Приветствие, использование конструкции ветвления.
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

// Решение задачи с гирями, которые нужно сравнить. 

// int a = 1;
// int b = 2;
// int c = 6;
// int d = 8;
// int e = 4;

// int max = a;

// if  (a > max) max = a;
// if  (b > max) max = b;
// if  (c > max) max = c;
// if  (d > max) max = d;
// if  (e > max) max = e;

// Console.Write("max = "); 
// Console.WriteLine(max);

// Оператор цикла 






// Seminar1 
// преподаватель    Иван Линцов

// Команда для gitignore которую создает git (удобно применят в новом файле):   dotnet new gitignore
// Команда с или: "||"
// Команда с  и:  "&&"
// Команда при отсутствии подсказок: если весь код синий и нет никаких подсказок:
// 1) command+Shift+P
// 2)OmniSharp --> Restart OmniSharp
// ЦИКЛ FOR разбор в задаче N 2.5 

 
 
// ЗАДАЧА 0 условия:
// Напишите программу, которая на вход принимает число 
// и выдаёт его квадрат (число умноженное на само себя).
// Например: 4 -> 16    -3 -> 9   -7 -> 49

// // ЗАДАЧА 0 решение:
// Console.WriteLine("Введите число"); 
// // Просто выводит в терминале запрос на ввод числа 
// string  answer = Console.ReadLine();
// // Запрос на ввод числа в терминале, но введутся только строки, не числа,  answer - уточнение
// int userNumber = Convert.ToInt32(answer);
// // Конвертация строки в число 
// Console.WriteLine(userNumber * userNumber);
//  // Операция с выводом в консоль
 
// Пояснения к команде "int userNumber = Convert.ToInt32(answer)": 
// 3 основых целочисленных типа:
// 1) short - 16 бит или 2 байта
// 2) int   - 32 бита или 4 байта 
// 3)long   - 64 бита или 8 байт


// КОНСТРУКЦИЯ if НЕ ЗАКРЫВАЕТСЯ ";" например:
// if (res > 100) 
// {
//   Console.WriteLine("Да");  
// }


// ЗАДАЧА 1 условие:
//  1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да 
// a = 2, b = 10 -> нет 
// a = 9, b = -3 -> да 
// a = -3, b = 9 -> нет
// 3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 	3 -> Среда 
// 5 -> Пятница


// // ЗАДАЧА 1 решение:
 
//  Console.WriteLine("Введите число"); 
// string answer1 = Console.ReadLine();
// int userNumber1 = Convert.ToInt32(answer1);

// Console.WriteLine("Введите второе число"); 
// string answer2 = Console.ReadLine();
// int userNumber2 = Convert.ToInt32(answer2);

// if ((userNumber2 * userNumber2) == userNumber1)
// {
//     Console.WriteLine("Да");  
// }
// else Console.WriteLine("Нет");  



// // ЗАДАЧА 3 условие:
// // 3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// // 	3 -> Среда 
// // 5 -> Пятница

// // // ЗАДАЧА 3 решение:

//  Console.WriteLine("Введите число от 1 до 7"); 
// int userNumber = Convert.ToInt32(Console.ReadLine());

// if (userNumber == 1){Console.WriteLine("понедельник");}
// else if (userNumber == 2){Console.WriteLine("вторник");}
// else if (userNumber == 3){Console.WriteLine("среда");}
// else if (userNumber == 4){Console.WriteLine("четверг");}
// else if (userNumber == 5){Console.WriteLine("пятница");}
// else if (userNumber == 6){Console.WriteLine("суббота");}
// else if (userNumber == 7){Console.WriteLine("воскресенье");}
// else {Console.WriteLine("Введите число только от 1 до 7");}
// else if (userNumber < 1 || userNumber >7){Console.WriteLine("Введите число только от 1 до 7");}
   



   // // ЗАДАЧА 2.5 условие:
// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"

// // // ЗАДАЧА 2.5 решение:
//  Console.WriteLine("Введите число"); 
// int userNumber = Convert.ToInt32(Console.ReadLine());
// for (int i = -userNumber; i <= userNumber; i++)
// Console.Write(i + " ");




// // ЗАДАЧА 2.7 условие:
// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает последнюю цифру этого числа: 
// 456 -> 6	
// 782 -> 2	
// 918 -> 8

// // // ЗАДАЧА 2.7 решение:
//  Console.WriteLine("Введите трехзначное число"); 
// int userNumber = Convert.ToInt32(Console.ReadLine());
// if (userNumber > 99 && userNumber <1000)Console.WriteLine(userNumber % 10);
// else {Console.WriteLine("Введите число только трёхзначное число");}



                                //   HOME WORK

// Задача 2 условие: 
// Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.
// Например: 
// a = 5; b = 7 ->  max = 7 min = 5
// a = 2 b = 10 -> max = 10 min = 2
// a = -9 b = -3 -> max = -3 min = 9


// // // ЗАДАЧА 2 решение:

// Console.WriteLine("Введите число"); 
// int userNumber1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число"); 
// int userNumber2 = Convert.ToInt32(Console.ReadLine());
// if (userNumber1 > userNumber2)Console.WriteLine("max = " + userNumber1 + " min = " + userNumber2);
// else {Console.WriteLine("max = " + userNumber2 + " min = " + userNumber1);}



// Задача 4 условие: 
// Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.
// Например:
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// // // ЗАДАЧА 4 решение:
//  Console.WriteLine("Вам нужно ввести три числа");
// Console.WriteLine("Введите первое число");
// int userNumber1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int userNumber2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите третье число");
// int userNumber3 = Convert.ToInt32(Console.ReadLine());
// if (userNumber1 > userNumber2 && userNumber1 > userNumber3){Console.WriteLine("максимальное число " + userNumber1);}
// else if (userNumber2 > userNumber1 && userNumber2 > userNumber3){Console.WriteLine("максимальное число " + userNumber2);}
// else {Console.WriteLine("максимальное число " + userNumber3);}




 
 // // // ЗАДАЧА 6 условие:
// Задача 6: Напишите программу, которая на вход принимает число 
// и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

// // // ЗАДАЧА 6 решение:

// Console.WriteLine("Введите число");
// int userNumber = Convert.ToInt32(Console.ReadLine());
// if (userNumber % 2 == 0)Console.WriteLine("да");
// else {Console.WriteLine("нет");}



 // // // ЗАДАЧА 8 условие:
// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
//  5 -> 2, 4
// 8 -> 2, 4, 6, 8

 // // // ЗАДАЧА 6 решение:
//  Console.WriteLine("Введите число"); 
// int userNumber = Convert.ToInt32(Console.ReadLine());
// for (int i = 1; i <= userNumber; i++)
// if (i % 2 == 0)Console.Write(i + " ");

