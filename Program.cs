//Задача 1

int[] array = new int[10];

for(int i =0; i<array.Length; i++)
{
    array[i] = new Random().Next(1,101); 
    System.Console.Write(array[i]+ " ");
}
int count=0;

for(var i =0; i<array.Length; i++)
{
   if (array[i]>19 && array[i]<91)
    count=count+1;
}

System.Console.Write("Количество элементов "+count);

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
