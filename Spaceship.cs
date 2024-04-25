using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceShipBattle
{
    public class Spaceship
    {
        public virtual int Attack { get; set; }
        public virtual int Health { get; set; }
        public Spaceship()
        {
            Attack = 100;
            Health = 300;
        }
        public virtual int GetNextAttack()
        {
            return Attack;
        }
        public virtual string Type()
        {
            return "spaceship";
        }
    }
}
