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
            Swimming(ref t, 0, (0, 0), (0, 1), (grid.GetLength(0) - 1, grid.GetLength(1) - 1), grid);
            Swimming(ref t, 0, (0, 0), (1, 0), (grid.GetLength(0) - 1, grid.GetLength(1) - 1), grid);
            return t;
        }

        /*
         * time should be same to evelvation
         */
        private void Swimming(ref int maxTime, int elevation, (int i, int j) current, (int i, int j) next, (int i, int j) destination, in int[][] grid)
        {

            return;
        }
    }
}
