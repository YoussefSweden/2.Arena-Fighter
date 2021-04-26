using System;
using System.Collections.Generic;
//using System.Text;

namespace ArenaFighter
{
    class  Combat
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

        public string Name { get; set; }
        public int Power { get; set; }
        public int Health { get; set; }
    }
    class Motståndare : Combat
    {
        public Motståndare()    
        {
            int i=slumpGenerator();
            string[] moståndareArray = { "Berra","Tore", "Agda", "Berit","Gunnar", "Astrid" };

            Name = moståndareArray[i];
            Health = 5;
        }
        public int Kraft()
        {
            return Power;
        }
    }
    class Player : Combat
    {
        public  Player()
        {
            Name = "";
            Power = slumpGenerator();
            Health = 5;
        }
    }
}
