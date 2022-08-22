//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int size = 4;
int[] numbers = new int[size];
int sumOdd = 0;


FillArray(numbers);
PrintArray(numbers);

for (int i = 0; i < numbers.Length; i++)
    if (i % 2 != 0)
    {
        sumOdd += numbers[i];
    }

Console.WriteLine("Сумма элементов, стоящих на нечётных позициях равна " + sumOdd);
void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9, 10);
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








