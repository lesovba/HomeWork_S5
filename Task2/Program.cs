/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6]-> 0*/

int[] GetArray(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < array.Length; i++)
    {
        array [i] = new Random().Next(1, 1000);
        Console.Write($" {array[i]} ");
    }
    Console.WriteLine();
    return array;
}

void FindOddIndexesElemSum(int[] arr)
{
    int sum = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 != 0)
           sum +=arr[i];  
    }
    Console.WriteLine($"Сумма элементов массива с нечётными индексами равна {sum}");
}

Console.WriteLine();
FindOddIndexesElemSum(GetArray(10)); 
Console.WriteLine(); 