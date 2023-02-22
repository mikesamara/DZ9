//Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.WriteLine("Введите начальное число M:");
int numberM = int.Parse(Console.ReadLine());

Console.WriteLine("Введите начальное число N:");
int numberN = int.Parse(Console.ReadLine());


void SumNumber (int numberM, int numberN, int sum)
{
    if (numberM > numberN) 
    {
        Console.WriteLine($"Сумма элементов в промежутке от M до N: {sum}"); 
        return;
    }
    sum = sum + (numberM++);
    SumNumber(numberM, numberN, sum);
}

SumNumber(numberM, numberN, 0);