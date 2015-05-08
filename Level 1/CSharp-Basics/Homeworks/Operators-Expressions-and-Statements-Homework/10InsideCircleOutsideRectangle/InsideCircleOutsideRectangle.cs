using System;

class InsideCircleOutsideRectangle
{
    static void Main()
    {
        //1	    2	yes
        //2.5	2	no
        //0	    1	no
        //2.5	1	no
        //2	    0	no
        //4	    0	no
        //2.5	1.5	no
        //2	    1.5	yes
        //1	    2.5	yes
        //-100  -100	no

        Console.Write("Enter x:");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Enter y:");
        double y = double.Parse(Console.ReadLine());
        double center = 1.0;
        double r = 1.5 * 1.5;
        bool inCircle = (Math.Pow(x-center, 2) + Math.Pow(y-center, 2)) <= r;
        bool outRectangle = (x < -1 || x > 5) || (y < -1 || y > 1);
        bool answer = inCircle && outRectangle;  
        if (answer == true)
        {
            Console.WriteLine("Yes");
        }
        else
        { Console.WriteLine("No"); 
        }
    }
}

