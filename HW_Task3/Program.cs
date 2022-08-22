//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.
//[3 7 22 2 78] -> 76
int size = 4;
double[] numbers = new double[size];
FillArray(numbers);
PrintArray(numbers);
double max = numbers[0];
double min = numbers[0];

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > max)
    {
        max = numbers[i];
    }

    else if (numbers[i] < min)
    {
        min = numbers[i];
    }
}
double Diff = (max - min)/10;

Console.WriteLine("разница между максимальным и минимальным элементами массива равна " + Diff);

void FillArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToDouble(new Random().Next(-80, 90));
    }
}
void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]/10 + " ");
    }
    Console.WriteLine();
}
