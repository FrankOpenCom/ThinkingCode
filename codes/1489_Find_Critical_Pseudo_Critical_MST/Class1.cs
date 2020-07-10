using System;
using System.Collections.Generic;
using System.Linq;

//https://leetcode.com/problems/find-critical-and-pseudo-critical-edges-in-minimum-spanning-tree/

namespace _1489_Find_Critical_Pseudo_Critical_MST
{
    public class Solution
    {
        public int BuildMST(int n, List<(int index, int from, int to, int weight)> es, int reserveEdge, int skipEdge)
        {
            int weight = 0;
            List<HashSet<int>> disjointSets = new List<HashSet<int>>();
            List<(int index, int from, int to, int weight)> edges = es.ToList();

            if (reserveEdge >= 0)
            {
                (int index, int from, int to, int weight) skip = edges.Find(x => x.index == reserveEdge);
                disjointSets.Add(new HashSet<int>() { skip.from, skip.to });
                weight += skip.weight;
                edges.Remove(skip);
            }

            while (edges.Count > 0)
            {
                int pf = edges.First().from;
                int pt = edges.First().to;
                int index = edges.First().index;
                int w = edges.First().weight;

                edges.RemoveAt(0);

                if (index == skipEdge)
                    continue;

                int indexPf = disjointSets.FindIndex(x => x.Contains(pf));
                int indexPt = disjointSets.FindIndex(x => x.Contains(pt));

                if (indexPf == indexPt && indexPt != -1) 
                    continue;
                
                if (indexPf == -1 && indexPt == -1)
                {
                    disjointSets.Add(new HashSet<int>() { pf, pt });
                }
                else if (indexPf == -1 && indexPt != -1)
                {
                    disjointSets[indexPt].Add(pf);
                }
                else if (indexPf != -1 && indexPt == -1)
                {
                    disjointSets[indexPf].Add(pt);
                }
                else
                {
                    disjointSets[indexPf].UnionWith(disjointSets[indexPt]);
                    disjointSets.RemoveAt(indexPt);
                }

                weight += w;

                if (disjointSets[0].Count == n && disjointSets.Count == 1) 
                    break;
            }

            if (disjointSets.Count != 1 || disjointSets[0].Count < n) return int.MaxValue;

            return weight;
        }

        public IList<IList<int>> FindCriticalAndPseudoCriticalEdges(int n, int[][] edges)
        {
            List<List<int>> edgesRet = new List<List<int>>() { new List<int>(), new List<int>()};
            List<(int index, int from, int to, int weight)> edgesPool = edges.Select(x => (Array.IndexOf(edges, x), x[0], x[1], x[2])).ToList();
            edgesPool = edgesPool.OrderBy(x => x.weight).ToList();

            int minSpanning = BuildMST(n, edgesPool, -1, -1);

            if (minSpanning == int.MaxValue) return new List<IList<int>>() { new List<int>(), new List<int>()};

            foreach ((int index, int from, int to, int weight) in edgesPool)
            {
                if (BuildMST(n, edgesPool, -1, index) > minSpanning) 
                    edgesRet[0].Add(index);
                else if (BuildMST(n, edgesPool, index, -1) == minSpanning) 
                    edgesRet[1].Add(index);
            }

            return new List<IList<int>>() { edgesRet[0], edgesRet[1] };
        }
    }
}
