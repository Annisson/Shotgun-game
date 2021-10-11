using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Shotgun
{
    public class Opponent : Player
    {
        public override int BulletsCount { get; set; }
        public override int WinCount { get; set; }
        
        private enum opponentMove
        {
            load,
            shoot,
            block,
            shotgun
        }

        public string OpponentChoice(int bulletsLeft)
        {

            if (bulletsLeft == 0) 
            {
                return opponentMove.load.ToString();
            }

            else if (bulletsLeft == 1 || bulletsLeft == 2) 
            {
                Random random = new Random();

                string outcome = "";
                switch (random.Next(1, 4))
                {
                    case 1: 
                        outcome = opponentMove.load.ToString();
                        break;
                    case 2: 
                        outcome = opponentMove.shoot.ToString();
                        break;
                    case 3: 
                        outcome = opponentMove.block.ToString();
                        break;
                }
                return outcome;
            }

            else 
            {
                return opponentMove.shotgun.ToString();
            }

        }

    }
}
