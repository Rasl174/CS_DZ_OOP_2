using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_DZ_OOP_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Spawn spawn = new Spawn();

            Player player = new Player(5, 10);

            spawn.SpawnPlayer(player.X, player.Y);
        }
    }

    class Spawn
    {
        public void SpawnPlayer(int x, int y, char symbolPlayer = '#')
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symbolPlayer);
        }
    }

    class Player
    {
        public Player(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; private set; }

        public int Y { get; private set; }
    }
}
