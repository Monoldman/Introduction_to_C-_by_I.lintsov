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

int numberAB(int a, int b)
{
int count = 1;

for (int i = 0; i < b; i++)
    {
        count = count * a; //count *= a;  
    }
return count;

}
int a = ReadNumber("Введите число А");
int b = ReadNumber("Введите число B");    


 int result = numberAB(a, b);
 Console.WriteLine(result);


