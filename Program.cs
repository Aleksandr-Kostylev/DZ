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
    Console.Write(array[i].ToString("F2") + " ");
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

}
double raz = max - min;

Console.WriteLine();
string smax = max.ToString("F2");
string smin = min.ToString("F2");
Console.WriteLine("max " + smax);
Console.WriteLine("min " + smin);
Console.WriteLine();
string result = raz.ToString("F2");
Console.WriteLine("Разница " + result);

//Задача 4**(не обязательно): Дано натуральное число в диапазоне от 1 до 100 000.
//Создайте массив, состоящий из цифр этого числа.
//Старший разряд числа должен располагаться на 0-м индексе массива, младший – на последнем.
//Размер массива должен быть равен количеству цифр.

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// int nums = 0;
// int tempNum = num;

// while (tempNum != 0)
// {
//     tempNum = tempNum / 10;
//     nums++;
// }
// int[] array = new int[nums];
// tempNum = num;

// if (num > 1 && num < 100000)
// {
//     for (int i = 0; i < nums; i++)
//     {
//         array[i] = tempNum %10;
//         tempNum = tempNum /10;
//         Console.Write(array[array.Length-1-i] +" ");
//     }
// }
// else
// {
//     Console.Write("Число не подходит");
// }

// Задайте массив из N случайных целых чисел (N вводится с
// клавиатуры).
// Найдите количество чисел, которые оканчиваются на 1 и
// делятся нацело на 7.
// Пример
// [1 5 11 21 81 4 0 91 2 3]
// => 2

// тип возвращающего значения + Название + ()+ {}


// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// int [] array = new int[num];

// void PrintArray()
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(10,101);
//         System.Console.Write(array[i] + " ");
//     }
// }


// int FindNumber()
// {
//     int countNumber=0;

//     for (int i = 0; i < array.Length; i++)
//     {
//         if(array[i] %10 == 1 && array[i] %7 ==0)
//         {
//             countNumber = countNumber+1;
//         }
//     }
//     return countNumber;
// }

// PrintArray();
// int newNum= FindNumber();

// System.Console.WriteLine("\n"+newNum);

// Заполните массив на N (вводится с консоли, не более 8)
// случайных целых чисел от 0 до 9.
// Сформируйте целое число, которое будет состоять из цифр из
// массива. Старший разряд числа находится на 0-м индексе,
// младший – на последнем.
// Пример
// [1 3 2 4 2 3] => 132423
// [2 3 1] => 231

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// int [] array = new int[num];

// void PrintArray()
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
// }

// int GetNumber()
// {
//     string numberPerson="";

//     for (int i = 0; i < array.Length; i++)
//     {
//        numberPerson = numberPerson + array[i];
//     }
    
//     return Convert.ToInt32(numberPerson);
// }

// PrintArray();
// int newNum= GetNumber();

// System.Console.WriteLine("\n"+newNum);

// Задайте одномерный массив, заполненный случайными
// числами. Определите количество простых чисел в этом
// массиве.
// Примеры
// [1 3 4 19 3] => 2
// [4 3 4 1 9 5 21 13] => 3


// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// int [] array = new int[num];

// void PrintArray()
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(10,100);
//         System.Console.Write(array[i]+ " ");
//     }
// }

// int GetNumber()
// {
//     int countNumber =0;

//     for (int i = 0; i < array.Length; i++)
//     {
//         bool isFind = false;

//        for (int j = 2; j < array[i]; j++)
//        {
//             if(array[i]%j ==0)
//             {
//                 isFind = true;
//             }
//        }

//        if(isFind==false)
//        {
//         countNumber = countNumber+1;
//        }
//     }
    
//     return countNumber;
// }

// PrintArray();

// System.Console.WriteLine(GetNumber());

