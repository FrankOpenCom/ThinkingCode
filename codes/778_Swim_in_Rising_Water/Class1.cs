using System;
using System.Collections.Generic;
using System.Linq;

namespace _778_Swim_in_Rising_Water
{
    public class Solution
    {
        public int SwimInWater(int[][] grid)
        {
            int[][] weights = Enumerable.Range(0, grid.Length).Select(i => Enumerable.Repeat(int.MaxValue, grid.Length).ToArray()).ToArray();
            weights[0][0] = grid[0][0];

            Dictionary<(int i, int j), int> unVisitedPool = new Dictionary<(int i, int j), int>();

            for (int i = 0; i < grid.Length; ++i)
            {
                for (int j = 0; j < grid.Length; ++j)
                {
                    unVisitedPool.Add((i, j), int.MaxValue);
                }
            }
            unVisitedPool[(0, 0)] = grid[0][0];
            (int i, int j) node = unVisitedPool.Keys.ElementAt(0);
            unVisitedPool.Remove((0, 0));

            while (unVisitedPool.Count > 0)
            {
                (int i, int j)[] adjacentNodes = new (int i, int j)[]
                {
                    (node.i+1, node.j), (node.i, node.j+1),
                    (node.i-1, node.j), (node.i, node.j-1)
                };

                foreach (var (i, j) in adjacentNodes)
                {
                    if (i < 0 || j < 0 || i >= grid.Length || j >= grid.Length) continue;
                    if (unVisitedPool.ContainsKey((i, j)) == false) continue;

                    if (weights[node.i][node.j] != grid[i][j])
                    {
                        weights[i][j] = (weights[node.i][node.j] > grid[i][j]) ? weights[node.i][node.j] : grid[i][j];
                        unVisitedPool[(i, j)] = weights[i][j];
                    }
                }

                //unVisitedPool = unVisitedPool.OrderBy(v => v.Value).ToDictionary(x => x.Key, x => x.Value);
                var ordered = unVisitedPool.OrderBy(v => v.Value);

                node = ordered.ElementAt(0).Key;
                if ((node.i, node.j) == (grid.Length - 1, grid.Length - 1)) 
                    return unVisitedPool[node];

                unVisitedPool.Remove(node);

            }

            return weights[grid.Length - 1][grid.Length - 1];
        }
    }
}


// v1.0
//public class Solution
//{
//    public int SwimInWater(int[][] grid)
//    {
//        if (grid.Length == 0 || grid.Length == 1) return 0;
//        foreach (int[] row in grid)
//        {
//            if (row.Length != grid.GetLength(0)) return 0;
//        }


//        int t = int.MaxValue;
//        List<(int i, int j)> path = new List<(int i, int j)>
//            {
//                (0, 0)
//            };
//        Swimming(ref t, grid[0][0], path, (0, 0), (grid.GetLength(0) - 1, grid.GetLength(0) - 1), grid);
//        return t;
//    }

//    //time should be same to evelvation

//    private void Swimming(ref int maxTime, int elevation, List<(int i, int j)> path, (int i, int j) current, in (int i, int j) destination, in int[][] grid)
//    {
//        if (current == destination)
//        {
//            if (maxTime > elevation) maxTime = elevation;
//            return;
//        }

//        if (elevation >= maxTime) return;

//        if (maxTime == grid[grid.GetLength(0) - 1][grid.GetLength(0) - 1]) return;

//        //Right
//        if (((current.i + 1 + 1) <= grid.GetLength(0)) && !path.Contains((current.i + 1, current.j)) && grid[current.i + 1][current.j] < maxTime)
//        {
//            path.Add((current.i + 1, current.j));
//            Swimming(ref maxTime, (grid[current.i + 1][current.j] > elevation) ? grid[current.i + 1][current.j] : elevation,
//                path, (current.i + 1, current.j), destination, grid);
//            path.RemoveAt(path.Count - 1);
//        }

//        //Down
//        if (((current.j + 1 + 1) <= grid.GetLength(0)) && !path.Contains((current.i, current.j + 1)) && grid[current.i][current.j + 1] < maxTime)
//        {
//            path.Add((current.i, current.j + 1));
//            Swimming(ref maxTime, (grid[current.i][current.j + 1] > elevation) ? grid[current.i][current.j + 1] : elevation,
//                path, (current.i, current.j + 1), destination, grid);
//            path.RemoveAt(path.Count - 1);
//        }

//        //Left
//        if (((current.i - 1) >= 0) && !path.Contains((current.i - 1, current.j)) && grid[current.i - 1][current.j] < maxTime)
//        {
//            path.Add((current.i - 1, current.j));
//            Swimming(ref maxTime, (grid[current.i - 1][current.j] > elevation) ? grid[current.i - 1][current.j] : elevation,
//                path, (current.i - 1, current.j), destination, grid);
//            path.RemoveAt(path.Count - 1);
//        }

//        //Up
//        if (((current.j - 1) >= 0) && !path.Contains((current.i, current.j - 1)) && grid[current.i][current.j - 1] < maxTime)
//        {
//            path.Add((current.i, current.j - 1));
//            Swimming(ref maxTime, (grid[current.i][current.j - 1] > elevation) ? grid[current.i][current.j - 1] : elevation,
//                path, (current.i, current.j - 1), destination, grid);
//            path.RemoveAt(path.Count - 1);
//        }

//        return;
//    }
//}

//2.0
//public class Solution
//{

//    public class LocationComp : IComparer<(int i, int j, int w)>
//    {
//        // Compares by Height, Length, and Width.
//        public int Compare((int i, int j, int w) x, (int i, int j, int w) y)
//        {
//            return x.w.CompareTo(y.w);
//        }
//    }

//    public int SwimInWater(int[][] grid)
//    {
//        int[][] weights = Enumerable.Range(0, grid.Length).Select(i => Enumerable.Repeat(int.MaxValue, grid.Length).ToArray()).ToArray();
//        weights[0][0] = grid[0][0];

//        List<(int i, int j, int w)> unVisitedQueue = new List<(int i, int j, int w)>();

//        for (int i = 0; i < grid.Length; ++i)
//        {
//            for (int j = 0; j < grid.Length; ++j)
//            {
//                unVisitedQueue.Add((i, j, int.MaxValue));
//            }
//        }
//        unVisitedQueue[0] = (0, 0, grid[0][0]);
//        (int i, int j, int w) node = unVisitedQueue[0];
//        unVisitedQueue.RemoveAt(0);

//        while (unVisitedQueue.Count > 0)
//        {

//            (int i, int j)[] adjacentNodes = new (int i, int j)[]
//            {
//                    (node.i+1, node.j), (node.i, node.j+1),
//                    (node.i-1, node.j), (node.i, node.j-1)
//            };

//            bool isSorted = true;
//            foreach (var (i, j) in adjacentNodes)
//            {
//                if (i < 0 || j < 0 || i >= grid.Length || j >= grid.Length) continue;

//                if (weights[node.i][node.j] != grid[i][j])
//                {
//                    for (int index = 0; index < unVisitedQueue.Count; ++index)
//                    {
//                        if (unVisitedQueue[index].i == i && unVisitedQueue[index].j == j)
//                        {
//                            weights[i][j] = (weights[node.i][node.j] > grid[i][j]) ? weights[node.i][node.j] : grid[i][j];
//                            unVisitedQueue[index] = (i, j, weights[i][j]);
//                            isSorted = false;
//                            break;
//                        }
//                    }
//                }
//            }

//            if (isSorted == false)
//            {
//                unVisitedQueue.Sort(new LocationComp());
//            }

//            node = unVisitedQueue[0];
//            unVisitedQueue.RemoveAt(0);

//            if ((node.i, node.j) == (grid.Length - 1, grid.Length - 1))
//                return node.w;
//        }

//        return weights[grid.Length - 1][grid.Length - 1];
//    }
//}