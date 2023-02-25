// Задача №23.

//  Напишите программу, которая принимает на вход число (N) 
//  и выдаёт таблицу квадратов чисел от 1 до N.

// 5 -> 1, 4, 9, 16, 25
// 2 -> 1,4
 
Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
int index = 1;

while (index <= N) 
{
double oneToN = Math.Pow(index, 3);
index++;
Console.WriteLine(oneToN);
}
