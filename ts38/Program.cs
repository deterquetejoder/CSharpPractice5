/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.
[3 7 22 2 78] -> 76*/

int Input(string msg)
{
    Console.WriteLine(msg);
 int res = Convert.ToInt32(Console.ReadLine());
 return res;
}

double InputDouble(string msg)
{
    Console.WriteLine(msg);
 double res = Convert.ToDouble(Console.ReadLine());
 return res;
}
int size =Input("Enter the array's size");
int minValue = Input("Enter minimal value ");
int maxValue = Input("Enter maximal value");

double[] FillArray(int size, int minValue, int maxValue)
{
    double[] array = new double[size];

    Random rand = new Random();
    for(int i = 0;i<size;i++)
    {
        array[i]=rand.NextDouble()+rand.Next(minValue,maxValue);
    } return array;
 }

void subtractMin(double[] array)
{
    Array.Sort(array);
    double sbtr = 0.0;
    for(int i=0;i<array.Length;i++)
    {
        Console.WriteLine(array[i]);
    }
    
    sbtr=array[array.Length-1]-array[0];
    System.Console.WriteLine($"The difference between minimum and maximum is: {sbtr}");


}





subtractMin(FillArray(size,minValue,maxValue));
// PrintArray(FillArray(size,minValue,maxValue));
