/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

//1. Метод создания и заполнения массива рандомайзером от 100 до 999;
//2. Метод с нахождением четных индексов и выводом в консоль результата. 

int[] GetThreeDigitNumbersArray(int size)
{
    int[] threeDigitsArray = new int[size];

    for (int i = 0; i < threeDigitsArray.Length; i++)
    {
        threeDigitsArray[i] = new Random().Next(100, 1000);
        Console.Write($" {threeDigitsArray[i]} ");
    }
    return threeDigitsArray;
}

void CountEvenElements(int[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            count++;
    }
    Console.WriteLine(); 

    if (count == 0)
    {
        Console.WriteLine("Чётных чисел в массиве нет");
    }
    else
        Console.WriteLine($"В массиве {count} чётных чисел");

}

Console.WriteLine();
CountEvenElements(GetThreeDigitNumbersArray(5));