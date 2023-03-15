// Конвертация числа в строку:
// int b = 12345;
// string a = b.ToString();




// Задача 31: 
// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива. Например, 
// в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, 
// сумма отрицательных равна -20.

//  int[] GetRandomArray(int Length, int LeftRange, int RightRange) // универсальный массив, с разной длинной и границами диапазона 
 
 

// //______________________________________метод ГЕНЕРАЦИИ МАССИВА________________________________________________________

//  int[] GetRandomArray() //если нужны разные массивы, можно задавать параметры: int[] GetRandomArray(int length, int leftRange, int rightRange)
//  {
// int length = 12;       //если указать в цикле, будет массив одинаковой длины    
// int leftRange = -9;
// int rightRange = 9;

// int[] array =  new int[length];

//   for (int i = 0; i < array.Length; i++) 
// {
//     array[i] = Random.Shared.Next(leftRange, rightRange +1);  //значение справа не входит в диапазон, поэтому +1
// }
// return array; 
//  }  
// //-------------------------------------------------------------------------------------------------------------------- 



// //_____________________НОВЫЙ МЕТОД подготовки суммы + и - элементов____________________________________________________


(int, int) SumPositiveAndNegativeElements(int[] array)  // КАРТЕЖ: вернется не 1, а 2 числа, т.е.  будут введены 2 числа 
{
    int sumPositive = 0;
    int sumNegative = 0;
    
     for (int i = 0; i < array.Length; i++)  //счетчик i виден только внутри цикла 
{
    if (array [i] > 0) 
    {
        sumPositive = sumPositive + array [i];
    }
    else if (array [i] < 0) 
    {
        sumNegative = sumNegative + array [i];
    }
}  
return (sumPositive, sumNegative);  //вернули картеж из двух переменных; return располагается внутри цикла и компелирует его
}
// //------------------------------------------------------------------------------------------------------------------------

// // если массив вводится пользователем: 
// // int lengthOfArray = ReadNumber("Задайте длину массива");
// // int leftBorder = ReadNumber("Задайте левую границу случайного диапазона");
// // int rightBorder = ReadNumber("Задайте правую границу случайного диапазона");

// // int[] myArray = GetRandomArray(lengthOfArray, leftBorder, rightBorder);


// // //____________________________ВЫЗЫВАЮЩИЙ КОД:______________________________________________________________________________

// // int[] myArray = GetRandomArray(); //если нужны разные массивы, здесь можно задавать параметры: int[] myArray = GetRandomArray(12);
// // //создаем массив, пока не указываем опциональных параметрв и ставим пустые скобки
// // // тк наш массив в скобках будет гинерироваться тотже: одинаковые: int Length = 12; int LeftRange = -9; int RightRange = 9;
// // //нужен вызов еще одного метода:  для работы с картежем:  так как возвращаются 2 целых числ а, мы должны подготовить 2 пременные,
// // //в которые мы эти 2 целых числ положим.
// // //моежно подключать несколько массивов: 
// // // int[] myArray = GetRandomArray(12, -9, 9); Но, лучше добалять дополнительыне int, чтобы значения были названы 
// // // int[] myArray = GetRandomArray(7, 0, 5);

// // Console.WriteLine($"[{string.Join(", ", myArray)}]"); //делает из строки массив  
// // (int sumP, int sumN) = SumPositiveAndNegativeElements(myArray); //(int sumP, _) выведет значение только первой переменной
// // Console.WriteLine($"Сумма положительных элементов = {sumP}"); 
// // Console.WriteLine($"Сумма отрицательных элементов = {sumN}");










// Задача 32: 
// Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, 
// и наоборот. [-4, -8, 8, 2] -> [4, 8, -8, -2]

// // //______________________________________метод ГЕНЕРАЦИИ МАССИВ А________________________________________________________

// int ReadNumber(string messageToUser)
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

// // //_____________________ ФУНКЦИЯ, ПРИНИМАЮЩАЯ МАССИВ ____________________________________________________


// int[] ReverseArray (int[] array)
// { 

//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i]  *= -1;
//     }

//     return array;
// }

// // //____________________________ВЫЗЫВАЮЩИЙ КОД:______________________________________________________________________________

// int length = ReadNumber("Задайте длину массива");
// int leftRange = ReadNumber("Задайте левую границу массива");
// int rightRange = ReadNumber("Задайте правую границу масиива");

// int[] array = GetRandomArray(length, leftRange, rightRange);

// Console.WriteLine($"[{string.Join(", ", array)}]");
// Console.WriteLine($"[{string.Join(", ", ReverseArray(array))}]");

//_______________________________________________________________________________________________________________________________



//Задача 32: Напишите программу замена элементов 
//массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2] 

//РЕШЕНИЕ ЧЕРЕЗ VOID




//ВЫЗЫВАЕМЫЙ  Метод генерации случайного массива с вводдом чисел ВЫЗЫВАЕТСЯ ЧЕРЕЗ:  GetRandomArray

int[] GetRandomArray(int length, int leftRange, int rightRange)
{

    int[] array = new int[length];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(leftRange, rightRange + 1);
    }

    return array;
}



// ПРОГРАММА/ФУНУЦИЯ ОБРАБАТЫВАЮШАЯ МАССИВ:
void InvertElements(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] *= -1; //каждый ЭЛЕМЕНТ, ЗНАЧЕНИЕ  массива перебирается и становится умноженными на "-1", меныя таким образом свой знак
    }                   // array[i] = -array[i]; другой вариант решения
}
 




//ВЫЗЫВАЮЩИЙ Метод генерации случайного массива с вводдом чисел ВЫЗЫВАЕТСЯ ЧЕРЕЗ:  GetRandomArray

int length = 12;
int leftRange = -9;
int rightRange = 9;
int[] myArray = GetRandomArray(length, leftRange, rightRange);


Console.WriteLine($"[{string.Join(", ", myArray)}]");//выводим МАССИВ ДО ИЗМПНЕНИЙ




InvertElements(myArray);  /* 1) Берется ПРОГРАММА ПО КОНВЕРТАЦИИ (преобразованию) МАССИВА: void InvertElements(int[] array) 
                             2) В нее ПОДСТАВЛЯЕТСЯ СГЕНЕРИРОВАННЫЙ МАССИВ: int[] myArray = GetRandomArray(lengthOfArray, leftBorder, rightBorder);     
                             3) МАССИВ ПРОГРАММА []<-- СГЕНЕРИРОВАННЫЙ МАССИВ =  1)InvertElements + 2)myArray   =   InvertElements(myArray);   */  


Console.WriteLine($"[{string.Join(", ", myArray)}]");// выводим МАССИВ ПОСЛЕ ИЗМЕНЕНИЙ




// Задача 33: 
// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да


// Незаконченное решение
// //______________________________________метод ГЕНЕРАЦИИ МАССИВ А________________________________________________________

// int ReadNumber(string messageToUser)
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

// // //_____________________ ФУНКЦИЯ, ПРИНИМАЮЩАЯ МАССИВ ____________________________________________________


// int[] Detector (int[] array, int number) // функция, которая принимает массив  и число 
// { 
//   temp = false; 
//     for (int i = 0; i < array.Length; i++)
//     { 
//         if (number == array [i])
//         {
//            temp = true;
//            Console.Write("Да");
//            break; 
//         }
//     }
// if (temp)
// {
//     Console.Write("Да");

// }
// else
// {
//        Console.Write("Нет"); 
 
// }
//     return array;
// }

// // //____________________________ВЫЗЫВАЮЩИЙ КОД:______________________________________________________________________________

// int length = ReadNumber("Задайте длину массива");
// int leftRange = ReadNumber("Задайте левую границу массива");
// int rightRange = ReadNumber("Задайте правую границу масиива");

// int[] array = GetRandomArray(length, leftRange, rightRange);

// int find = ReadNumber("Есть ли это число в массиве?");

 

// Console.WriteLine($"[{string.Join(", ", array)}]");
// Console.WriteLine($"[{string.Join(", ", ReverseArray(array))}]");



/*
// __________________________Решение преподавателя_____________________

int[] GetRandomArray(int length, int leftRange, int rightRange)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(leftRange, rightRange + 1);
    }

    return array;
}

//true - findNumber найден в array
//false - findNumber НЕ найден в array
bool IsElementInArray(int[] array, int findNumber)
{
    bool result = false;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] == findNumber) 
        {
            result = true;
            break;
        }
    }
    return result;
}

int lengthOfArray = 12;
int leftBorder = -9;
int rightBorder = 9;
int finding = 5;

int[] myArray = GetRandomArray(lengthOfArray, leftBorder, rightBorder);

Console.WriteLine($"[{string.Join(", ", myArray)}]");
bool res = IsElementInArray(myArray, finding);
Console.WriteLine(res);








//  Задача 37:
// Найдите произведение пар чисел в одномерном массиве. 
//   Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
//   Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21
  

 /* 
//   __________________ ЗАДАЕМ МАССИВ ___________________________________________________________
  int[] FillArray(int length, int leftnum = int.MinValue, int rightnum = int.MaxValue)
{
    int[] rand_arr = new int[length];
    for (int i = 0; i < rand_arr.Length; i++)
    {
        rand_arr[i] = Random.Shared.Next(leftnum, rightnum);
    }
    return rand_arr;
}

//   __________________ ОПРЕДЕЛЯЕМ ЧЕТНОСТЬ/НЕЧЕТНОСТЬ МАССИВА ___________________________________________________________

int[] LengthArray(int[] array)
{
    if(array.Length % 2 == 0) 
    {
        return new int[array.Length / 2];
    }
    else
    {
        return new int[array.Length / 2 + 1];
    }
}

//   __________________ ЗАДАЕМ НОВЫЙ МАССИВ НУЖНОЙ ДЛИНЫ, ПЕРМНОЖАЯ ПЕРВОЕ С ПОСЛЕДНИМ, ВТОРОЕ С ПРЕДПОСЛЕДНИМ И Т.Д._____________________

int[] MultiplyArray(int[] array)
{
    int[] result = LengthArray(array);
    for(int i = 0; i < array.Length / 2; i++)
    {
        result[i] = array[i] * array[array.Length - i -1];
    }
    if(array.Length % 2 != 0)
    {
        result[result.Length - 1] = array[array.Length / 2];
    }
    return result;
}

int[] filled_array = FillArray(5, -10, 10);

Console.WriteLine($"{string.Join(',', filled_array)} -> {string.Join(',', MultiplyArray(filled_array))}");
 System.Console.WriteLine();

*/







