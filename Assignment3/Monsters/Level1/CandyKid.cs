using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3.Monsters
{
    class CandyKid : Monster
    {
        public CandyKid() 
        {
            base.Name = "CandyKid";
            base.Level = 1;
            base.Hp = 50;
            base.Xp = 50;
            base.AtkDmg = 5;
            base.MaxHp = 50;
        }

        public override int attack()
        {
            Console.WriteLine("Sweeti, sweeti, get some candy!");
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
            string desc = $"Don't you think I am sweet? I am {Name}";
            return desc;
        }
        


    }
}
