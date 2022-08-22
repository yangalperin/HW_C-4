//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 

int size = 8;
int[] numbers = new int[size];
int count = 0;
FillArray(numbers);
PrintArray(numbers);
for (int i = 0; i < numbers.Length; i++)
if (numbers[i] % 2 == 0)
{
   count++;
}
Console.WriteLine("The number of even numbers is " + count);

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}





