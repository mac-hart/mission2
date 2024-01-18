using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dice
{
    internal class DiceRoller
    {
        public Random random = new Random();

        public int[] Sim(int numRolls)
        { //results to be sent to first class
            int[] results = new int[13];
            // for loop to produce random numbers
            for (int iCount = 0; iCount < numRolls; iCount++)
            {
                int dice1 = random.Next(1, 7);
                int dice2 = random.Next(1, 7);
                int sum = dice1 + dice2;

                results[sum]++;
            }

            return results;
        }
    }
}
