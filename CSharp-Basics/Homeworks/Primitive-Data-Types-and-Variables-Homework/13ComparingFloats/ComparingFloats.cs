using System;

class ComparingFloats
{
    static void Main()
    {
    // 5.3           |6.01	        |false
    // 5.00000001    |5.00000003    |true
    // 5.00000005    |5.00000001	|true
    // -0.0000007	 |0.00000007	|true
    // -4.999999	 |-4.999998	    |false
    // 4.999999	     |4.999998	    |false

        Console.WriteLine("Compare number: ");
        Console.Write("Enter first number: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        double b = double.Parse(Console.ReadLine());       
        double difference1 = a-b;
        double difference2 = b-a;
        float eps = 0.000001f;
        if (a > b)
        {
            if (difference1 < eps)
            {
                Console.WriteLine("The numbers are equal!");
            }
            else
            {
                Console.WriteLine("The numbers are not equal!");
            }
        }
        else if (a < b)
        {
            if (difference2 < eps)
            {
                Console.WriteLine("The numbers are equal");
            }
            else
            {
                Console.WriteLine("The numbers are not equal");
            }
        }
        
    }
}

