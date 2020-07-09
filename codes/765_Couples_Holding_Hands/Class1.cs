using System;
using System.Collections.Generic;
using System.Linq;

// https://leetcode.com/problems/couples-holding-hands/

namespace _765_Couples_Holding_Hands
{
    public class Solution
    {
        public bool IsCouple(int x, int y)
        {
            if ((x % 2 == 0 && y == x + 1) || (y % 2 == 0 && x == y + 1)) 
                return true;
            return false;
        }

        public int MinSwapsCouples(int[] row)
        {
            List<int> couples = row.ToList();
            int swapTimes = 0;

            for (int i = 0; i < couples.Count-1; )
            {
                if (IsCouple(couples[i], couples[i + 1])) 
                    couples.RemoveRange(i, 2);
                else 
                    i += 2;
            }

            while (couples.Count > 0)
            {
                int x = couples[0];
                int y = couples[1];
                int xCouple;

                if (x % 2 == 0) xCouple = x + 1;
                else xCouple = x - 1;

                couples.RemoveRange(0, 2);
                int location = couples.FindIndex(n => n == xCouple);
                couples[location] = y;

                if ((location % 2 == 0 && y % 2 == 0 && couples[location + 1] == y + 1) ||
                    (location % 2 == 0 && y % 2 != 0 && couples[location + 1] == y - 1))
                {
                    couples.RemoveRange(location, 2);
                }
                else if ((location % 2 != 0 && y % 2 == 0 && couples[location - 1] == y + 1) ||
                    (location % 2 != 0 && y % 2 != 0 && couples[location - 1] == y - 1) )
                {
                    couples.RemoveRange(location-1, 2);
                }

                swapTimes++;
            }

            return swapTimes;
        }
    }
}
