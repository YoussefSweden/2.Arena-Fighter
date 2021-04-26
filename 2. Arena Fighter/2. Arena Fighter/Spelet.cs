using System;
using System.Collections.Generic;
using System.Text;

namespace ArenaFighter
{
    class Spelet
    {
        public static void Spela()
        {
            Console.WriteLine();

            var Player = new Player();
            int playerHealth = Player.Health;
            Console.Write("Vem är du som spelar? ");
            Player.Name = Console.ReadLine();

            int playerBattlePoäng = Player.BattlePlayerPoint();
            bool fight = true;
            string inMatatVal = "";

            while (fight == true)
            {
                Console.WriteLine("1. New Battle");
                Console.WriteLine("0. Exit, No  fighting ");
                Console.WriteLine();
                inMatatVal = Console.ReadLine();
                switch (inMatatVal)
                {
                    case "1":
                        int playerPoäng = 0; ;
                        int motståndarePoäng = 0;
                        int playerNewPoäng = 0;

                        var motståndare = new Motståndare();
                        int motståndareHealth = motståndare.Health;
                        int motståndareBattlePoäng = motståndare.BattleMotståndareCount();
                        string slåssMer = "";

                        while (slåssMer != "n" && playerHealth > 0 && motståndareHealth > 0)
                        {
                            Console.WriteLine("Wanna fight? (j/n)");

                            slåssMer = Console.ReadLine().ToLower();
                            Console.Clear();
                            switch (slåssMer)
                            {
                                case "j":
                                    string motstånd = motståndare.Name;
                                    int playerSlag = Combat.slumpGenerator();
                                    int motståndareSlag = Combat.slumpGenerator();

                                    if (playerSlag > motståndareSlag)
                                    {
                                        motståndareHealth--;
                                        playerPoäng++;
                                        playerPoäng += playerNewPoäng;
                                    }
                                    else
                                    {
                                        playerHealth--;
                                        motståndarePoäng++;
                                    }
                                    Console.WriteLine($"{Player.Name} Health: {playerHealth}");
                                    Console.WriteLine($"{motstånd} Health : {motståndareHealth}\n");

                                    Console.WriteLine("\n" + Player.Name + " score: " + playerPoäng);
                                    Console.WriteLine("\n" + motstånd + " score: " + motståndarePoäng);

                                    if (motståndareHealth == 0 || playerHealth == 0 && motståndareHealth == 0)
                                    {
                                        Console.WriteLine("\nThe Battle is over");
                                        Console.WriteLine(Player.Name + " won and have survived: " + playerBattlePoäng + " battle");
                                    }

                                    else if ((motståndareHealth == 0 || playerHealth == 0 && playerHealth == 0))
                                    {
                                        Console.WriteLine("\nThe Battle is over");
                                        Console.WriteLine(motstånd + " won after  : " + playerBattlePoäng + " battle");
                                    }
                                    break;

                                case "n":
                                    motståndareHealth = 0;
                                    Console.WriteLine("\nChicken go home \n");
                                    break;
                                default:
                                    Console.WriteLine("\nFel val, försök igen");
                                    break;
                            }
                        }
                        break;
                    case "0":
                        fight = false;
                        break;
                        
                    default:
                        Console.WriteLine("Felaktigt val!");
                        break;
                }
                Console.WriteLine();
            }

        }
    }
}


    
