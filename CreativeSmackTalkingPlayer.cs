using System;
using System.Collections.Generic;
namespace ShootingDice
{
    // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer : Player
    {
        private List<string> insults = new List<string>()
        {
            "The gaps in your teeth are so big it looks like your tongue is in jail",
            "When you step on the scale, it says to be continued...",
            "What's the difference between your mother and a duck...I forget the punchline but your mother is a whore",
            "The only type of comeback you ever have is the kind where you're lying on your stomache",
            "Idk, you suck"
        };
        public void SmackTalk()
        {
            //log a random insult
            Random r = new Random();
            int randomNum = r.Next(0, insults.Count);
            Console.WriteLine(insults[randomNum]);
        }

        public override void Play(Player other)
        {
            SmackTalk();
            base.Play(other);
        }
    }
}