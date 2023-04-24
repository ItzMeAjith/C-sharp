using System;
using System.ComponentModel;
using System.Xml.Linq;

namespace Game_Inheritance
{
    class Game
    {
        public string Name { get; set; }
        public int maxPlayers { get; set; }

        public virtual string ToString()
        {
            return $"Maximum players for {Name} is {maxPlayers}";
        }
    }
    class GameWithTImelimit:Game
    {
        public int timeLimit { get; set; }
        public override string ToString()
        {
            Console.WriteLine(base.ToString());
            return $"The time limit for {Name} is {timeLimit}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            GameWithTImelimit gm=new GameWithTImelimit();
            Console.Write("Enter the game : ");
            gm.Name = Console.ReadLine();
            Console.Write("Enter the maximum number of players : ");
            gm.maxPlayers = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the game that has time limit: ");
            gm.Name = Console.ReadLine();
            Console.Write("Enter the maximum number of players : ");
            gm.maxPlayers = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the time limits in minutes : ");
            gm.timeLimit= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(gm.ToString());

        }
    }
}