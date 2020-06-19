using System;
using System.Collections.Generic;

namespace _778_Swim_in_Rising_Water
{
    public class Solution
    {
        public int SwimInWater(int[][] grid)
        {
            if (grid.Length == 0 || grid.Length == 1) return 0;
            foreach (int [] row in grid)
            {
                if (row.Length != grid.GetLength(0)) return 0;
            }
 

            int t = int.MaxValue;
            List<(int i, int j)> path = new List<(int i, int j)>
            {
                (0, 0)
            };
            Swimming(ref t, grid[0][0], path, (0, 0), (grid.GetLength(0) - 1, grid.GetLength(0) - 1), grid);
            return t;
        }

        /*
         * time should be same to evelvation
         */
        private void Swimming(ref int maxTime, int elevation, List<(int i, int j)> path, (int i, int j) current, in (int i, int j) destination, in int[][] grid)
        {
            if (current == destination)
            {
                if (maxTime > elevation) maxTime = elevation;
                return;
            }

            if (elevation >= maxTime) return;

            if (maxTime == grid[grid.GetLength(0) - 1][grid.GetLength(0) - 1]) return;

            //Right
            if (((current.i + 1 + 1) <= grid.GetLength(0)) && !path.Contains((current.i + 1, current.j)) && grid[current.i + 1][current.j] < maxTime)
            {
                path.Add((current.i + 1, current.j));
                Swimming(ref maxTime, (grid[current.i + 1][current.j] > elevation)? grid[current.i + 1][current.j] : elevation,
                    path, (current.i + 1, current.j), destination, grid);
                path.RemoveAt(path.Count - 1);
            }

            //Down
            if (((current.j + 1 + 1) <= grid.GetLength(0)) && !path.Contains((current.i, current.j + 1)) && grid[current.i][current.j + 1] < maxTime)
            {
                path.Add((current.i, current.j + 1));
                Swimming(ref maxTime, (grid[current.i][current.j + 1] > elevation) ? grid[current.i][current.j + 1] : elevation,
                    path, (current.i, current.j + 1), destination, grid);
                path.RemoveAt(path.Count - 1);
            }

            //Left
            if (((current.i - 1) >= 0) && !path.Contains((current.i - 1, current.j)) && grid[current.i - 1][current.j] < maxTime)
            {
                path.Add((current.i - 1, current.j));
                Swimming(ref maxTime, (grid[current.i - 1][current.j] > elevation) ? grid[current.i - 1][current.j] : elevation,
                    path, (current.i - 1, current.j), destination, grid);
                path.RemoveAt(path.Count - 1);
            }

            //Up
            if (((current.j - 1) >= 0) && !path.Contains((current.i, current.j - 1)) && grid[current.i][current.j - 1] < maxTime)
            {
                path.Add((current.i, current.j - 1));
                Swimming(ref maxTime, (grid[current.i][current.j-1] > elevation) ? grid[current.i][current.j-1] : elevation,
                    path, (current.i, current.j - 1), destination, grid);
                path.RemoveAt(path.Count - 1);
            }

            return;
        }
    }
}
