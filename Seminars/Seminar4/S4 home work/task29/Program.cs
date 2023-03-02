// Задача 29: 
// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19] 
// 6, 1, 33 -> [6, 1, 33]


int number = 8;
int[] array = new int[number]; 

Random.Shared.Next(0,100); 


for (int i = 0; i < array.Length; i++)   
{
array[i] = Random.Shared.Next(0,100); 
Console.Write(array[i] + " "); 
}
    



// решение задачи через        VOID


// void FillRandomArray(int[] array)
// {
// for (int i = 0; i < array.Length; i++)
// {
//   array[i] = Random.Shared.Next(0,100);  
// }
// }
// int number = 8;
// int[] array = new int[number];

// FillRandomArray(array);
// Console.Write($"[{string.Join(", ", array)}]"); 