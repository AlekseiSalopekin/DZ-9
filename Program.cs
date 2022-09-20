
// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

Console.WriteLine("VVedite M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Vvedite N: ");
int N = Convert.ToInt32(Console.ReadLine());

string NumRange (int number1,int number2)
{
    if(number1<=number2) return $"{number1} "+ NumRange(number1+1,number2);
    else return string.Empty;
}
Console.WriteLine(NumRange(M,N));


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.WriteLine("VVedite M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Vvedite N: ");
int N = Convert.ToInt32(Console.ReadLine());
int sum = 0;
if(M < N)
{
    while(M <= N)
    {
        Console.Write(M + " ");
        sum += M;
        M++;
    }
    Console.WriteLine();
    Console.WriteLine("Сумма чисел: " + sum);
}
else
{
     while(N <= M)
    {
        Console.Write(N + " ");
        sum += N;
        N++;
    }
    Console.WriteLine();
    Console.WriteLine("Сумма чисел: " + sum);
}

// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
Console.Write("Vvedite chislo M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Vvedite chislo N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write(A(M, N));
int A(int M, int N)
{
    if (M == 0) return N + 1;
    if (M != 0 && N == 0) return A(M - 1, 1);
    if (M > 0 && N > 0) return A(M - 1, A(M, N - 1));
    return A(M,N);            
}
Console.WriteLine();

	