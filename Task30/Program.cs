// Общее обсуждение решения:
// Задача 30: Напишите программу, которая выводит
// массив из 8 элементов, заполненный нулями и
// единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// варианты заполнения массива

// int [] array = new int [];
// int [] array1 = new int[]{4, 7, 8, 5, 7, 3, 4, 4};
// int [] array3 = {4, 7, 8, 5, 7, 3, 4, 4};

// var array4 = new int[8]{4, 7, 8, 5, 7, 3, 4, 4};
// bool[] b = new bool[];
// string[] s = new string[];
// Random[] rnd = new Random[];



int[] CreatArray(int size)
{
    int[] array = new int[size];
    Random rnd = new Random(); //Создается объект чтобы внутри цикла вызвать метод Next
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(2);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("[{0}]", array[i]);
    }
}

int[] arr = CreatArray(8);
PrintArray(arr);