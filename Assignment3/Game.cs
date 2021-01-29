using Assignment3.Monsters;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Assignment3
{
    class Game
    {
        private bool lostGame = false, wonGame = false;
        public Player player = new Player();
        static List<IMonster> listOfMonsters1 = new List<IMonster>();
        static List<IMonster> listOfMonsters2 = new List<IMonster>();

        public Game() { }

        public void Rungame()
        {
            SetupGame();
            Console.WriteLine("*****************************************");
            Console.WriteLine("* Welcome to The Adventure of Wasteland *");
            Console.WriteLine("*****************************************");
            
            Console.WriteLine("/nDo you want to be God? y/n");
            char answer = Convert.ToChar(Console.ReadLine());
            if (answer == 'y' || answer == 'Y')
            {
                player.Hp = 2000;
                player.AtkDmg = 50;
            }

            Console.Write("Please enter your name: ");
            player.Name = Console.ReadLine();
            Console.WriteLine($"Your status:\n{player.ToString()}");
            
            while (!wonGame && !lostGame)
            {
                PrintMainMenu();
                Option();
                player.LevelCheck(player.Xp);
                
                
            }

            if (wonGame)
            {
                Console.WriteLine("Congratulations! You won the game!");
            }
           
        }

        //private void godMode()
        //{
        //    player.Hp = 2000;
        //    player.AtkDmg = 100;
        //    Console.Clear();
        //    Console.WriteLine("\nSo you want to be God. \nSorry, our God is not immortal, but he has a better status than us.\nNo one walks safely in Wasteland, not even God... ");
        //    Console.WriteLine($"Your new status:\n{player.ToString()}");
        //}

        private void SetupGame()
        {
            CandyKid candy = new CandyKid();
            listOfMonsters1.Add(candy);
            CrispBull bull = new CrispBull();
            listOfMonsters1.Add(bull);
            HotDog hd = new HotDog();
            listOfMonsters1.Add(hd);
            HamburgerWorrier hamburger = new HamburgerWorrier();
            listOfMonsters2.Add(hamburger);
            PizzaMan pizza = new PizzaMan();
            listOfMonsters2.Add(pizza);
            SodaBear soda = new SodaBear();
            listOfMonsters2.Add(soda);
        }

        private void PrintMainMenu()
        {
            Console.WriteLine("1. Go adventuring");
            Console.WriteLine("2. Show details about your character");
            Console.WriteLine("3. Exit the game");
            Console.Write("You choice: ");
        }

        private void Option()
        {
            int input = -1;
            try
            {
                input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        GoAdventure();
                        break;

                    case 2:
                        Console.WriteLine(player);
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 3:
                        Console.WriteLine("Thank you for playing, bye!");
                        lostGame = true;
                        break;
                }

            }
            catch (System.FormatException)
            {
                Console.WriteLine("\nInvalid input, please try again!");
            }
        }

        private void GoAdventure()
        {
            Console.Clear();
            Console.WriteLine("So you are looking for adventure in Wasteland.\n ");
            Random random = new Random();
            int scenario = random.Next(9);
            if (scenario == 1)
            {
                Console.WriteLine("You just wander around and nothing happen....yet.");
            }
            else
            {
                if (player.Level <= 4)
                {
                    int value = random.Next(listOfMonsters1.Count);
                    Battle(listOfMonsters1[value]);
                }
                else
                {
                    int value = random.Next(listOfMonsters2.Count);
                    Battle(listOfMonsters2[value]);
                }
            }
            RespawnMonster();
            

        }

        private void Battle(IMonster monster)
        {
            Console.WriteLine($"You encounter a {monster.getName()}");
            while (!monster.isDead())
            {
                Console.WriteLine($"You hit the {monster.getName()} for {player.attack(monster)} dmg");
                Console.WriteLine($"Monster's hp is now: {monster.getHp()}");
                
                if (monster.isDead())
                {
                    Console.WriteLine($"The monster is dead and you gained {monster.getExp()} xp");
                    player.Xp += monster.getExp();
                    Console.WriteLine($"Your XP is now {player.Xp}\n");

                    //monster.isDead();
                    if (player.Level == 10)
                    {
                        Console.WriteLine("Wow, you won the game!");
                        Console.ReadKey();
                        wonGame = true;
                    }
                    return;
                    
                }
                else if (player.Hp <= 0)
                {
                    Console.WriteLine("You are defeated, game over!");
                    Console.ReadKey();
                    lostGame = true;
                }

                Console.ReadKey();
                int monsterdmg = monster.attack();
                Console.WriteLine($"The monster hit you for {monsterdmg}");
                player.takeDamage(monsterdmg);
                Console.WriteLine($"Your current HP is: {player.Hp}");
                Console.ReadKey();

            }
            monster.respawn();
        }

        private void RespawnMonster()
        {
            foreach (Monster m in listOfMonsters1)
            {
                m.respawn();
            }

            foreach (Monster m in listOfMonsters2)
            {
                m.respawn();
            }
        }
    }
}
