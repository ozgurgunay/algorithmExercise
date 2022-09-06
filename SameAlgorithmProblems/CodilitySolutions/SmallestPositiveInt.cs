using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeAlgorithmProblems.CodilitySolutions
{
    public class SmallestPositiveInt
    {
        #region Question
            //Write a function:

            //class Solution { public int solution(int[] A); }
            //that, given an array A of N integers, returns the smallest positive integer(greater than 0) that does not occur in A.

            //For example, given A = [1, 3, 6, 4, 1, 2], the function should return 5.

            //Given A = [1, 2, 3], the function should return 4.

            //Given A = [−1, −3], the function should return 1.

            //Write an efficient algorithm for the following assumptions:

            //N is an integer within the range[1..100, 000];
            //each element of array A is an integer within the range[−1, 000, 000..1, 000, 000].

        #endregion


        #region Find smallest positive number missing

        public int FirstMissingPositive(int[] A, int N)
        {
            Array.Sort(A);
            int answer = 1;
            for (int i = 0; i < N; i++)
            {
                //if "answer" equal to array elements answer++ 
                if(A[i] == answer)
                {
                    answer++;
                }
            }
            return answer;
        }

        //second answer:
        //using System.Linq;

        //int smallestNumber = Enumerable.Range(1, 100000).Except(A).Min();

        //return smalletNumber


    #endregion
}
}
