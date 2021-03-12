using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player who shouts a taunt every time they roll dice
    public class SmackTalkingPlayer : Player
    {
        public string Taunt { get; set; }

        public override void Play(Player other)
        {
            Console.WriteLine($"{Name} looks at his opponent and says '{Taunt}'");
            base.Play(other);
        }

        public SmackTalkingPlayer(string taunt)
        {
            Taunt = taunt;
        }


    }
}