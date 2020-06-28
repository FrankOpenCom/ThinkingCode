using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://leetcode.com/problems/distinct-subsequences/

namespace _115_Distinct_Subsequences
{
    public class Nodes
    {
        public Nodes(int _pos)
        {
            pos = _pos;
        }

        public int pos { get;}
        public List<Nodes> nexts { get;}
    }
    public class Solution
    {
        public int NumDistinct(string s, string t)
        {
            Nodes tree = new Nodes(-1);

            for (int i=0; i<t.Length; ++i)
            {
                
                char c = t[i];
                int index = -1;

                do
                {
                    index = s.IndexOf(c, index + 1);
                    if (index >= 0)
                    {
                        Nodes n = new Nodes(index);
                    }
                } while (index < 0);

            }

            

            return 0;
        }
    }
}
