using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceShipBattle
{
    class SpaceshipLaser : Spaceship
    {
        // spaceship with extra laser strength - more attack damage
        public SpaceshipLaser() : base()
        {
            Attack += 50;
        }
        public override string Type()
        {
            return "spaceship-laser";
        }

    }
}
