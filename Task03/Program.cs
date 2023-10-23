// Напишите программу котоаря принимает на ввод два числа 
// и выводить является ли первое число кратным второму.
// Если первое число не кратно второму, то программа выводит отстаток от деления.


int Remainder(int firstPar, int SecondPar)
{
    return firstPar % SecondPar;
}

Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());


int remainder = Remainder(firstNumber, secondNumber);
if (remainder == 0) Console.WriteLine("Кратно");
else Console.WriteLine($"не кратно, остаток {remainder}");
