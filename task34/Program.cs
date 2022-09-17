/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2*/

int size = 6;
int[] array = new int[size];
int count = 0;
for (int i = 0; i < array.Length; i++)
{
   array[i] = new Random().Next(100, 1000); 

Console.Write(array[i] + "\t");
if (array[i] % 2 ==0) count++;
    
}
Console.WriteLine();
Console.WriteLine($" Количество четных чисел в массиве равно: {count}");

/*int size = 5; // Размер нашего массива

int[] array = new int[size]; // Массив на size элементов: на 12 нулей
int resultPositive = 0; // Положительные числа
int resultNegative = 0; // Отрицательные числа
for (int i = 0; i < array.Length; i++) // array.Length = size, 
// размер массива равен количеству элементов
{
    array[i] = new Random().Next(-9, 10); // [-9,10)
    // Литералы строк
    Console.Write(array[i] + "\t"); // "\t" - Tab: "1    2    3    4"
    if (array[i] > 0) resultPositive += array[i]; // resultPositive = resultPositive + array[i]
    else  resultNegative += array[i];// <= 0
}
Console.WriteLine();
Console.WriteLine($"Positive: {resultPositive}, Negative: {resultNegative}");*/
