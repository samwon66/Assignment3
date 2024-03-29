﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3.Monsters
{
    class PizzaMan : Monster
    {
        public PizzaMan()
        {
            base.Name = "PizzaMan";
            base.Level = 2;
            base.Xp = 130;
            base.Hp = 150;
            base.AtkDmg = 14;
            base.MaxHp = 150;
        }

        public override int attack()
        {
            Console.WriteLine("Let me slice you up!");
            return base.attack();
        }
        public override int getExp()
        {
            return base.getExp();
        }

        public override int getHp()
        {
            return base.getHp();
        }

        public override string getName()
        {
            return base.getName();
        }

        public override bool isDead()
        {
            return base.isDead();
        }

        public override void takeDamage(int damage)
        {
            base.takeDamage(damage);
        }

        public override void respawn()
        {
            base.respawn();
        }

        public override string ToString()
        {
            string desc = $"Delicious, I am {Name}.";
            return desc;
        }
    }
}
