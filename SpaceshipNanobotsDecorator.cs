using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceShipBattle
{
    class SpaceshipNanobotsDecorator : SpaceshipDecorator
    {
        public SpaceshipNanobotsDecorator(Spaceship spaceship) : base(spaceship) { }

        public override int GetNextAttack()
        {
            int attack = decoratedSpaceship.GetNextAttack();
            decoratedSpaceship.Health += 50;
            return attack;
        }
    }
}
