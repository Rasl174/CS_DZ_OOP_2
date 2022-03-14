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

            spawn.SpawnPlayer(player.PositionX, player.PositionY);
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
            PositionX = x;
            PositionY = y;
        }

        public int PositionX { get; private set; }

        public int PositionY { get; private set; }
    }
}
