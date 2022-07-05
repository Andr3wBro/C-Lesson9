// Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"


void CheckPow(int A, int B)
{

    if (A > B)
    {
        return;
    }
    if (A % 2 == 0) Console.Write($"{A}; ");
    CheckPow(A + 1, B);

}

int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}
int A= Prompt("Enter A =>");
int B= Prompt("Enter B =>");
CheckPow(A, B);