using System;
public class Program
{
    static void Main(string[] args)
    {
        bool invalid = true;
        while (invalid == true)
        {
            int num = int.Parse(Console.ReadLine());
            if (num >= 0)
            {
                for (int i = 0; i <= num; i++)
                {
                    for (int j = 0; j <= i; j++)
                    {
                        Console.Write("{0} ", Pascal(i, j));
                    }
                    Console.WriteLine(" ");

                }
                invalid = false;
            }
            else
            {
                Console.WriteLine("Invalid Pascal's triangle row number.");
            }
        }
    }
    static int Pascal(int row, int col)
    {
        if (col == 0 || col == row)
        {
            return 1;
        }
        else
        {
            return Factorial(row) / (Factorial(row - col) * Factorial(col));
        }
    }
    static int Factorial(int num)
    {
        if (num <= 1)
        {
            return 1;
        }
        else
        {
            return num * Factorial(num - 1);
        }
    }
}
