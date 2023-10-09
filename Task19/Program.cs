using System;

public class Answer
{
    static bool IsPalindrome(int number)
    
      if (number < 1000 || number > 99999)
        {
           Console.WriteLine("Число не пятизначное");
          return false;
        }
