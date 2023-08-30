/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2

Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0

Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.
[3 7 22 2 78] -> 76
*/

int Input(string msg)
{
    Console.WriteLine(msg);
 int res = Convert.ToInt32(Console.ReadLine());
 return res;
}



int[] FillArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    Random rand = new Random();
    for(int i = 0;i<size;i++)
    {
        array[i]=rand.Next(minValue,maxValue+1);
    } return array;




}
void PrintArray(int[] array)
{
    for(int i=0;i<array.Length;i++)
    {
        Console.WriteLine(array[i]);
    }
    int evenCount =0;
    

    for(int i = 0; i<array.Length;i++)
    {
        

        if (array[i] % 2 ==0 ) 
        {evenCount++;}
        



    }
    
   Console.WriteLine($"Even numbers= {evenCount}; Uneven numbers = {array.Length - evenCount}");
}
int size =Input("Enter the array's size");
int minValue = 100;
int maxValue = 1000;

PrintArray(FillArray(size,minValue,maxValue));
// void EvenUnevencount(int[] array)
// {
//     int evenCount =0;
    

//     for(int i = 0; i<array.Length;i++)
//     {
        

//         if (array[i] % 2 ==0 ) 
//         {evenCount++;}
        



//     }
    
//    Console.WriteLine($"Even numbers= {evenCount}");
// }




// EvenUnevencount(FillArray(size,minValue,maxValue));

    

