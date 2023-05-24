/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76*/

/*По условиям задачи используем вещественные числа. Воспользуемся типом double. 
Метод NextDouble() генерирует случайные числа от 0 до 1, поэтому для получения 
двухзначных элементов массива умножим каждый на 100 при генерации. 
Затем округляем каждые элемент до целого числа.  
*/

double[] GetDoublesArray(int size)
{
    double[] doublesArray = new double[size];

    for (int i = 0; i < doublesArray.Length; i++)
    {
        doublesArray[i] = new Random().NextDouble() * 100;
        doublesArray[i] = Math.Round(doublesArray[i]);
        Console.Write($" {doublesArray[i]} ");
    }
    Console.WriteLine(); 
    return doublesArray;
}

void GetMaxMinDifference(double[] arr)
{

    double result = 0;
    double min = arr[0];
    double max = arr[0];

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max)
        { max = arr[i]; }
        else if (arr[i] < min)
        { min = arr[i]; }
        result = max - min;
    }
    Console.WriteLine($"Разница между max и min элементами массива равна {result}");
}

Console.WriteLine();
GetMaxMinDifference(GetDoublesArray(10));
Console.WriteLine();


