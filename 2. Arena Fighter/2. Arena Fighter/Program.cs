using System;

namespace _2._Arena_Fighter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            var player = new Player();
            int playerHealth = player.Hälsa();
            string playerName = player.Name; 
            int playerBattlePoäng = player.BattlePlayerPoint();

            var motståndare = new Motståndare();
            string motstånd = motståndare.Name;
            int motståndareHealth = motståndare.Hälsa();
            int motståndareBattlePoäng = motståndare.BattleMotståndareCount();
            

            string inMatatVal = ""; 
            while (inMatatVal != "0")
            {     
                Console.WriteLine("1. New Battle");
                Console.WriteLine("0. Exit, No  fighting ");
              
                Console.WriteLine();
               
                inMatatVal = Console.ReadLine();
                switch (inMatatVal)
                {
                    case "1":
                    int playerPoäng=0; ;
                    int motståndarePoäng = 0;
                    int playerNewPoäng=0;

                    string slåssMer = "";
                    while (slåssMer != "n" && playerHealth > 0 && motståndareHealth > 0)
                    {
                        Console.WriteLine("Wanna fight? (j/n)");
                        slåssMer = Console.ReadLine().ToLower();
                                         
                        int playerSlag = Combat.slumpGenerator();
                        int motståndareSlag = Combat.slumpGenerator();

                        Console.Clear();

                        switch (slåssMer)
                        {
                            case "j":
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

                        Console.WriteLine($"{playerName} Health: {playerHealth}");
                        Console.WriteLine($"{motstånd} Health : {motståndareHealth}\n");

                        Console.WriteLine("\n"+playerName+" score: " + playerPoäng);
                        Console.WriteLine("\n"+motstånd +" score: "+ motståndarePoäng);

                        if(motståndareHealth==0 || playerHealth==0 && motståndareHealth==0)
                        {
                        Console.WriteLine("\nThe Battle is over"); 
                                        Console.WriteLine(playerName+ " won and have survived: " + playerBattlePoäng+" battle");
                        }
                                    else if ((motståndareHealth == 0 || playerHealth == 0 && playerHealth ==0))
                                    {
                                        Console.WriteLine("\nThe Battle is over");
                                        Console.WriteLine(motstånd + " won after  : " + playerBattlePoäng+" battle");
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
