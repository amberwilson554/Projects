using System;
using FirstAssignment;

public class Determine
{

    public void biggerValue()
    {
        float bigValue1;
        float bigValue2;
        try
        {
            Console.WriteLine("Enter the first value to be compared: ");
            bigValue1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second value to be compared: ");
            bigValue2 = float.Parse(Console.ReadLine());

            if (bigValue1 > bigValue2)
            {
                Console.WriteLine("The bigger value is {0}", bigValue1);
            }
            else if (bigValue1 == bigValue2)
            {
                Console.WriteLine("The values are equal");
            }
            else
            {
                Console.WriteLine("The bigger value is {0}", bigValue2);
            };
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception);
        }
    }
    public void oddorEven()
    {
        int num1;
        int result;
        try
        {
            Console.WriteLine("Enter the value to find out if it is even or odd");
            num1 = Int32.Parse(Console.ReadLine());

            result = num1 % 2;
            Console.WriteLine("remainder is {0}", result);

            if (result == 0)
            {
                Console.WriteLine("The value is even");
            }
            else
            {
                Console.WriteLine("The value is odd");
            };
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception);
        }
    }

}
