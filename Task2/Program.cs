// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

int NaturalSum(int A, int B)
{
    if(A>B)
    {
        return 0;
    }
    int sum =0;
    if(A>0 && B>0) // Проверка на натуральные число.
    {
        sum+=A;
    }
   return NaturalSum(A+1,B)+sum;
}

int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int A= Prompt("Enter A =>");
int B= Prompt("Enter B =>");
System.Console.WriteLine(NaturalSum(A,B));