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
 

            int t = -1;
            List<(int i, int j)> path = new List<(int i, int j)>
            {
                (0, 0)
            };
            Swimming(ref t, 0, path, (0, 0), (grid.GetLength(0) - 1, grid.GetLength(0) - 1), grid);
            return (t < 0)? 0:t;
        }

        /*
         * time should be same to evelvation
         */
        private void Swimming(ref int maxTime, int elevation, List<(int i, int j)> path, (int i, int j) current, in (int i, int j) destination, in int[][] grid)
        {
            if (current == destination)
            {
                if (maxTime < 0 || maxTime > elevation) maxTime = elevation;
                return;
            }

            if (maxTime > 0 && maxTime <= elevation) return;

            //Right
            if (((current.i + 1 + 1) <= grid.GetLength(0)) && !path.Contains((current.i + 1, current.j)))
            {
                path.Add((current.i + 1, current.j));
                Swimming(ref maxTime, (grid[current.i + 1][current.j] > elevation)? grid[current.i + 1][current.j] : elevation,
                    path, (current.i + 1, current.j), destination, grid);
                path.RemoveAt(path.Count - 1);
            }

            if (maxTime > 0 && maxTime <= elevation) return;

            //Left
            if (((current.i - 1) >= 0) && !path.Contains((current.i - 1, current.j)))
            {
                path.Add((current.i - 1, current.j));
                Swimming(ref maxTime, (grid[current.i - 1][current.j] > elevation) ? grid[current.i - 1][current.j] : elevation,
                    path, (current.i - 1, current.j), destination, grid);
                path.RemoveAt(path.Count - 1);
            }

            if (maxTime > 0 && maxTime <= elevation) return;

            //Up
            if (((current.j - 1) >= 0) && !path.Contains((current.i, current.j - 1)))
            {
                path.Add((current.i, current.j - 1));
                Swimming(ref maxTime, (grid[current.i][current.j-1] > elevation) ? grid[current.i][current.j-1] : elevation,
                    path, (current.i, current.j - 1), destination, grid);
                path.RemoveAt(path.Count - 1);
            }

            if (maxTime > 0 && maxTime <= elevation) return;

            //Down
            if (((current.j + 1 + 1) <= grid.GetLength(0)) && !path.Contains((current.i, current.j + 1)))
            {
                path.Add((current.i, current.j + 1));
                Swimming(ref maxTime, (grid[current.i][current.j + 1] > elevation) ? grid[current.i][current.j + 1] : elevation,
                    path, (current.i, current.j + 1), destination, grid);
                path.RemoveAt(path.Count - 1);
            }

            return;
        }
    }
}
