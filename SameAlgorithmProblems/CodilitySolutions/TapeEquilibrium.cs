using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeAlgorithmProblems.CodilitySolutions
{
    public class TapeEquilibrium
    {
        public int Solution(int[] A)
        {

            #region solution 1 CORRECT ANSWER

            int left = A[0];
            int right = A[1];

            for (var i = 1; ++i < A.Length; right += A[i]);


            int min = Math.Abs(left - right);

            for (var P = 1; ++P < A.Length;)
            {
                int sum = Math.Abs((left += A[P - 1]) - (right -= A[P - 1]));
                if (sum < min)
                {
                    min = sum;
                }
            }
            return min;

            #endregion

            #region Solution 2: not true for negative array!

            //if (A.Length == 0)
            //    return 0;

            //int totalSum = 0;

            //foreach (var item in A)
            //{
            //    totalSum += item;
            //}

            //int leftSide = A[0];
            //int rightSide = totalSum - leftSide;
            //int diff = Math.Abs(leftSide - rightSide);

            //int minDiff = diff;

            //for (int i = 0; i + 1 < A.Length; i++)
            //{
            //    leftSide += A[i];
            //    rightSide -= A[i];
            //    diff = Math.Abs(leftSide - rightSide);
            //    minDiff = Math.Min(diff, minDiff);
            //}

            //return minDiff;

            #endregion



        }


    }
}
