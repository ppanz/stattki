using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceShipBattle
{
    class RunBattle
    {
        public static void Run()
        {
            // prepare spaceships
            Spaceship s1 = new SpaceshipLaser();
            SpaceshipDecorator s12 = new SpaceshipExtraCannonDecorator(s1);
            SpaceshipLaser s2 = new SpaceshipLaser();
            SpaceshipExtraCannon s3 = new SpaceshipExtraCannon();
            SpaceshipMachineLearning s4 = new SpaceshipMachineLearning();
            SpaceshipNanobots s5 = new SpaceshipNanobots();
            List<Spaceship> tournamentList = new List<Spaceship>() { s12 , s2, s3, s4, s5 };

            // run tournament
            for (int i = 0; i < tournamentList.Count; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    // remember original statistics
                    int hp1 = tournamentList[i].Health;
                    int hp2 = tournamentList[j].Health;
                    int at1 = tournamentList[i].Attack;
                    int at2 = tournamentList[j].Attack;
                    // play this round
                    Console.WriteLine();
                    Console.WriteLine(tournamentList[i].Type() + " (" + tournamentList[i].Health + " HP) vs "
                            + tournamentList[j].Type() + " (" + tournamentList[j].Health + " HP)");
                    do
                    {
                        int attack1 = tournamentList[i].GetNextAttack();
                        int attack2 = tournamentList[j].GetNextAttack();
                        tournamentList[j].Health -= attack1;
                        tournamentList[i].Health -= attack2;
                        Console.WriteLine(tournamentList[i].Type() + " (" + tournamentList[i].Health + " HP) vs "
                            + tournamentList[j].Type() + " (" + tournamentList[j].Health + " HP)");
                    } while (tournamentList[j].Health > 0 && tournamentList[i].Health > 0);
                    if (tournamentList[j].Health > tournamentList[i].Health) Console.WriteLine("winner: " + tournamentList[j].Type());
                    else if (tournamentList[i].Health > tournamentList[j].Health) Console.WriteLine("winner: " + tournamentList[i].Type());
                    else Console.WriteLine("draw!");
                    // restore original statistics
                    tournamentList[i].Health = hp1;
                    tournamentList[j].Health = hp2;
                    tournamentList[i].Attack = at1;
                    tournamentList[j].Attack = at2;
                }
            }

        }
    }
}
