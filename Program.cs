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

