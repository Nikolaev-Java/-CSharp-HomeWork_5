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
	Console.Write("]");
}
