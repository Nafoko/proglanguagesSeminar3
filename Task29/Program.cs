// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// int[] randomArray = new int[8];

// for (int i = 0; i < 8; i++)
// {
// randomArray[i] = new Random().Next(1,99);
// Console.Write(randomArray[i] + );
// }


static void Main()
        {
            int size = 20;
            int[] array = new int[20];
            Random myRandom = new Random();
 
            Console.WriteLine("Вывод с помощью for");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = myRandom.Next(0, 20);
                Console.Write("{0} ", array[i]);
            }
 
            Console.WriteLine("\n\nВывод с помощью foreach");
            foreach (var elem in array)
            {
                Console.Write("{0} ", elem);
            }
        }