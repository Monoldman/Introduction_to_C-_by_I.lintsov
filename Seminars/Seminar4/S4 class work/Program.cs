// Семинар 4 

//                            цикл           WHILE
  
//   Console.WriteLine("Введите число");
// int n umber = Convert.ToInt32(Console.ReadLine());
// int i = 1;

// while (i <= number) 
// {
// Console.WriteLine(i * i);
// i++;
// }    


//                            цикл           FOR  

// удобнее, чем while, если есть счетчик


//   Console.WriteLine("Введите число");
// int Number = Convert.ToInt32(Console.ReadLine());
// for (int i = 1; i <= number; i++)
// {
// Console.WriteLine(i * i * i);

// }
 



// control+shift+P -> restartOmniSharp команда для правильнеой подсветки синтаксиса


// int.Parse(Console.ReadLine());   =   Convert.ToInt32(Console.ReadLine());


        // sum = sum + i;       =       sum += i;  


// Оптимизированный метод, который выдает сообщение пользователю, 
// принимает число и возвращает его, но при этом позволяет избегать дублирования:
// 
// int ReadNumber(string message) 
// {
//     Console.WriteLine(message);
//     int value = int.Parse(Console.ReadLine());
//     return value; 
    
// }






// Задача 24: 
// Напишите программу, которая принимает на вход число (А)
// и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36


// int ReadNumber(string message) 
// {
//     Console.WriteLine(message);
//     int value = int.Parse(Console.ReadLine());
//     return value; 
// }

// int numberA(int a)
// {
//     int sum = 0;
//     for (int i = 1; i <= a; i++)
//     {
//         sum = sum + i; //sum += i;  
//     }

//     return sum;
// }

// int number = ReadNumber("Введите число А");

//  int result = numberA(number);
//  Console.WriteLine(result);

  



// Задача 26 (в группах): 
// Напишите программу, которая принимает на вход число
// и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// Решение: 
// разбиваем на 2 подзадачи: 
// 1) "Напишите программу, которая принимает на вход число"
// 2) "... выдаёт количество цифр в числе".


// 1) принять на вход число:

// int ReadNumber(string messageToUser) 
// {
//     Console.WriteLine(messageToUser );
//     return Convert.ToInt32(Console.ReadLine());
// }

// int CountOfDigits (int number)

// {
//     int count;                                        //int count  = 0;
//     for (count = 0; number != 0; count++)

//     {
//             number /= 10;                             //number = number / 10; 
//     }
//     return count;
// }

// int userNumber = ReadNumber("Введите число");
// int result = CountOfDigits(userNumber);             //можно без этой строчики          
// Console.WriteLine(result);





// Задача 28: 
// Напишите программу, которая принимает на вход число N 
// и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

//  int ReadNumber(string message) 
// {
     
// }

// int xOfDigitsOneToA(int a)
// {
//     int count = 1;
//     for (int i = 1; i <= a; i++)
//     {
//         count = count * i; //sum *= i;  
//     }

//     return count;
// }

// int number = ReadNumber("Введите число А");

//  int result = xOfDigitsOneToA(number);
//  Console.WriteLine(result);



// Задача 30: 
// Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

//под массив нужно выделить память, поэтому используется команда new int[]; 
//если не выделить память, нельзя будет ничего записать в массив
// int[] array = new int[6]; 
//где есть массивы, есть и циклы 
// можно ввести длинну массива от пользователя:
// int number = 8;
// int[] array = new int[number]; 
//вводим рандом (как условие) указывая диапазон рандома, 
//например Random.Shared.Next(10,100); здесь от 10 до 99, 
//т.к. 100 не включительно
//Random.Shared.Next(0,2); //указывем диапазон от 0 до 1, 
//т.к. 1 не включительно, выставляем 2 
// for (int i = 0; i < array.Length; i++)   //for (int i = 0; i < number; i++) 
// {
//     array[i] = Random.Shared.Next(0,2); //указываем диапазон рандома
    // Console.WriteLine(array[i]);
   // Console.Write(array[i] + " "); //вывод в одно строчку:


//  вывод через преобразование в string:  
// Console.Write(string.Join("||||", array)); 

// другой вариант вывода: 
// Console.Write($"[{string.Join(", ", array)}]"); 





// решение задачи через                   VOID

 
// void FillRandomArray(int[] array)
// {
// for (int i = 0; i < array.Length; i++)
// {
//   array[i] = Random.Shared.Next(0,2);  
// }
// }
// int number = 8;
// int[] array = new int[number];

// FillRandomArray(array);
// Console.Write($"[{string.Join(", ", array)}]"); 


 
  
