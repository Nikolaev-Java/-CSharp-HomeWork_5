/* Задача 34: Задайте массив заполненный случайными 
положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2 */

int[] arr = FillRandomArray(5, 100, 1000);

int countEvenNumber = 0;
foreach (var item in arr)
{
	if (item % 2 == 0)
		countEvenNumber++;
}
PrintArray(arr);
Console.WriteLine($"Количество четных чисел в массве - {countEvenNumber}");













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
void PrintArray(int[] arr)
{
	Console.Write("[");
	foreach (var item in arr)
	{
		Console.Write(item + " ");
	}
	Console.Write("]\n");
}

