using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceShipBattle
{
    abstract class SpaceshipDecorator : Spaceship
    {
        protected Spaceship decoratedSpaceship;

        public SpaceshipDecorator(Spaceship spaceship)
        {
            this.decoratedSpaceship = spaceship;
        }

        public override int Attack
        {
            get { return decoratedSpaceship.Attack; }
            set { decoratedSpaceship.Attack = value; }
        }

        public override int Health
        {
            get { return decoratedSpaceship.Health; }
            set { decoratedSpaceship.Health = value; }
        }

        public override int GetNextAttack()
        {
            return decoratedSpaceship.GetNextAttack();
        }

        public override string Type()
        {
            return decoratedSpaceship.Type();
        }
    }
}
