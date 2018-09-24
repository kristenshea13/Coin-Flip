using System;

namespace Coin_Flip
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Predict the outcome of your coin toss! ");
            Console.Write("Heads or Tails? ");
            //declare variable for user guess, convert to all caps, program is case sensitive.
            string headsorTails = Console.ReadLine().ToUpper();

            Console.WriteLine("Hit Enter to toss coin. ");

            Console.ReadKey(); //wanted program to pause and user to hit enter to flip coin.
            
            //declare variable for the outcome of randomized coin toss method
            string tossOutcome;

            //logic to return heads if method returns 0, and tails if method returns 1.
            if (CoinToss() == 0)
                tossOutcome = "Heads!";
            else
                tossOutcome = "Tails!";

            Console.WriteLine(tossOutcome);


            //if/elseif/else statements to tell user if they won or lost the coin toss.
            if ((headsorTails == "HEADS" && tossOutcome == "Tails!") || (headsorTails == "TAILS" && tossOutcome == "Heads!"))
                Console.WriteLine("Better luck next time. You lose. ");
            else if ((headsorTails == "HEADS" && tossOutcome == "Heads!") || (headsorTails == "TAILS" && tossOutcome == "Tails!"))
                Console.WriteLine("Lucky guess! You Win! ");

            //catch all statement if user guesses something other than *heads* or *tails*
            else
                Console.WriteLine("Invalid guess.");


            Console.ReadLine();
        }


        //randomizer method for coin toss
        /// <summary>
        /// randomizer method for coin toss
        /// </summary>
        /// <returns>0 or 1</returns>
        private static int CoinToss()
        {
            Random rnd = new Random();
            return rnd.Next(0, 1);
        }

    }
}
