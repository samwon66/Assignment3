using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3.Monsters
{
    class SodaBear : Monster
    { 
        public SodaBear()
        {
            base.Name = "SodaBear";
            base.Level = 2;
            base.Xp = 130;
            base.Hp = 200;
            base.AtkDmg = 200;
            base.MaxHp = 200;
        }

        public override int attack()
        {
            Console.WriteLine("You don't belong here, have some fries!");
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
            string desc = $"I am {Name}, wanna have a bite?";
            return desc;
        }
    }
}
