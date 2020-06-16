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
