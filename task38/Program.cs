/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/

double[] array = new double[5]; 
Random rand = new Random();
for (int i = 0; i< array.Length; i++)
{
       array[i] = rand.NextDouble() * 10;
    Console.Write(array[i] + "\t");
    
}
double Min = array[0];
double Max = array[0];
for (int i = 0; i< array.Length; i++)
{
if (array[i]< Min) Min = array[i];

if (array[i]> Max) Max = array[i];
}
Console.WriteLine();

Console.WriteLine($"Разница между максимальным и минимальным элементами равна: {Math.Round((Max-Min),2)}");

