using System;

namespace FirstAssignment
{
    class Program
    {
        private static object int32;

        static void Main(string[] args)
        {
            bool flagExit = false;
            do
            {
                Console.BackgroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Choose an option");
                Console.WriteLine("1: Calculate the income of an employee");
                Console.WriteLine("2: Calculate if a student approves or fails a course");
                Console.WriteLine("3: Multiplication of 2 values");
                Console.WriteLine("4: Division of 2 values");
                Console.WriteLine("5: Compare 2 values and return the biggest value");
                Console.WriteLine("6: Determine if a number is odd or even");
                Console.WriteLine("7: Extra Features");
                Console.WriteLine("8: to exit");
                try
                {
                    int option = int.Parse(Console.ReadLine());

                    switch (option)
                    {
                        case 1:
                           
                            Calculator incomeCal = new Calculator();
                            incomeCal.calcIncome();
                            Console.ReadKey();
                            break;

                        case 2:
                            
                            Calculator totalGrade = new Calculator();
                            totalGrade.calcGrade();
                            Console.ReadKey();
                            break;

                        case 3:
                            
                            Teacher multiValues = new Teacher();
                            multiValues.multiplyValues();
                            break;

                        case 4:
                            
                            Teacher divValues = new Teacher();
                            divValues.divideValues();
                            break;

                        case 5:
                            
                            Determine bigValue = new Determine();
                            bigValue.biggerValue();
                            break;

                        case 6:
                            
                            Determine oeValue = new Determine();
                            oeValue.oddorEven();
                            break;

                        case 7:
                            bool flagExit2 = false;
                            do
                            {
                               
                                Game caseseven = new Game();
                                caseseven.case7(ref flagExit2);
                            } while (flagExit2 != true);
                            break;
                        case 8:
                           
                            Console.WriteLine("Exiting program..........BYE");
                            flagExit = true;
                            break;

                        default:
                            
                            Console.WriteLine("Choose a valid menu option \n");
                            break;
                    }
                }
                catch (Exception exception)
                {
                   Console.WriteLine(exception);
                }
            } while (flagExit != true);
        }

    }

}
