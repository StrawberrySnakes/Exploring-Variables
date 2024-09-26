namespace exploringVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string heroFirstName = "Todd";
            string heroLastName = "Toddingson";
            string heroFullName = heroFirstName + " " + heroLastName;

            string villianName = "Bartholomew";
            string minion1Name = "Norm";
            string minion2Name = "Chad";
            string villianTitle = "A Super Evil Guy";
            string minionTitle = "Just A Guy";

            int heroHealth = 100;
            int heroStrength = 50;
            int bossHealth = 100;
            int bossStrength = 25;
            int minion1Health = 50;
            int minion2Health = 50;
            int minionStrength = 5;

            //villian attacks
            Console.WriteLine("The Hero "+heroFullName + " has arrived to save the day. His arch rival " +villianTitle+ " and his assistints, "+minion1Name+ " and, "+minion2Name+ "are terrorizing the town");
            Console.WriteLine("The Hero Arrives at the scene!\nHero's health: " + heroHealth + "\nVillian health: " + bossHealth + "\nMinion 1's health: " + minion1Health + "\nMinion 2's health: " + minion2Health);
            
            Console.WriteLine(villianName + " the " + villianTitle + " attacks " + heroFullName);
            Console.WriteLine(villianName + " the " + villianTitle + " deals " + bossStrength + " damage!");
            heroHealth -= bossStrength;
            Console.WriteLine(heroFullName + " now has: " + heroHealth + "HP remaining");
            
            //minions attack
            Console.WriteLine("The minions attack!");
            Console.WriteLine(minion1Name + " deals " + minionStrength + " damage!");
            heroHealth = heroHealth - minionStrength;
            Console.WriteLine(heroFullName + " now has " + heroHealth + "HP");
            
            Console.WriteLine(minion2Name + " deals " + minionStrength + " damage!");
            heroHealth = heroHealth - minionStrength;
            Console.WriteLine(heroFullName + " now has " + heroHealth + " HP");

            //Hero Attacks
            Console.WriteLine(heroFullName + " launches his attacks on the villian and his minions for " + heroStrength + " damage!");
            bossHealth -= heroStrength;
            minion1Health -= heroStrength;
            minion2Health -= heroStrength;

            Console.WriteLine(villianName + " the " + villianTitle + " now has " + bossHealth + "HP");
            Console.WriteLine(minionTitle + " " + minion1Name + " now has " + minion1Health + " HP");
            Console.WriteLine(minionTitle + " " + minion2Name + " now has " + minion2Health + " HP");

            //minons dead
            Console.WriteLine(minion1Name + " and " + minion2Name + " have been defeated!");

            //boost hero health
            Console.WriteLine("The hero drinks a regenteration potions and restors HP +5");
            heroHealth += 5;
            Console.WriteLine(heroFullName + " now has " + heroHealth + "HP");
            bossStrength += 30;
            Console.WriteLine(villianName + " the " + villianTitle + "goes crazy and gets a power boost\n" + "Villian Strength is now: " + bossStrength + " damage");


            //final battle
            Console.WriteLine(villianName + " the " + villianTitle + " attacks " + heroFullName + " with his strongest attack");
            Console.WriteLine(villianName + " the " + villianTitle + " deals " + bossStrength + " damage");
            
            heroHealth = heroHealth - bossStrength;
            Console.WriteLine(heroFullName + " now has " + heroHealth + "HP");
            
            
            //Hero final attack
            Console.WriteLine(heroFullName + " attacks " + villianName + " the " + villianTitle + " for " + heroStrength + " damage!");
            bossHealth = bossHealth - heroStrength;
            Console.WriteLine(villianName + " the " + villianTitle + " now has " + bossHealth + "HP");

            //Results
            Console.WriteLine(heroFullName + " is victorious!\nHe recives a freshly baked Pie as a thank you from the townsfolk\n" +heroFullName + " loves pie.");





        }
    }
}
