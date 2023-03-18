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

