using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeAlgorithmProblems.CodilitySolutions
{
    public class SolutionInter2
    {
        //question in web site screen
        //you are given an array A of integers.find the maximum number of non-intersecting segments of length 2 (two adjacent elements) such that segments have an equal sum
        //there are three non-intersecting segments, each whose sum is equal to 4


        public int GetCount (int index, int sum, int[] array)
        {
            int n = array.Length;
            if(index >= n - 1)
            {
                return 0;
            }
            int count = 0;
            if(array[index] + array[index + 1] == sum)
            {
                count = 1 + GetCount(index + 2, sum, array);
            }

            return Math.Max(count, GetCount(index + 1, sum, array));
        }

        public int Solution(int[] A)
        {
            int len = A.Length;
            int rtn = 0;
            for (int i = 0; i < len - 1; i++)
            {
                int sum = A[i] + A[i + 1];
                rtn = Math.Max(rtn, 1 + GetCount(i + 2, sum, A));
            }
            return rtn;
        }


    }
}
