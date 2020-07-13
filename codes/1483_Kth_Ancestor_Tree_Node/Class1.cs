using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

// https://leetcode.com/problems/kth-ancestor-of-a-tree-node/

namespace _1483_Kth_Ancestor_Tree_Node
{
    public class TreeAncestor
    {
        public TreeAncestor(int n, int[] parent)
        {
            table = new List<List<int>>();

            for (int i = 0; i < n; ++i)
            {
                table.Add(new List<int>() { i });
                while (table[i].Last() != -1)
                {
                    table[i].Add(parent[table[i].Last()]);
                }
            }
        }

        public int GetKthAncestor(int node, int k)
        {
            if (table[node].Count <= k) return -1;
            return table[node][k];
        }

        List<List<int>> table;
    }

    /**
     * Your TreeAncestor object will be instantiated and called as such:
     * TreeAncestor obj = new TreeAncestor(n, parent);
     * int param_1 = obj.GetKthAncestor(node,k);
     */
}
