using System;
using System.Linq;

public static class ArmstrongNumbers
{
    public static bool IsArmstrongNumber(int number)
    {
        double result = 0;
        double degree = Math.Floor(Math.Log10(number) + 1);
        int buffer = number;
        
        while (buffer != 0)
        {
            result += Math.Pow(buffer % 10, degree);
            buffer /= 10;
        }

        return result == number;
    }
}