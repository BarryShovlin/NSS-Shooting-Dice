using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A player the prompts the user to enter a number for a roll
    public class HumanPlayer : Player
    {
        public override int Roll()
        {
            Console.WriteLine("Enter your dice roll (1-6)");
            Console.Write(">");
            string playerInput = Console.ReadLine();
            int humanRoll = Int32.Parse(playerInput);
            return humanRoll;
        }

        public override void Play(Player other)
        {
            int otherRoll = new Random().Next(DiceSize) + 1;
            base.Play(other);
        }
    }
}