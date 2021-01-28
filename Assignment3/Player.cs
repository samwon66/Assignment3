﻿using Assignment3.Monsters;
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
        private int gold;
        private int xp;
        private int xpToNextLevel = 150;
        private int hp = 200;
        private int atkDmg = 10;
        private bool isDead = true;

        public Player() { }

        public Player(string name, int level, int gold, int xp, int xpToNextLevel, int hp, int atkDmg) 
        {
            this.Name = name;
            this.Level = level;
            this.Gold = gold;
        }

        public int attack(IMonster monster)
        {
            monster.takeDamage(AtkDmg);
            return AtkDmg;
        }

        public string Name { get => name; set => name = value; }
        public int Level { get => level; set => level = value; }
        public int Gold { get => gold; set => gold = value; }
        public int Xp { get => xp; set => xp = value; }
        public int XpToNextLevel { get => xpToNextLevel; set => xpToNextLevel = value; }
        public int Hp { get => hp; set => hp = value; }
        public int AtkDmg { get => atkDmg; set => atkDmg = value; }
        public bool IsDead { get => isDead; set => isDead = value; }

        public void takeDamage(int monsterdmg)
        {
            hp -= monsterdmg;
        }
    }
}