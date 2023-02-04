// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
int Akker (int number1, int number2){
    if (number1 ==0)
    return number2+1;
    else if (number1>0&&number2==0)
    return Akker(number1-1,1);
    else
    return Akker(number1-1,Akker(number1,number2-1));
}
Console.WriteLine("Введите первое число");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int n =Convert.ToInt32(Console.ReadLine());;
Console.WriteLine($"Результат выполнения функции Аккермана для числе {m} и {n} будет {Akker(m,n)}");