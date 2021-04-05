using System;

namespace _2._Arena_Fighter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            string inMatatVal = ""; // Skriv ut huvudmenyn
            while (inMatatVal != "0")
            {     
                Console.WriteLine("1. New Battle");
                Console.WriteLine("0. Avsluta programmet, vill inte slåss");
                Console.WriteLine();

                inMatatVal = Console.ReadLine();
                switch (inMatatVal)
                {
                    case "1":
                    int playerPoäng=0; ;
                    int motståndarePoäng = 0;
                    int playerNewPoäng=0;
                    int motståndareNewPoäng = 0;

                    var player = new Player();
                    int playerHealth = player.Hälsa();
                    
                    var motståndare = new Motståndare();
                    int motståndareHealth = motståndare.Hälsa();

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
                                    motståndarePoäng += motståndareNewPoäng;
                                }

                        Console.WriteLine($"Players Health  : {playerHealth}");
                        Console.WriteLine($"Motståndares Health : {motståndareHealth}\n");
                        

                        Console.WriteLine("\n"+"Players score: " + playerPoäng);
                        Console.WriteLine("Motståndares score: " + motståndarePoäng+"\n");

                        if(motståndareHealth==0 || playerHealth==0)
                        {
                        Console.WriteLine("\nThe Battle is over");
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
