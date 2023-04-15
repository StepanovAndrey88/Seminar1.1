// Задача 2: Напишите программу, которая на вход принимает 
// два числа и выдает, какое число большее, а какое меньшее.
// a = 5; b = 7 ->  max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите число «A»");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число «B»");
int B = Convert.ToInt32(Console.ReadLine());

if ( A>B)
{
    Console.WriteLine("Число «A» больше числа «B»");   
}
else if (B>A)
{
    Console.WriteLine("Число «B»  больше числа «A»");
}
else
{
    Console.WriteLine("Числа равны"); 
};

 
// Задача 4: Напишите программу, которая принимает на вход 
// три числа и выдает максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите число «A»");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число «B»");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число «С»");
int c = Convert.ToInt32(Console.ReadLine());
int m = a;
if (b>a)
{
    m=b;
}
if (c>b)
{
    m=c;
}
Console.WriteLine(m);
 


// Задача 6: Напишите программу, которая на вход принимает число и выдает, 
// является ли число четным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
if (a%2==0)
{
    Console.WriteLine("число является четным"); 
}
else
{
    Console.WriteLine("число является нечетным"); 
}
 
//  Задача 8: Напишите программу, которая на вход принимает число (N),
//  а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int Number1=1+1;

while(number>=Number1)
{
    if (Number1%2==0)
    {
        Console.WriteLine(Number1);
        Number1=Number1+2;
    }
    
}
}






