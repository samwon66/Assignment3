using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3.Monsters
{
    class HotDog : Monster
    {
        public HotDog()
        {
            base.Name = "HotDog";
            base.Level = 1;
            base.Xp = 100;
            base.Hp = 60;
            base.AtkDmg = 10;
            base.MaxHp = 60;
        }

        public override int attack()
        {
            Console.WriteLine("Wow wow, here I bite!");
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
            string desc = $"I am hot, I am dog, I am {Name}";
            return desc;
        }

    }
}
