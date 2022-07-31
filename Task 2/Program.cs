/* Задача 2: Задайте значения M и N. Напишите программу,
которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
M = 1; N = 15 -> 120
M = 4; N = 8 -> 30
*/


int numberFirst = Prompt ("Введите первое число "),
    numberSecond = Prompt ("Введите второе число ");

int sum = Sum(numberFirst, numberSecond);
System.Console.WriteLine(sum);

int Sum(int number1, int number2)
{
    if (number1 > number2)
    {
        return number2;
    }
    else
        return Sum(number1, number2 - 1) + number2;
}

int Prompt(string message)
{
    Console.Write(message);
    int a = int.Parse(Console.ReadLine());
    return a;
}

