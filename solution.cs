using System;

class Program
{
    static void Main()
    {
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());

        if(num1 == 0 || num2 == 0)
        {
          Console.WriteLine(1);
        }else
        {
          Console.WriteLine(0);
        }
    }
}