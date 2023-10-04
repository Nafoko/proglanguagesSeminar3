// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// int[] randomArray = new int[8];

// for (int i = 0; i < 8; i++)
// {
// randomArray[i] = new Random().Next(1,99);
// Console.Write(randomArray[i] + );
// }


int[] CreatArray(int size)
{
    int[] array = new int[size];
    Random rnd = new Random(); //Создается объект чтобы внутри цикла вызвать метод Next
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(1,100);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int[] arr = CreatArray(8);
PrintArray(arr);



