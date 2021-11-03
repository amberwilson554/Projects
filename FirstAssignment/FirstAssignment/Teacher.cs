using System;
using FirstAssignment;

public class Teacher
{
    public void multiplyValues()
    {
        float value1;
        float value2;
        float totalResult;
      try
      {
        
        Console.WriteLine("Enter the first value to be multiplied: ");
        value1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second value to be multiplied: ");
        value2 = float.Parse(Console.ReadLine());

        if ((int)value1 == 0 || (int)value2 == 0)
        {
            Console.WriteLine("Your result is 0");
        }
        else
        {
            totalResult = value1 * value2;
            Console.WriteLine("Your result is {0}", totalResult);
        };
      }
      catch (Exception exception)
      {
            Console.WriteLine(exception);
      }
    }
    public void divideValues()
    {
        float divValue1;
        float divValue2;
        float totalDiv;
        try
        {
            Console.WriteLine("Enter the first value to be divided: ");
            divValue1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second value to be divided: ");
            divValue2 = float.Parse(Console.ReadLine());

            if ((int)divValue2 == 0)
            {
                Console.WriteLine("You can't divide by 0 or result is infinity");
            }
            else
            {
                totalDiv = divValue1 / divValue2;
                Console.WriteLine("Your result is {0}", totalDiv);
            };
        }
        catch (DivideByZeroException exception)
        {
            Console.WriteLine(exception);
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception);
        }

    }



}
