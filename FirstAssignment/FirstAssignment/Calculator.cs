using System;
using FirstAssignment;

public class Calculator
{

    public void calcIncome()
    {
        float hoursWorked;
        float payperHour;
        float totalPay;
        try
        {

            Console.WriteLine("Enter the hours worked: ");
            hoursWorked = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter the pay per hour: ");
            payperHour = float.Parse(Console.ReadLine());

            totalPay = payperHour * hoursWorked;

            Console.WriteLine(totalPay);
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception);
        }
    }
    public void calcGrade()
    {
        float testScores = 0.0f;
        float totalGrade = 0.0f;
        float maxScore = 0.0f;
        int scoreChoice = 0;

        try
        {
            Console.WriteLine("Enter the total amount of grade points that can be earned");
            maxScore = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter the student's 1st test score: ");
            testScores = +float.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine("Would you like to enter another score?");
                Console.WriteLine("Press 1 for yes or 2 for no");
                scoreChoice = Int32.Parse(Console.ReadLine());
            } while (scoreChoice != 1 && scoreChoice != 2);
 
            if (scoreChoice == 1)
            {
                while (scoreChoice != 2)
                {
                    Console.WriteLine("Enter next test score: ");
                    testScores = testScores + float.Parse(Console.ReadLine());
                    Console.WriteLine("Would you like to enter another score?");
                    do
                    {
                        Console.WriteLine("Press 1 for yes or 2 for no");
                        scoreChoice = Int32.Parse(Console.ReadLine());
                    } while (scoreChoice != 1 && scoreChoice != 2);
                };
            };

            totalGrade = 100 * (testScores / maxScore);

            if (totalGrade >= 70)
            {
                Console.WriteLine("You Passed!{0}%", totalGrade);
            }
            else
            {
                Console.WriteLine("You Failed! {0}%", totalGrade);
            };
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception);
        }
    }

}
