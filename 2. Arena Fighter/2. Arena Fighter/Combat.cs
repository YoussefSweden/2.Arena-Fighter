using System;
//using System.Collections.Generic;
//using System.Text;

namespace _2._Arena_Fighter
{
    class Combat
    {
        static Random slump = new Random();
        public int strength = slumpGenerator();
        public static int slumpGenerator()
        {
            return slump.Next(1, 6);
        }
    }

    class Motståndare : Combat
    {
        public string Name { get; set; }
        public int Power { get; set; }
        public int Health { get; set; }
        public Motståndare()
        {
            Name = "Motståndare";
          
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
            Name = "Jag";
            Power = slumpGenerator();
            Health = 5;
        }
    }

}
