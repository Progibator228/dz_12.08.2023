// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число");
int num1 = Convert.ToInt32 ( Console.ReadLine () );
int i = 0;
int count = 0;
while ( i < num1)
    {
        if (num1 < 0 ) 
            {
                Console.WriteLine("$Число отрицательное");
                break;
            }
        if ( num1 % 2 == 0 )
            {
                count = count + 2;
                Console.WriteLine(count);
                i = i + 2;
            }
        else 
            {
                num1 = num1 - 1 ;
                i = i + 1;
            }
    }