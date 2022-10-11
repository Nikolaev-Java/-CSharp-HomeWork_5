/* Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76 */


double[] arrReal = FillRandomArrayReal(5);
double diffOfMaxAndMin = 0;
double max = arrReal[0];
double min = arrReal[0];
for (int i = 1; i < arrReal.Length; i++)
{
	if (arrReal[i] > max)
	{
		max = arrReal[i];
	}
	else if (arrReal[i] < min)
	{
		min = arrReal[i];
	}
}
diffOfMaxAndMin = Math.Round(max - min, 2);
PrintArrayReal(arrReal);
Console.WriteLine($"Разница между максимальным элементом массива - {max} и минимальным - {min} равна = {diffOfMaxAndMin}");
//метод заполнения массива и вывода в консоль.

int[] FillRandomArray(int _l, int _start = 10, int _end = 100)
{
	int[] array = new int[_l];
	for (int i = 0; i < array.Length; i++)
	{
		array[i] = new Random().Next(_start, _end);
	}
	return array;
}
double[] FillRandomArrayReal(int _l)
{
	double[] array = new double[_l];
	for (int i = 0; i < array.Length; i++)
	{
		array[i] = Math.Round((new Random().NextDouble() * 100), 2);
	}
	return array;
}
void PrintArray(int[] arr)
{
	Console.Write("[");
	foreach (var item in arr)
	{
		Console.Write(item + " ");
	}
	Console.Write("]");
}
void PrintArrayReal(double[] arr)
{
	Console.Write("[");
	foreach (var item in arr)
	{
		Console.Write(item + " | ");
	}
	Console.Write("]\n");
}
