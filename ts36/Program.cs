//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

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
    int unevenCount =0;
    

    for(int i = 0; i<array.Length;i++)
    {
        

        if (i % 2 != 0 ) 
        {unevenCount+=array[i];}
        
    }
    
   Console.WriteLine($"Sum of numbers on uneven positions is {unevenCount}");
}
int size =Input("Enter the array's size");
int minValue = 1;
int maxValue = 99999;

PrintArray(FillArray(size,minValue,maxValue));