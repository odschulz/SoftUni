using System;

public static class ValidationMethods
{
    public static void CheckIfNumberIsNegative(string parameter, decimal value)
    {
        if (value < 0)
        {
            throw new ArgumentOutOfRangeException(parameter + " cannot be a negative number!");
        }
    }
}