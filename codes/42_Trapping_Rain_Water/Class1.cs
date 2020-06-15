using System;

namespace _42_Trapping_Rain_Water
{
    public class Solution
    {
        public int Trap(int[] height)
        {
            int ability = 0;
            bool leftBar = false;
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
                    if (leftBar == false) break;
                    else
                    {
                        i = 0;
                        leftBar = false;
                        cAbility = 0;
                    }
                }
                else ++i;
      
            }

            return ability;
        }
    }
}
