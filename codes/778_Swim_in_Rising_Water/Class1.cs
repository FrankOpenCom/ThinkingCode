using System;

namespace _778_Swim_in_Rising_Water
{
    public class Solution
    {
        public int SwimInWater(int[][] grid)
        {
            if (grid.Length == 0 || grid.Length == 1) return 0;
            if (grid.GetLength(0) != grid.GetLength(1)) return 0;

            int t = -1;
            Swimming(ref t, 0, null, (0, 0), (grid.GetLength(0) - 1, grid.GetLength(1) - 1), grid);
            return (t < 0)? 0:t;
        }

        /*
         * time should be same to evelvation
         */
        private void Swimming(ref int maxTime, int elevation, (int i, int j)? previous, (int i, int j) current, in (int i, int j) destination, in int[][] grid)
        {
            if (current == destination)
            {
                if (maxTime > elevation) maxTime = elevation;
                return;
            }

            if (maxTime > 0 && maxTime <= elevation) return;

            (int i, int j) next = (current.i, current.j);

            //Right
            if (((next.i + 1 + 1) <= grid.GetLength(0)) && ((next.i+1, next.j) != previous))
            {
                ++next.i;
                if (grid[next.i][next.j] > elevation)
                {
                    elevation = grid[next.i][next.j];
                }

                Swimming(ref maxTime, elevation, current, next, destination, grid);
            }

            //Left
            if (((next.i - 1) >= 0) && ((next.i - 1, next.j) != previous))
            {

            }

            //Up
            if (((next.j - 1) >= 0) && ((next.i, next.j - 1) != previous))
            {

            }

            //Down
            if (((next.j + 1 + 1) <= grid.GetLength(1)) && ((next.i, next.j + 1) != previous))
            {

            }
            return;
        }
    }
}
