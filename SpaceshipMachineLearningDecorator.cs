using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceShipBattle
{
    class SpaceshipMachineLearningDecorator : SpaceshipDecorator
    {
        public SpaceshipMachineLearningDecorator(Spaceship spaceship) : base(spaceship) { }

        public override int GetNextAttack()
        {
            int attack = decoratedSpaceship.GetNextAttack();
            decoratedSpaceship.Attack += 25;
            return attack;
        }
    }
}