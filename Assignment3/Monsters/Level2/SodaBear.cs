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
            base.Xp = 150;
            base.Hp = 160;
            base.AtkDmg = 16;
            base.MaxHp = 160;
        }

        public override int attack()
        {
            Console.WriteLine("Spray, spray, I will drunk you!");
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
            string desc = $"Let's rock, I am {Name}.";
            return desc;
        }
    }
}
