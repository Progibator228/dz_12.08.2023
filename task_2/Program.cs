// Задача 2: Напишите программу, которая на вход принимает два числа 
// и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите первое целое число");
int num1 = Convert.ToInt32 ( Console.ReadLine () );
Console.WriteLine("Введите второе целое число");
int num2 = Convert.ToInt32 ( Console.ReadLine () );

if(num1 > num2 )
{
    
    Console.Write($"Максимальное число {num1}");
}
if(num2 > num1 )
{
    
    Console.Write($"Максимальное число {num2}");
}
if(num2 == num1 )
{
    Console.WriteLine("Числа равны");
}