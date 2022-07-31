
/* Задача 3: Напишите программу вычисления функции Аккермана
 с помощью рекурсии. Даны два неотрицательных числа m и n. 
m = 3, n = 2 -> A(m,n) = 29

*/


int numberFirst = Prompt ("Введите первое число "),
    numberSecond = Prompt ("Введите второе число ");

int sum = FunctionAkkerman(numberFirst, numberSecond);
System.Console.WriteLine(sum);


int FunctionAkkerman(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return FunctionAkkerman(m - 1, 1);
  else return FunctionAkkerman(m - 1, FunctionAkkerman(m, n - 1));
}

int Prompt(string message)
{
    Console.Write(message);
    int a = int.Parse(Console.ReadLine());
    return a;
}


