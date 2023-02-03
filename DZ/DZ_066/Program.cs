// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
int m = 1;
int n = 15;
int summ = 0;
int summanatural(int number1, int number2)
{

    if (number1 <= number2)
    {
        summ = number1 + summanatural(number1 + 1, number2);

    }

    return summ;
}



Console.WriteLine(summanatural(m, n));