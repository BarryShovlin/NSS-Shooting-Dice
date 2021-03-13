using System;
using System.Collections.Generic;

namespace ShootingDice
{
    // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer : Player
    {
        public List<string> Taunts = new List<string>()
        {
            "You smell like funyuns", "You little trout sniffer", "I'm gonna lay down a booty smack", "Do a barrell roll!"
        };

        public override void Play(Player other)
        {
            Random RandomTaunt = new Random();
            int taunt = RandomTaunt.Next(Taunts.Count);
            string RandoTaunt = Taunts[taunt];
            Console.WriteLine($"{Name} says '{RandoTaunt}'");
            base.Play(other);
        }

    }
}