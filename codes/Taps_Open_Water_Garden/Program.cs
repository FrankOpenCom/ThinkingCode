using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// https://leetcode.com/problems/minimum-number-of-taps-to-open-to-water-a-garden/

namespace Taps_Open_Water_Garden
{
    public class Solution
    {
        public int MinTaps(int n, int[] ranges)
        {
            List<(int l, int r, int c)> taps = new List<(int l, int r, int c)>();
            
            for (int i=0; i<ranges.Length; ++i)
            {
                if (ranges[i] == 0) continue;
                (int l, int r, int c) item = (i-ranges[i], i+ranges[i], 0);
                if (item.l < 0) item.l = 0;
                if (item.r > n) item.r = n;
                item.c = item.r - item.l;

                taps.Add(item);
            }

            taps = taps.OrderBy(x => x.c).ToList();

            

            return 0;
        }
    }
}
