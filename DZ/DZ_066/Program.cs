// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Console.WriteLine("Введите первое число");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первое число");
int n = Convert.ToInt32(Console.ReadLine());

int summ = 0;
int Summanatural(int number1, int number2)
{

    if (number1 <= number2)
    {
        summ = number1 + Summanatural(number1 + 1, number2);

    }

    return summ;
}



Console.WriteLine($"Сумма натуральных чисел в диапазон от {m} до {n} будет {Summanatural(m, n)}");