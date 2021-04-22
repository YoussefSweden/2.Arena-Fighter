using System;
using System.Collections.Generic;
//using System.Text;

namespace _2._Arena_Fighter
{
    class Combat
    {
        static Random slump = new Random();
        public int strength = slumpGenerator();
        public static int battlePlayerCount = 0;
        public static int battleMotståndareCount = 0;

        public int BattlePlayerPoint()
        {
            return battlePlayerCount += 1;
        }
        public static int slumpGenerator()
        {
            return slump.Next(1, 6);
        }

        public int BattleMotståndareCount()
        {
            return battleMotståndareCount += 1;
        }


    }
    class Motståndare : Combat
    {
        public string Name { get; set; }
        public int Power { get; set; }
        public int Health { get; set; }
        public Motståndare()    
        {
            int i=slumpGenerator();
            string[] moståndareArray = { "Berra","Tore", "Agda", "Berit","Gunnar", "Astrid" };

            Name = moståndareArray[i];
            Health = 5;
        }
        public int Hälsa()
        {
            return Health;
        }
        public int Kraft()
        {
            return Power;
        }
    }
    class Player : Motståndare
    {
        public  Player()
        {
            Console.Write("Vem är du som spelar? ");//update
            Name = Console.ReadLine();
            Power = slumpGenerator();
            Health = 5;
            
        }
    }

}
