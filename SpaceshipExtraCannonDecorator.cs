using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceShipBattle
{
    class SpaceshipExtraCannonDecorator : SpaceshipDecorator
    {
        public SpaceshipExtraCannonDecorator(Spaceship spaceship) : base(spaceship) { }

        public override int GetNextAttack()
        {
            Random RNG = new Random();
            if (RNG.Next(2) == 0) return decoratedSpaceship.GetNextAttack();
            else return decoratedSpaceship.GetNextAttack() + decoratedSpaceship.GetNextAttack();
        }
    }
}