using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceShipBattle
{
    class SpaceshipLaserDecorator : SpaceshipDecorator
    {
        public SpaceshipLaserDecorator(Spaceship spaceship) : base(spaceship) { }

        public override int Attack
        {
            get { return decoratedSpaceship.Attack + 50; }
            set { decoratedSpaceship.Attack = value; }
        }
    }
}