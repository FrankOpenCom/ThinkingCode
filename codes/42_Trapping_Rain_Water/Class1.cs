using System;
using System.Linq;

namespace _42_Trapping_Rain_Water
{
    public class Solution
    {
        public int Trap(int[] height)
        {
            if (height.Length <= 2) return 0;

            int[] water = new int[height.Length];
            int highest = height[0];

            for (int i=0; i<height.Length; i++)
            {
                int bar = height[i];
                if (bar == highest)
                {
                    water[i] = 0;
                }
                else if (bar < highest)
                {
                    water[i] = highest - bar;
                }
                else if (bar > highest)
                {
                    highest = bar;
                    water[i] = 0;
                }
            }

            if (water.Last() > 0)
            {
                highest = height.Last();
                for (int i = water.Length-1; i>=0 && water[i] > 0; --i)
                {
                    if (highest == height[i]) water[i] = 0;
                    else if (highest > height[i]) water[i] = highest - height[i];
                    else 
                    {
                        highest = height[i];
                        water[i] = 0;
                    }  
                }
            }

            return water.Sum();
        }
    }
}


/*  //1.0
    public class Solution
    {
        public int Trap(int[] height)
        {
            int ability = 0;
            bool leftBar = false;
            bool onlyOneBar = true;
            int cAbility = 0;

            for (int i=0; i < height.Length; )
            {
                int bar = height[i];
                
                if (bar > 0)
                {
                    if (leftBar == false)
                    {
                        leftBar = true;
                    }
                    else
                    {
                        ability += cAbility;
                        onlyOneBar = false;
                    }
                    cAbility = 0;
                }
                else
                {
                    ++cAbility;
                }

                if (bar > 0) --height[i];

                if ((i + 1) == height.Length)
                {
                    if (leftBar == false || onlyOneBar == true) break;
                    else
                    {
                        i = 0;
                        leftBar = false;
                        cAbility = 0;
                        onlyOneBar = true;
                    }
                }
                else ++i;
      
            }

            return ability;
        }
    }
 */
