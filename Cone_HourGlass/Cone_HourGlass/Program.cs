using System;

namespace Cone_HourGlass
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;
            bool check = true;
            do
            {
                Console.WriteLine("");
                Console.WriteLine("1: Draw a cone");
                Console.WriteLine("2: Draw an Hourglass");
                Console.WriteLine("3: Exit");
                Console.WriteLine("");

                try
                {
                  choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            do
                            {
                                try
                                {
                                    Console.WriteLine("Enter a number to create a cone");
                                    int cone_number = int.Parse(Console.ReadLine());
                                    Art cone_art = new Art();
                                    cone_art.ConeArt(cone_number);
                                    check = true;
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine("Invalid Format- try again");
                                    check = false;
                                }
                            } while (check == false);
                            break;

                        case 2:
                            do
                            {
                                try
                                {
                                    Console.WriteLine("Enter a number to create an hourglass");
                                    int hourglass_number = int.Parse(Console.ReadLine());
                                    Art hourglass_art = new Art();
                                    hourglass_art.HourglassArt(hourglass_number);
                                    check = true;
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine("Invalid Format- try again");
                                    check = false;
                                }
                            } while (check == false);

                            break;
                        case 3:
                            Console.WriteLine("Exiting.....BYE!");
                            break;
                        default:
                            Console.WriteLine("Invalid choice.....Enter a number from the menu");
                            break;
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine("Invalid Format");
                }

            } while (choice != 3);
           

            

        }
    }
}
