using System;

namespace Loops_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create and store random #
            //Prompt user for an int value from 1 100, until user guesses the random #
            //If guess is incorrect, display 'too high' or 'too low' (if guess >|10| difference, display "way too x")
            //Track # of guesses once user is successful, along with a "rating"(?) - display both
            //prompt user to play again
            //if user chooses to end the game, display a goodbye message

            
            
            bool keepGoing = true;
            Console.WriteLine("Welcome to the Guess a Number Game!\n++++++++++++++++++++++++++++++++++");
            
            while (keepGoing)
            {
                System.Random random = new System.Random();
                int secretNum = random.Next(1, 101);//normally 1,101
                int guessNum = IntValidation((GetInput("\nI'm thinking of a number between 1 and 100.\nTry to guess it, n00b.\n\nEnter your lousy guess: ")), 0, 100);

                ValidateGuess(guessNum, secretNum);
                
                
                /*for (int i = 1; i <= 20; i++)
                {
                    i = ValidateGuess(guessNum, secretNum);
                
                    if (i == 20)
                    { 
                        Console.WriteLine("You wasted your 20 guesses.  You are not great at guessing #s.\n"); 
                    }
                    else if (secretNum != guessNum)
                    {
                        if ((secretNum - guessNum) > 10)
                        {
                            Console.WriteLine("You're WAY too low - guess again.\n");
                            guessNum = ConvertToInteger(GetInput("Enter a number: "));
                        }
                        else if ((secretNum - guessNum) <= 10 && (secretNum - guessNum) > 0)
                        {
                            Console.WriteLine("You're close, but still low.  Guess again.\n");
                            guessNum = ConvertToInteger(GetInput("Enter a number: "));
                        }
                        else if ((secretNum - guessNum) < 0 && (secretNum - guessNum) >= (-10))
                        {
                            Console.WriteLine("You're close, but still high.  Guess again.\n");
                            guessNum = ConvertToInteger(GetInput("Enter a number: "));
                        }
                        else if ((secretNum - guessNum) < -10)
                        {
                            Console.WriteLine("You're WAY too high - guess again.\n");
                            guessNum = ConvertToInteger(GetInput("Enter a number: "));
                        }
                    }
                    else if (secretNum == guessNum)
                    {
                        if (i < 3)
                        {
                            Console.WriteLine($"You got it in {i} tries.\n");
                            Console.WriteLine("You must be telepathic!\n");
                            i = 21;
                        }
                        else if (i >= 3 && i <= 5)
                        {
                            Console.WriteLine($"You got it in {i} tries.\n");
                            Console.WriteLine("Pretty good, I guess.  I bet you can do better than that though!\n");
                            i = 21;
                        }
                        else if (i > 6)
                        {
                            Console.WriteLine($"You got it in {i} tries.\n");
                            Console.WriteLine("You got it, but try again - you're not great at this.\n");
                            i = 21;
                        }
                    }
                }*/
                keepGoing = ContinueLoop("Try again? (y/n): ");
            }

        }
        public static bool ContinueLoop(string input)
        {
            string output = GetInput(input);
            if (output.ToLower() == "y")
            {
                return true;
            }
            else if (output.ToLower() == "n")
            {
                return false;
            }
            else
                return ContinueLoop("That's not a valid response.  Use y or n.");
        }
        public static string GetInput(string input)
        {
            Console.Write(input);
            string output = Console.ReadLine();
            return output;
        }
        public static int ConvertToInteger(string input)
        {
            int output;
            
                if (int.TryParse(input, out output) && output > 0 && output <= 100)
                {
                    return output;
                }
                else
                {
                input = GetInput("That is not a valid response.  Use an integer between 1-100.\n");
                return ConvertToInteger(input);
                }
            
            
        }
        public static int IntValidation(string input, int Min, int Max) //alternate method, using their suggested hint
        {
            int result;

            if (int.TryParse(input, out result) && result > Min && result <= Max)
            {
                return result;
            }
            else
            {
                input = GetInput("That is not a valid response.  Use an integer between 1-100.\n");
                return ConvertToInteger(input);
            }

        
        }
        public static void ValidateGuess(int guessNum, int secretNum)
        {

            
            for (int i = 1; i <= 20; i++)
            {

                if (i == 20)
                {
                    Console.WriteLine("You wasted your 20 guesses.  You are not great at guessing #s.\n");
                    
                }
                else if (secretNum != guessNum)
                {
                    if ((secretNum - guessNum) > 10)
                    {
                        Console.WriteLine("You're WAY too low - guess again.\n");
                        guessNum = ConvertToInteger(GetInput("Enter a number: "));
                    

                    }
                    else if ((secretNum - guessNum) <= 10 && (secretNum - guessNum) > 0)
                    {
                        Console.WriteLine("You're close, but still low.  Guess again.\n");
                        guessNum = ConvertToInteger(GetInput("Enter a number: "));
                       
                    }
                    else if ((secretNum - guessNum) < 0 && (secretNum - guessNum) >= (-10))
                    {
                        Console.WriteLine("You're close, but still high.  Guess again.\n");
                        guessNum = ConvertToInteger(GetInput("Enter a number: "));
                       
                    }
                    else if ((secretNum - guessNum) < -10)
                    {
                        Console.WriteLine("You're WAY too high - guess again.\n");
                        guessNum = ConvertToInteger(GetInput("Enter a number: "));
                        
                    }
                }
                else if (secretNum == guessNum)
                {
                    if (i < 3)
                    {
                        Console.WriteLine($"You got it in {i} tries.\n");
                        Console.WriteLine("You must be telepathic!\n");
                        i = 21;

                    }
                    else if (i >= 3 && i <= 5)
                    {
                        Console.WriteLine($"You got it in {i} tries.\n");
                        Console.WriteLine("Pretty good, I guess.  I bet you can do better than that though!\n");
                        i = 21;

                    }
                    else if (i > 6)
                    {
                        Console.WriteLine($"You got it in {i} tries.\n");
                        Console.WriteLine("You got it, but try again - you're not great at this.\n");
                        i = 21;

                    }

                }


                
            }
        }

    }



}

 

