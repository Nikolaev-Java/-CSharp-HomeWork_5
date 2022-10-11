/* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0 */

int[] arr = FillRandomArray(7);
int summOddIndex = 0;
for (int i = 2; i < arr.Length; i += 2)
{
	summOddIndex += arr[i];
}
PrintArray(arr);
Console.WriteLine($"Сумма элементов массива, стоящих на нечетных позициях - {summOddIndex}");


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
