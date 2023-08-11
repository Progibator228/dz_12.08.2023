// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
int [] array = new int [3];
int aL = array.Length;
int index = 0;
int max = 0;
while ( index < aL )
    {
        Console.WriteLine("Введите  целое число");
        array[index] = Convert.ToInt32 ( Console.ReadLine () );
        if (array[index] > max )
            {
                max = array[index];
            }
        index++; 
    }
Console.WriteLine($"Максимальное число  {max}");