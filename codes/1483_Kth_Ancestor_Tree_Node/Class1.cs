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
            height = (int)Math.Ceiling(Math.Log(n, 2));
            table = new List<List<int>>
            {
                Capacity = n
            };

            for (int i = 0; i < n; ++i)
            {
                table.Add(new List<int>() { Capacity = height });
            }

            for (int h=0; h<height; ++h)
            {
                for (int i=0; i<n; ++i)
                {
                    if (h == 0) table[i].Add(parent[i]);
                    else if (table[i].Count >= h && table[i][h-1] != -1)
                    {
                        if (table[table[i][h - 1]].Count > (h - 1))
                            table[i].Add(table[table[i][h - 1]][h - 1]);
                        else
                            table[i].Add(-1);
                    }
                }
            }
        }

        public int GetKthAncestor(int node, int k)
        {
            for (int i=0; i<height; ++i)
            {
                if ((k & (1 << i)) != 0)
                {
                    if (table[node].Count > i)
                        node = table[node][i];
                    else
                        node = -1;
                    if (node == -1) break;
                }
            }

            return node;
        }

        List<List<int>> table;
        int height;
    }

    /**
     * Your TreeAncestor object will be instantiated and called as such:
     * TreeAncestor obj = new TreeAncestor(n, parent);
     * int param_1 = obj.GetKthAncestor(node,k);
     */
}
