/* Задача 1: Задайте значения M и N. Напишите программу,
которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
M = 1; N = 5 -> "2, 4"
M = 4; N = 8 -> "4, 6, 8
*/


int numberFirst =1,
    numberSecond = 5;
int result = numberSecond - numberFirst;

EvenNumber(result);

void EvenNumber(int result)
{
    if (result == 0)
    {
        return;
    }
    EvenNumber(result - 1);
    if (result % 2 == 0)
        System.Console.WriteLine(result);
}

int Prompt(string message)
{
    Console.Write(message);
    int a = int.Parse(Console.ReadLine());
    return a;
}

