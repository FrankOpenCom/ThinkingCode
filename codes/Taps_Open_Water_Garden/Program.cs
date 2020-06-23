using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

// https://leetcode.com/problems/minimum-number-of-taps-to-open-to-water-a-garden/

namespace Taps_Open_Water_Garden
{
    public class Solution
    {
        public int MinTaps(int n, int[] ranges)
        {
            SortedList<int, int> taps = new SortedList<int, int>();
            
            for (int i=0; i<ranges.Length; ++i)
            {
                if (ranges[i] == 0) continue;
                int l = (i - ranges[i] < 0)? 0:i-ranges[i];
                int r = (i + ranges[i] > n) ? n : i + ranges[i];

                List<int> ilistKeys = new List<int>(taps.Keys);
                foreach (int left in ilistKeys)
                {
                    if (left < l && taps[left] >= r)
                    {
                        l = r = 0;
                        break;
                    }

                    if (left > l && taps[left] <= r)
                    {
                        taps.Remove(left);
                    }
                    else if (left < l && taps[left] < r && taps[left] > l)
                    {
                        l = taps[left];
                    }
                    else if (left > l && left < r && taps[left] > r)
                    {
                        r = left;
                    }
                }

                if (l != r)
                {
                    if (taps.ContainsKey(l))
                    {
                        if (taps[l] < r) taps[l] = r;
                    }
                    else
                    {
                        taps.Add(l, r);
                    }
                }
            }

            IList<int> Keys = taps.Keys;
            int ll = n, rr = 0;
            foreach (int left in Keys)
            {
                if (left < ll) ll = left;
                if (taps[left] > rr) rr = taps[left];
            }

            if (ll == 0 && rr == n) return taps.Count;
            return -1;
        }
    }
}
