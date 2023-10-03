// 25
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


class Program
{
    public static int Main()
    {
        Console.Write("Введите число   : ");
        int num = int.Parse(Console.ReadLine());  //число, которое нужно возвести в степень
        Console.Write("Введите степень : ");
        int n = int.Parse(Console.ReadLine());   //степень числа

        int num_n = 1; //число в степени

        for (int i = 0; i < n; i++)
        {
            num_n = num_n * num;
        }
        Console.WriteLine("{0} ^ {1} = {2}", num, n, num_n);
        Console.ReadKey();
        return 0;
    }
}