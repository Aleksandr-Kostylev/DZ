//Задача 1

// int[] array = new int[10];

// for(int i =0; i<array.Length; i++)
// {
//     array[i] = new Random().Next(1,101); 
//     System.Console.Write(array[i]+ " ");
// }
// int count=0;

// for(var i =0; i<array.Length; i++)
// {
//    if (array[i]>19 && array[i]<91)
//     count=count+1;
// }

// System.Console.Write("Количество элементов "+count);

//Задача 2: Задайте массив на 10 целых чисел.
//Напишите программу, которая определяет количество чётных чисел в массиве.
// int[] array1 = new int[10];

// for(int n =0; n<array1.Length; n++)
// {
//     array1[n] = new Random().Next(); 
//     System.Console.Write(array1[n]+ " ");
// }
// int count1=0;


// for(var n =0; n<array1.Length; n++)
// {
//    if (array1[n] %2==0 ) 
//     count1 = count1+1;
// }

// System.Console.Write("Количество четных элементов "+count1);

//Задача 3: Задайте массив из вещественных чисел с ненулевой дробной частью.
//Найдите разницу между максимальным и минимальным элементов массива.

Random rand = new Random();
double[] array = new double[5];

for (int i = 0; i < 5; i++)
{
    double num = rand.Next(1, 10) + rand.NextDouble();
    array[i] = num;
}
double max = array[0];
double min = array[0];

for (int i = 0; i < 5; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }

    if (array[i] < min)
    {
        min = array[i];
    }
Console.Write(array[i] + "   ");
}
double raz = max - min;

Console.WriteLine();
Console.WriteLine("max " + max);
Console.WriteLine("min " + min);
Console.WriteLine();
Console.WriteLine("Разница " + raz);