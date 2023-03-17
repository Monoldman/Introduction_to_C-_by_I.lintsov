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


int AllpositiveNumbers (int[] array)
{
    int result = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            result += 1;
        }
       
    }               
    return result;
}
 


// //ВЫЗЫВАЮЩИЙ Метод генерации случайного массива с вводдом чисел ВЫЗЫВАЕТСЯ ЧЕРЕЗ:  GetRandomArray

int length = 12;
int leftRange = 100;
int rightRange = 1000;
int[] myArray = GetRandomArray(length, leftRange, rightRange);

Console.WriteLine($"[{string.Join(", ", myArray)}]");//выводим МАССИВ ДО ИЗМEНЕНИЙ




AllpositiveNumbers(myArray);  /* 1) Берется ПРОГРАММА ПО КОНВЕРТАЦИИ (преобразованию) МАССИВА: void AllpositiveNumbers (int[] array) 
// //                              2) В нее ПОДСТАВЛЯЕТСЯ СГЕНЕРИРОВАННЫЙ МАССИВ: int[] myArray = GetRandomArray(lengthOfArray, leftBorder, rightBorder);     
// //                              3) МАССИВ ПРОГРАММА []<-- СГЕНЕРИРОВАННЫЙ МАССИВ =  1)InvertElements + 2)myArray   =   InvertElements(myArray);   */  
int counts = AllpositiveNumbers(myArray);

Console.WriteLine($"[{string.Join(", ", counts)}]");// выводим МАССИВ ПОСЛЕ ИЗМЕНЕНИЙ


//  не сохранили результат работы метода AllpositiveNumbers(myArray);
// Нужно сделать следующее
// int counts = AllpositiveNumbers(myArray);

// И выводить counts
// Сам массив метод не меняет, он же считает количество четных)