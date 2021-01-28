using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3.Monsters
{
    class CrispBull : Monster
    {
        public CrispBull() 
        {
            base.Name = "CrispBull";
            base.Level = 1;
            base.Xp = 80;
            base.Hp = 90;
            base.AtkDmg = 8;
            base.MaxHp = 90;
        }

        public override int attack()
        {
            Console.WriteLine("Let me make you crispy!");
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

        public override string ToString()
        {
            string desc = $"Crispy or not, I am {Name}";
            return desc;
        }




    }
}
