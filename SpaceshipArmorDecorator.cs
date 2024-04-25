using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceShipBattle
{
    class SpaceshipArmorDecorator : SpaceshipDecorator
    {
        public SpaceshipArmorDecorator(Spaceship spaceship) : base(spaceship) { }

        public override int Health
        {
            get { return decoratedSpaceship.Health + 100; }
            set { decoratedSpaceship.Health = value; }
        }
    }
}