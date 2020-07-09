using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;

// https://leetcode.com/problems/parallel-courses-ii/

namespace _1494_Parallel_Courses_II
{
    public class Solution
    {
        public class Course
        {
            public Course(int _id)
            {
                id = _id;
                depth = 0;
                next = new List<int>();
                prev = new List<int>();
            }

            public int Id 
            {
                get => id;
            }

            public int Depth
            {
                get => depth;
                set
                {
                    depth = value;
                }
            }

            public ref List<int> Next
            {
                get { return ref next; }
            }

            public ref List<int> Prev
            {
                get => ref prev;
            }

            private int id;
            private int depth;
            private List<int> next;
            private List<int> prev;

        }

        void UpdatePrev(ref List<Course> courses, int id)
        {
            List<int> p = courses[id-1].Prev;
            foreach (int i in p)
            {
                courses[i-1].Depth++;
                UpdatePrev(ref courses, i);
            }
        }

        public int MinNumberOfSemesters(int n, int[][] dependencies, int k)
        {
            int sessions = 0;
            List<Course> courses = Enumerable.Range(1, n).Select(x => new Course(x)).ToList();

            for (int i=0; i<dependencies.Length; ++i)
            {
                int left = dependencies[i][0];
                int right = dependencies[i][1];

                Course lCourse = courses[left-1];
                Course rCourse = courses[right-1];

                lCourse.Next.Add(right);
                rCourse.Prev.Add(left);

                if (rCourse.Depth < lCourse.Depth) continue;
                else if (rCourse.Depth == lCourse.Depth) lCourse.Depth++;
                else lCourse.Depth = rCourse.Depth + 1;

                UpdatePrev(ref courses, left);
            }

            courses = courses.OrderByDescending(x => x.Depth).ThenByDescending(x => x.Next.Count).ToList();

            while (courses.Count > 0)
            {
                int num = 0;
                sessions++;
                int depth = courses[0].Depth;
                HashSet<int> completedCourses = new HashSet<int>();
                for (int i=0; i < courses.Count && num < k; )
                {
                    int id = courses[i].Id;
                    if (depth > courses[i].Depth && 
                        (courses[i].Prev.Intersect(completedCourses).Any() || 
                         courses.Where(x => x.Next.Exists(y => y == id)).Any()
                        )
                        )
                    {
                        ++i;
                        continue;
                    }

                    completedCourses.Add(id);
                    num++;

                    courses.RemoveAt(i);
                }
            }

            return sessions;
        }
    }
}


