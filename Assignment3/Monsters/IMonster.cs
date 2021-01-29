using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3.Monsters
{
    interface IMonster
    {
        public int attack();
        public void takeDamage(int damage);
        public bool isDead();
        public string getName();
        public int getHp();
        public int getExp();
        public void respawn();

    }
}
