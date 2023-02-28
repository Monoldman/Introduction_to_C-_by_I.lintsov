// Задача 25: 
// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16




int ReadNumber(string message) 
{
    Console.WriteLine(message);
    int value = int.Parse(Console.ReadLine());
    return value; 
}

int userNumberA(int a)
int userNumberB(int b)

{
    int count = 0;
    for (int i = a; i <= b; i++)
    {
        count = Math.Pow(a, b); //sum += i;  
    }

    return count;
}

int number = userNumberA("Введите число А");

 int result = count(number);
 Console.WriteLine(result);