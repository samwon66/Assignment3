using Assignment3.Monsters;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    class Game
    {
        private bool lostGame, wonGame;
        private Random random;
        Player p1 = new Player();
        static List<IMonster> listOfMonsters = new List<IMonster>();

        public Game() { }

        public void rungame()
        {
            SetupGame();
            Console.WriteLine("*****************************************");
            Console.WriteLine("* Welcome to The Adventure of Wasteland *");
            Console.WriteLine();
        }

        private void SetupGame()
        {

        }

    }
}
