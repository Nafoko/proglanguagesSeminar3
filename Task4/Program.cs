// 14.
// Программа, которая принимает на ввод число и проверяет, 
// кратно ли оно одновременно 7 и 23.

bool MultipleNumbers(int num, int num1, int num2)
{
    return num % num1 == 0 && num % num2 == 0;
}
Console.WriteLine("введите первое число");
int number = Convert.ToInt32(Console.ReadLine());

bool result = MultipleNumbers(number, 7, 23);
Console.WriteLine(result ? "да" : "нет");
