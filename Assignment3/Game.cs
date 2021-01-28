using Assignment3.Monsters;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    class Game
    {
        private bool lostGame = false, wonGame = false;
        private Random random;
        Player player = new Player();
        static List<IMonster> listOfMonsters = new List<IMonster>();

        public Game() { }

        public void rungame()
        {
            SetupGame();
            Console.WriteLine("*****************************************");
            Console.WriteLine("* Welcome to The Adventure of Wasteland *");
            Console.WriteLine("*****************************************");
            Console.WriteLine("Please enter your name: ");
            player.Name = Console.ReadLine();

            int input = -1;

            while (!wonGame && !lostGame)
            {
                printMainMenu();
                Console.WriteLine("You choice: ");
                input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        goAdventure();
                        break;

                    case 2:
                        player.ToString();
                        break;

                    case 3:
                        Console.WriteLine("Thank you for playing, bye!");
                        lostGame = true;
                        break;
                }
                
            }

            if (wonGame)
            {
                Console.WriteLine("Congratulations! You won the game!");
            }
           
        }

        private void SetupGame()
        {
            CandyKid candy = new CandyKid();
            listOfMonsters.Add(candy);
            CrispBull bull = new CrispBull();
            listOfMonsters.Add(bull);
            HotDog hd = new HotDog();
            listOfMonsters.Add(hd);
            HamburgerWorrier hamburger = new HamburgerWorrier();
            listOfMonsters.Add(hamburger);
            PizzaMan pizza = new PizzaMan();
            listOfMonsters.Add(pizza);
            SodaBear soda = new SodaBear();
        }

        private void printMainMenu()
        {
            Console.WriteLine("1. Go adventuring");
            Console.WriteLine("2. Show details about your character");
            Console.WriteLine("3. Exit game");
        }

        private void goAdventure()
        {
            Random rn = new Random();
            int value = rn.Next(listOfMonsters.Count);
            battle(listOfMonsters[value]);

        }

        private void battle(IMonster monster)
        {
            Console.WriteLine($"You encounter a {monster.getName()}");
            while (!monster.isDead())
            {
                Console.WriteLine($"You hit the {monster.getName()} with {player.attack(monster)} dmg");
                Console.WriteLine($"Monster's hp is now: {monster.getHp()}");
                if (monster.isDead())
                {
                    Console.WriteLine($"The monster is dead and you gained {monster.getExp()} xp");
                    monster.isDead();
                    if (player.Level == 10)
                    {
                        Console.WriteLine("Wow, you won the game!");
                        wonGame = true;
                    }
                }
            }
        }
    }
}
