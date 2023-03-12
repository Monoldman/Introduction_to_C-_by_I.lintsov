// Задача 34: 
// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// // //______________________________________метод ГЕНЕРАЦИИ МАССИВ А________________________________________________________

int ReadNumber(string messageToUser)
{
    Console.WriteLine(messageToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}


int[] GetRandomArray(int length, int leftRange, int rightRange)
{

    int[] array = new int[length];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(leftRange, rightRange + 1);
        
    }

    return array;
}

// // //_____________________ ФУНКЦИЯ, ПРИНИМАЮЩАЯ МАССИВ ____________________________________________________


int[] ReverseArray (int[] array)
{ 

    for (int i = 0; i < array.Length; i++)
    {
        array[i]  *= -1;
    }

    return array;
}

// // //____________________________ВЫЗЫВАЮЩИЙ КОД:______________________________________________________________________________

int length = ReadNumber("Задайте длину массива");
int leftRange = ReadNumber("Задайте левую границу массива");
int rightRange = ReadNumber("Задайте правую границу масиива");

int[] array = GetRandomArray(length, leftRange, rightRange);

Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine($"[{string.Join(", ", ReverseArray(array))}]");