using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuesNumber
{
    class Player2:Player
    {
        public  void Player02()
        {
            lock (locker)
            {
               
                Random rnd = new Random();
                int r = rnd.Next(1000);
                if (r ==Program.number)
                {
                    Program.EndOfGame[1] = 1;
                }
                else
                {
                    Program.stuck[r] = 1;              
                }
                
            }
            
        }
    }
}
