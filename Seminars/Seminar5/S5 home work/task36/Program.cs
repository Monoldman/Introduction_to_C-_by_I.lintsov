// Задача 36: 
// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


// // Найдите сумму отрицательных и положительных элементов массива. Например, 
// // в массиве в 

//  int ReadNumber(string messageToUser)
// {
//     Console.WriteLine(messageToUser);
//     int value = Convert.ToInt32(Console.ReadLine());
//     return value;
// }


// int[] GetRandomArray(int length, int leftRange, int rightRange)
// {

//     int[] array = new int[length];

//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = Random.Shared.Next(leftRange, rightRange + 1);
//     }

//     return array;
// }

// (int) SumPositivelements(int[] array)
// {
//     int sumPositive = 0; //сумма положительных чисел
//     // int sumNegative = 0; //сумма отрицательных чисел

//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 0) // если наш элементо положительный
//         {
//             sumPositive = sumPositive + array[i];
//             //sumPositive += array[i];
//         }
//         // else if (array[i] < 0)
//         // {
//         //     sumNegative = sumNegative + array[i];
//         // }
//     }

//     return (sumPositive); //, sumNegative);
// }

// int lengthOfArray = 12;
// int leftBorder = -9;
// int rightBorder = 9;

// int[] myArray = GetRandomArray(lengthOfArray, leftBorder, rightBorder);

// Console.WriteLine($"[{string.Join(", ", myArray)}]");
// (int sumP) = SumPositiveAndNegativeElements(myArray);
// Console.WriteLine($"Сумма положительных элементов = {sumP}");
// Console.WriteLine($"Сумма отрицательных элементов = {sumN}");











// Задача 36: 
// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// Найдите произведение пар чисел в одномерном массиве. 
//   Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
//   Результат запишите в новом массиве.


//  int[] FillArray(int length, int leftnum = int.MinValue, int rightnum = int.MaxValue)
// {
//     int[] rand_arr = new int[length];
//     for (int i = 0; i < rand_arr.Length; i++)
//     {
//         rand_arr[i] = Random.Shared.Next(leftnum, rightnum);
//     }
//     return rand_arr;
// }

// //   __________________ ОПРЕДЕЛЯЕМ ЧЕТНОСТЬ/НЕЧЕТНОСТЬ МАССИВА ___________________________________________________________

// int[] LengthArray(int[] array)
// {
//     if(array.Length % 2 == 0) 
//     {
//         return new int[array.Length / 2];
//     }
//     else
//     {
//         return new int[array.Length / 2 + 1];
//     }
// }

// //   __________________ ЗАДАЕМ НОВЫЙ МАССИВ НУЖНОЙ ДЛИНЫ, ПЕРМНОЖАЯ ПЕРВОЕ С ПОСЛЕДНИМ, ВТОРОЕ С ПРЕДПОСЛЕДНИМ И Т.Д._____________________

// int[] MultiplyArray(int[] array)
// {
//     int[] result = LengthArray(array);
//     for(int i = 0; i < array.Length / 2; i++)
//     {
//         result[i] = array[i] + array[array.Length - i -1];
//     }
//     // if(array.Length % 2 != 0)
//     // {
//     //     result[result.Length - 1] = array[array.Length / 2];
//     // }
//     return result;
// }

// int[] filled_array = FillArray(5, -10, 10);

// Console.WriteLine($"{string.Join(',', filled_array)} -> {string.Join(',', MultiplyArray(filled_array))}");
 





// //Задача 32: Напишите программу замена элементов 
// //массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// //[-4, -8, 8, 2] -> [4, 8, -8, -2] 


// //ВЫЗЫВАЕМЫЙ  Метод генерации случайного массива с вводдом чисел ВЫЗЫВАЕТСЯ ЧЕРЕЗ:  GetRandomArray

// int[] GetRandomArray(int length, int leftRange, int rightRange)
// {

//     int[] array = new int[length];

//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = Random.Shared.Next(leftRange, rightRange + 1);
//     }

//     return array;
// }



// // ПРОГРАММА/ФУНУЦИЯ ОБРАБАТЫВАЮШАЯ МАССИВ:
// void InvertElements(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         array[i] *= -1; //каждый ЭЛЕМЕНТ, ЗНАЧЕНИЕ  массива перебирается и становится умноженными на "-1", меныя таким образом свой знак
//     } 
// }
 




// //ВЫЗЫВАЮЩИЙ Метод генерации случайного массива с вводдом чисел ВЫЗЫВАЕТСЯ ЧЕРЕЗ:  GetRandomArray

// int length = 12;
// int leftRange = -9;
// int rightRange = 9;
// int[] myArray = GetRandomArray(length, leftRange, rightRange);


// Console.WriteLine($"[{string.Join(", ", myArray)}]");//выводим МАССИВ ДО ИЗМПНЕНИЙ




// InvertElements(myArray);  /* 1) Берется ПРОГРАММА ПО КОНВЕРТАЦИИ (преобразованию) МАССИВА: void InvertElements(int[] array) 
//                              2) В нее ПОДСТАВЛЯЕТСЯ СГЕНЕРИРОВАННЫЙ МАССИВ: int[] myArray = GetRandomArray(lengthOfArray, leftBorder, rightBorder);     
//                              3) МАССИВ ПРОГРАММА []<-- СГЕНЕРИРОВАННЫЙ МАССИВ =  1)InvertElements + 2)myArray   =   InvertElements(myArray);   */  


// Console.WriteLine($"[{string.Join(", ", myArray)}]");// выводим МАССИВ ПОСЛЕ ИЗМЕНЕНИЙ









// //Задача 32: Напишите программу замена элементов 
// //массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// //[-4, -8, 8, 2] -> [4, 8, -8, -2] 





// //ВЫЗЫВАЕМЫЙ  Метод генерации случайного массива с вводдом чисел ВЫЗЫВАЕТСЯ ЧЕРЕЗ:  GetRandomArray

// int[] GetRandomArray(int length, int left, int right)
// {

//     int[] array = new int[length];

//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = Random.Shared.Next(left, right + 1);
//     }

//     return array;
// }






// // ПРОГРАММА/ФУНУЦИЯ ОБРАБАТЫВАЮШАЯ МАССИВ:

// int[] MultiplyArray(int[] array)
// {
//     int sumP = 0;
//     for(int i = 1; i < array.Length; i++)
//     {
//        sumP = sumP + array[i]; // array [i] - значение под индексом i   
//        //array [i] += array [i]; //каждый ЭЛЕМЕНТ, ЗНАЧЕНИЕ  массива перебирается и становится умноженными на "-1", меныя таким образом свой знак
       
//     } 
    
//     return (sumP);
// } 
  
 


// /
// //ВЫЗЫВАЮЩИЙ Метод генерации случайного массива с вводдом чисел ВЫЗЫВАЕТСЯ ЧЕРЕЗ:  GetRandomArray

// int length = 8;
// int left = -9;
// int right = 9;
// int[] myArray = GetRandomArray(length, left, right);


// Console.WriteLine($"[{string.Join(", ", myArray)}]");//выводим МАССИВ ДО ИЗМПНЕНИЙ



// // ПРОГРАММА/ФУНУЦИЯ ОБРАБАТЫВАЮШАЯ УЖЕ МОЙ   МАССИВ:

// MultiplyArray(myArray);  /* 1) Берется ПРОГРАММА ПО КОНВЕРТАЦИИ (преобразованию) МАССИВА: void InvertElements(int[] array) 
//                              2) В нее ПОДСТАВЛЯЕТСЯ СГЕНЕРИРОВАННЫЙ МАССИВ: int[] myArray = GetRandomArray(lengthOfArray, leftBorder, rightBorder);     
//                              3) МАССИВ ПРОГРАММА []<-- СГЕНЕРИРОВАННЫЙ МАССИВ =  1)InvertElements + 2)myArray   =   InvertElements(myArray);   */  


// Console.WriteLine($"[{string.Join(", ", myArray)}]");

// /* выводим МАССИВ ПОСЛЕ ИЗМЕНЕНИЙ, 
// string.Join - позволяет выводить массив одной строкой; Join - разбивает на элементы 
// (", ", ...   - пказывает, как будут разделяться элементы в строке
// ....myArray) - массив, который мы слеплеваем в строчку 
// $"[{...}]"   - заключает результат в квадратные скобки  
// */
// // Console.WriteLine(myArray.Where(i => i % 2 != 0).Sum()); Метод генерации суммы нечетных элементов 


 
 








// Задача 36: 
// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


 // Задача 34: 
// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2






//ВЫЗЫВАЕМЫЙ  Метод генерации случайного массива с вводдом чисел ВЫЗЫВАЕТСЯ ЧЕРЕЗ:  GetRandomArray

int[] GetRandomArray(int length, int leftRange, int rightRange)
{
    int[] array = new int [length];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(leftRange, rightRange);
        
    }
  
    return array;
}



// ПРОГРАММА/ФУНУЦИЯ ОБРАБАТЫВАЮШАЯ МАССИВ:


int AlloddNumbers (int[] array)
{
    int result = 0;

    for (int i = 1; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            result += array[i];
        }
       
    }               
    return result;
}
 


// //ВЫЗЫВАЮЩИЙ Метод генерации случайного массива с вводдом чисел ВЫЗЫВАЕТСЯ ЧЕРЕЗ:  GetRandomArray

int length = 10;
int leftRange = 10;
int rightRange = 10;
int[] myArray = GetRandomArray(length, leftRange, rightRange);

Console.WriteLine($"[{string.Join(", ", myArray)}]");//выводим МАССИВ ДО ИЗМEНЕНИЙ




AlloddNumbers(myArray);  /* 1) Берется ПРОГРАММА ПО КОНВЕРТАЦИИ (преобразованию) МАССИВА: void AllpositiveNumbers (int[] array) 
// //                              2) В нее ПОДСТАВЛЯЕТСЯ СГЕНЕРИРОВАННЫЙ МАССИВ: int[] myArray = GetRandomArray(lengthOfArray, leftBorder, rightBorder);     
// //                              3) МАССИВ ПРОГРАММА []<-- СГЕНЕРИРОВАННЫЙ МАССИВ =  1)InvertElements + 2)myArray   =   InvertElements(myArray);   */  


Console.WriteLine($"[{string.Join(", ", myArray)}]");// выводим МАССИВ ПОСЛЕ ИЗМЕНЕНИЙ


