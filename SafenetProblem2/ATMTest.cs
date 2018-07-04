using System;

namespace SafenetProblem2
{
    class ATMTest
    {
        static void Main(string[] args)
        {
            String fullCommand;
            String command;
            String number;
            int quit = 1;
            ATM bot = new ATM();

            do
            {
                fullCommand = Console.ReadLine();
                command = fullCommand.ToLower().Substring(0, 1);
                switch (command)
                {
                    case "r":
                        bot.refill();
                        break;
                    case "w":
                        number = fullCommand.Substring(fullCommand.IndexOf("$") + 1);
                        int take = Int32.Parse(number);
                        bot.take(take);
                        break;
                    case "i":
                        number = fullCommand + " ";
                        if (number.Contains(" $100 "))
                        {
                            Console.WriteLine("$100 - " + bot.getHundreds());
                        }
                        if (number.Contains(" $50 "))
                        {
                            Console.WriteLine("$50 - " + bot.getFifty());
                        }
                        if (number.Contains(" $20 "))
                        {
                            Console.WriteLine("$20 - " + bot.getTwenty());
                        }
                        if (number.Contains(" $10 "))
                        {
                            Console.WriteLine("$10 - " + bot.getTens());
                        }
                        if (number.Contains(" $5 "))
                        {
                            Console.WriteLine("$5 - " + bot.getFives());
                        }
                        if (number.Contains(" $1 "))
                        {
                            Console.WriteLine("$1 - " + bot.getOnes());
                        }
                        break;
                    case "q":
                        quit = 0;
                        break;
                    default:
                        Console.WriteLine("Failure: Invalid Command");
                        break;
                }
            } while (quit == 1);
            Console.ReadLine();
        }
    }
}


