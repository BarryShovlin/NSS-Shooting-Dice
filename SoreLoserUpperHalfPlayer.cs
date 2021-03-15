using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player who always rolls in the upper half of their possible role and
    //  who throws an exception when they lose to the other player
    public class SoreLoserUpperHalfPlayer : Player
    {
        public override void Play(Player other)
        {
            int myRoll = Roll();
            int otherRoll = other.Roll();

            if (myRoll <= 3)
            {
                myRoll = myRoll + 3;
            }

            Console.WriteLine($"{Name} rolls a {myRoll}");
            Console.WriteLine($"{other.Name} rolls a {otherRoll}");

            if (myRoll > otherRoll)
            {
                Console.WriteLine($"{Name} Wins!");
            }
            else if (myRoll < otherRoll)
            {
                try
                {
                    Console.WriteLine(myRoll / 0);
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine($"{Name} is a sore loser... {ex.Message}");
                }

            }
            else
            {
                // if the rolls are equal it's a tie
                Console.WriteLine("It's a tie");
            }
        }
    }
}
