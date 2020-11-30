using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A player the prompts the user to enter a number for a roll
    public class HumanPlayer : Player
    {
        public override void Play(Player other)
        {
            //prompt for a number
            int myRoll;
            while(true)
            {
                Console.Write($"{Name}'s number: ");
                try
                {
                    myRoll = Int32.Parse(Console.ReadLine());
                    
                    if(myRoll < 0)
                    {
                        Console.WriteLine("Please enter a postive integer");
                    }
                    else
                    {
                        break;
                    }
                }
                catch
                {
                    Console.WriteLine("Please enter a postive integer");
                }

            }
            
            // Call roll for the "other" object
            int otherRoll = other.Roll();

            Console.WriteLine($"{other.Name} rolls a {otherRoll}");
            if (myRoll > otherRoll)
            {
                Console.WriteLine($"{Name} Wins!");
            }
            else if (myRoll < otherRoll)
            {
                Console.WriteLine($"{other.Name} Wins!");
            }
            else
            {
                // if the rolls are equal it's a tie
                Console.WriteLine("It's a tie");
            }
        }
    }
}