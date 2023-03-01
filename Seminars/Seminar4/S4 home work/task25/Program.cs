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

int numberA(int a);
int numberB(int b)
{
int count = 1;

for (int i = 1; i <= b; i++)
    {
        count = count * a; //sum *= i;  
    }
return count;

}
int number = ReadNumber("Введите число А");
int number = ReadNumber("Введите число B");    

 int result = numberA(number);
 Console.WriteLine(result);


