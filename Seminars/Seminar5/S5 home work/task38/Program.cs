// Задача 38: 
// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// Для создания рандомного массива из вещественных чисел используется 
// метод NextDouble();  НО! этот метод не принимает никаких параметров
//  ему невозможно в скобках задать границы диапазона (1, 10) в которых 
//  будет генерироваться массив тк задается чило от 0.0 до 1.0.  
//  то есть будет интервал от 0.0 до 1.0, в который единица не включена.
//  Повлиять не это можно УМНОЖИВ интервал, например, на 100:
// NextDouble()*100; То обе границы увеличатся на 100. 

/*
int numberInt = Random.Shared.Next(1,10);
double numberDouble = Random.Shared.NextDouble() * 100;
System.Console.WriteLine(  numberDouble  );
 */

// Если есть задача увеличить диапазон, например от -20 до 80
// то будет какая запись: 
// double numberDouble = Random.Shared.NextDouble() * 100 -20;
// которая будет означать, что диапазон будет 
// от 0 - 20 до 100 - 20 те от -20 до 80.  

/*
int numberInt = Random.Shared.Next(1,10);
double numberDouble = Random.Shared.NextDouble() * 100 -20;
System.Console.WriteLine(  numberDouble  ); 
*/

// Чтобы обрезать ЗАПЯТАЯ КОЛИЧЕСТВО ЦИФР ПОСЛЕ ЗАПЯТОЙ
//  (-8.103378777326435), нужно: ($"{   numberDouble  :f2}");
// где 2 после f -  сколько цифр после зпятой
// При этом переменная не теряет после округления, тк здесь
// меняется только вывод

/*
int numberInt = Random.Shared.Next(1,10);
double numberDouble = Random.Shared.NextDouble() * 100 -20;
System.Console.WriteLine($"{numberDouble:f2}" );
*/

// Вывод массива Double через СТРОЧКУ:

/*
int numberInt = Random.Shared.Next(1,10);
double numberDouble = Random.Shared.NextDouble() * 100 -20;
double [] doubles = new double[] {2.33539583, 1.293535, 45.32253253};
Console.WriteLine($"{string.Join (", ", doubles.Select(x => Math.Round(x, 2)))}" );
*/


// Задача 38: 
// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

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


(int, int) MaxMin (int[] array)
{
    int resultMax = 0;
    int resultMin = 0;


    for (int i = 0; i < array.Length; i++)
    
    {
        if (array[i] > resultMax)
        {
            resultMax = array[i];
        }
        else if (array[i] < resultMin)
        {
        resultMin = array[i];
        }

    }   
           
    return (resultMax, resultMin);

}
 

int length = 10;
int leftRange = -20;
int rightRange = 20;
int[] myArray = GetRandomArray(length, leftRange, rightRange);


Console.WriteLine($"[{string.Join(", ", myArray)}]");//выводим МАССИВ ДО ИЗМEНЕНИЙ



(int max, int min) counts = MaxMin(myArray); //ДОПОЛНИТЕЛЬНАЯ ПЕРЕМЕННАЯ, которая запускает программу


Console.WriteLine($"[{string.Join(", ", counts)}]");// выводим МАССИВ ПОСЛЕ ИЗМЕНЕНИЙ





