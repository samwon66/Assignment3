using Assignment3.Monsters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Text;

namespace Assignment3
{
    class Player
    {
        private string name;
        private int level = 1;
        private int xp = 0;
        private int xpToNextLevel = 150;
        private int hp = 200;
        private int maxHp = 200;
        private int atkDmg = 10;
       
        Random rn = new Random();

        public Player() { }

        public int attack(IMonster monster)
        {
            int pang = rn.Next(atkDmg);
            monster.takeDamage(pang);
            return pang;
        }

        public void takeDamage(int monsterdmg)
        {
            hp -= monsterdmg;
        }

        public void LevelCheck(int xp)//HP reset och öka efter att man har levlat
        {
            if (xp > xpToNextLevel)
            {
                level++;
                xpToNextLevel += 100;
                hp = maxHp + 40;
                atkDmg += 4;
                Console.WriteLine($"Wow, you level up! You're now Level {Level}");
            }
        }
        
        public override string ToString()
        {
            string status = $"\nName: {Name}\nLevel: {Level}\nHP: {Hp}\nXP: {Xp}\nAttackDamage: {AtkDmg}\n";
            return status;
        }

        public string Name { get => name; set => name = value; }
        public int Level { get => level; set => level = value; }
        public int Xp { get => xp; set => xp = value; }
        public int XpToNextLevel { get => xpToNextLevel; set => xpToNextLevel = value; }
        public int Hp { get => hp; set => hp = value; }
        public int MaxHp { get => maxHp; set => maxHp = value; }
        public int AtkDmg { get => atkDmg; set => atkDmg = value; }
      
    }
}
