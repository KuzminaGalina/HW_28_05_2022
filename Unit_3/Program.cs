// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

void printArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i != array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}

int[] fillArray(int length)
{
    int[] result = new int[length];
    for (int i = 0; i < length; i++)
    {
      result[i] = new Random().Next(1, 10);
    }
return result;
}
Console.WriteLine("Введите размер массива:  ");
int lengthArray = Convert.ToInt32(Console.ReadLine());
int[] Array = fillArray(lengthArray);
printArray(Array);