using System;

public class Game
{
	
    public void case7(ref bool flagExit2)
    {
        Console.WriteLine("Choose an option");
        Console.WriteLine("1: Guess a number");
        Console.WriteLine("2: Check if is a prime number");
        Console.WriteLine("3: Rock Paper Scissors Game");
        Console.WriteLine("4: Factorial");
        Console.WriteLine("5: Season");
        Console.WriteLine("6: Go back to main menu");
        int option2 = int.Parse(Console.ReadLine());

        switch (option2)
        {
            case 1:
                Game randomnumPick = new Game();
                randomnumPick.randomnumGuess();
                break;

            case 2:
                Game primeNum = new Game();
                primeNum.primenumChecker();
                break;

            case 3:
                Game rps = new Game();
                rps.rockpaperScissors();
                break;

            case 4:
                Game findfactorial = new Game();
                findfactorial.Factorial();
                break;

            case 5:

                Game getSeason = new Game();
                getSeason.Season();
                break;

            case 6:
                flagExit2 = true;
                break;

            default:
                Console.Clear();
                Console.WriteLine("Choose a valid menu option \n");
                break;
        };
    }

    public void randomnumGuess()     
    {
        int numGuess = 0;
        int randomNum = 0;
        int numGuesses = 3;
        Random random = new Random();

        Console.WriteLine("You have 3 guesses");
        try
        {

            do
            {
                Console.WriteLine("Guess a number from 1 to 100");
                numGuess = Int32.Parse(Console.ReadLine());
            } while (numGuess < 1 || numGuess > 100);

            numGuesses = numGuesses - 1;
            randomNum = random.Next(1, 100);

            if (numGuess == randomNum)              //picking the right number on 1st try
            {
                Console.WriteLine("You Win!!!");
            }
            else
            {

                do
                {
                    Console.WriteLine("You have {0} guess left", numGuesses);
                    Console.WriteLine("Guess Again!!");
                    numGuess = Int32.Parse(Console.ReadLine());
                    numGuesses = numGuesses - 1;

                } while (numGuesses != 0 || numGuess == randomNum);

                if (numGuesses == 0 && numGuess != randomNum)
                {
                    Console.WriteLine("You Lose!!");

                }
                else
                {
                    Console.WriteLine("You Win!!!");
                };
            };
            Console.WriteLine("The random number was: {0}", randomNum);
        }
        catch(Exception exception)
        {
            Console.WriteLine(exception);
        }

    }
    public void primenumChecker()
    {
        int checkingPrime = 0;
        int a = 0;

        Console.WriteLine("Check if number is prime ");
        Console.WriteLine("Enter a number ");
        try
        {
            checkingPrime = int.Parse(Console.ReadLine());


            for (int i = 1; i <= checkingPrime; i++)
            {
                if (checkingPrime % i == 0)
                {
                    a++;
                }
            }
            if (a == 2)
            {
                Console.WriteLine("{0} is a Prime Number", checkingPrime);
            }
            else
            {
                Console.WriteLine("Not a Prime Number");
            }
        }
        catch (Exception exception)
        {
            Console.WriteLine("You didn't enter an integer....");
            Console.WriteLine(exception);
        };
    }

	public void rockpaperScissors()
    {
        int rock = 1;
        int paper = 2;
        int scissors = 3;
        int userNum = 0;        //user's choice of Rock Paper or Scissors          
        int computerNum = 0;    //computer's choice of Rock Paper or Scissors               
        Random randomNum1 = new Random();
        Console.Clear();    
        try
        {
            do   
            {
                Console.WriteLine("Enter 1 for Rock, 2 for Paper, or 3 for Scissors");
                userNum = Int32.Parse(Console.ReadLine());

            }while(userNum != 1 && userNum != 2 && userNum != 3);  ///if the user enters a number other than 1, 2, or 3

            computerNum = randomNum1.Next(1, 3);    //using random number generator 1-3

            if (userNum == computerNum)
            {
                Console.WriteLine("Tie!!");
            }
            else if (userNum == rock && computerNum == scissors || userNum == paper && computerNum == rock || userNum == scissors && computerNum == paper)
            {
                Console.WriteLine("You Win!!");
            }
            else
            {
                Console.WriteLine("You Loose!!");
            }

            switch (computerNum)
            {
                case 1:
                    Console.WriteLine("The computer chose rock");
                    break;
                case 2:
                    Console.WriteLine("The computer chose paper");
                    break;
                case 3:
                    Console.WriteLine("The computer chose scissors");
                    break;
                default:
                    break;
            }
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception);
        };
    }

    public void Factorial()
    {
        try
        {
            Console.WriteLine("Please enter a value to find the factorial: ");
            float fact = float.Parse(Console.ReadLine());
            float number = fact;
            for (float n = 1; n < number; n++) fact = fact * n;
            Console.WriteLine("The factorial of {0} is {1}.", number, fact);
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception);
        }
    }

    public void Season()
    {
        try
        {
            Console.WriteLine("Please enter your birthday in the following format - YYYY/MM/DD: ");
            string birthdayInput = Console.ReadLine();
            DateTime birthdayParse = DateTime.Parse(birthdayInput);
            int month = birthdayParse.Month;
            int day = birthdayParse.Day;

            switch (month)
            {
                case 1:

                    if (day >= 1 && day <= 31)
                    {
                        Console.WriteLine("Your birthday is in the Winter.");
                    }
                    break;
                case 2:
                    if (day >= 1 && day <= 29)
                    {
                        Console.WriteLine("Your birthday is in the Winter.");
                    }
                    break;
                case 3:
                    if (day >= 1 && day <= 19)
                    {
                        Console.WriteLine("Your birthday is in the Winter.");
                    }
                    else if (day >= 20 && day <= 31)
                    {
                        Console.WriteLine("Your birthday is in the Spring.");
                    }
                    break;
                case 4:
                    if (day >= 1 && day <= 30)
                    {
                        Console.WriteLine("Your birthday is in the Spring.");
                    }
                    break;
                case 5:
                    if (day >= 1 && day <= 31)
                    {
                        Console.WriteLine("Your birthday is in the Spring.");
                    }
                    break;
                case 6:
                    if (day >= 1 && day <= 21)
                    {
                        Console.WriteLine("Your birthday is in the Spring.");
                    }
                    else if (day >= 22 && day <= 30)
                    {
                        Console.WriteLine("Your birthday is in the Summer.");
                    }
                    break;
                case 7:
                    if (day >= 1 && day <= 31)
                    {
                        Console.WriteLine("Your birthday is in the Summer.");
                    }
                    break;
                case 8:
                    if (day >= 1 && day <= 31)
                    {
                        Console.WriteLine("Your birthday is in the Summer.");
                    }
                    break;
                case 9:
                    if (day >= 1 && day <= 23)
                    {
                        Console.WriteLine("Your birthday is in the Summer.");
                    }
                    else if (day >= 24 && day <= 30)
                    {
                        Console.WriteLine("Your birthday is in the Fall.");
                    }
                    break;
                case 10:
                    if (day >= 1 && day <= 31)
                    {
                        Console.WriteLine("Your birthday is in the Fall.");
                    }
                    break;
                case 11:
                    if (day >= 1 && day <= 30)
                    {
                        Console.WriteLine("Your birthday is in the Fall.");
                    }
                    break;
                case 12:
                    if (day >= 1 && day <= 21)
                    {
                        Console.WriteLine("Your birthday is in the Fall.");
                    }
                    else if (day >= 22 && day <= 31)
                    {
                        Console.WriteLine("Your birthday is in the Winter.");
                    }
                    break;
            }
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception);
        }
    }







}
