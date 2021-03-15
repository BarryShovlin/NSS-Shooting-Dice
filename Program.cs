﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ShootingDice
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player();
            player1.Name = "Bob";

            Player player2 = new Player();
            player2.Name = "Sue";

            // player2.Play(player1);

            // Console.WriteLine("-------------------");

            Player player3 = new Player();
            player3.Name = "Wilma";

            // player3.Play(player2);

            // Console.WriteLine("-------------------");

            Player large = new LargeDicePlayer();
            large.Name = "Bigun Rollsalot";

            // player1.Play(large);

            // Console.WriteLine("-------------------");

            SmackTalkingPlayer player4 = new SmackTalkingPlayer("Ima come at you like a spider monkey!");
            player4.Name = "Slick Rick";

            // player4.Play(large);

            // Console.WriteLine("-------------------");

            Player plusOne = new OneHigherPlayer();
            plusOne.Name = "Turd Ferguson";

            // plusOne.Play(player4);

            // Console.WriteLine("-------------------");

            Player human = new HumanPlayer();
            human.Name = "Jeremy Jam";

            // human.Play(player4);

            // Console.WriteLine("-------------------");


            CreativeSmackTalkingPlayer smack = new CreativeSmackTalkingPlayer();
            smack.Name = "Joe Mama";

            // smack.Play(player2);

            // Console.WriteLine("-------------------");

            Player loser = new SoreLoserPlayer();
            loser.Name = "Freddie";
            // loser.Play(player3);

            // Console.WriteLine("-------------------");

            Player ups = new UpperHalfPlayer();
            ups.Name = "Mr. Bigglesworth";

            // ups.Play(player4);

            // Console.WriteLine("-------------------");

            Player upSore = new SoreLoserUpperHalfPlayer();
            upSore.Name = "Bing Crosby";

            // upSore.Play(human);

            // Console.WriteLine("-------------------");

            List<Player> players = new List<Player>() {
                player1, player2, player3, large, player4, plusOne, human, smack, loser, ups, upSore
            };

            PlayMany(players);
        }

        static void PlayMany(List<Player> players)
        {
            Console.WriteLine();
            Console.WriteLine("Let's play a bunch of times, shall we?");

            // We "order" the players by a random number
            // This has the effect of shuffling them randomly
            Random randomNumberGenerator = new Random();
            List<Player> shuffledPlayers = players.OrderBy(p => randomNumberGenerator.Next()).ToList();

            // We are going to match players against each other
            // This means we need an even number of players
            int maxIndex = shuffledPlayers.Count;
            if (maxIndex % 2 != 0)
            {
                maxIndex = maxIndex - 1;
            }

            // Loop over the players 2 at a time
            for (int i = 0; i < maxIndex; i += 2)
            {
                Console.WriteLine("-------------------");

                // Make adjacent players play noe another
                Player player1 = shuffledPlayers[i];
                Player player2 = shuffledPlayers[i + 1];
                player1.Play(player2);
            }
        }
    }
}