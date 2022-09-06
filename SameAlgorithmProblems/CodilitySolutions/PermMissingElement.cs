using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeAlgorithmProblems.CodilitySolutions
{
    public class PermMissingElement
    {

        #region Question

        //An array A consisting of N different integers is given.The array contains integers in the range[1..(N + 1)], which means that exactly one element is missing.

        //Your goal is to find that missing element.

        //Write a function:

        //class Solution { public int solution(int[] A); }

        //that, given an array A, returns the value of the missing element.

        //For example, given array A such that:


        //A[0] = 2
        
        //A[1] = 3
        
        //A[2] = 1
        
        //A[3] = 5
        //the function should return 4, as it is the missing element.

        //Write an efficient algorithm for the following assumptions:

        //N is an integer within the range[0..100, 000];
        //the elements of A are all distinct;
        //each element of array A is an integer within the range[1..(N + 1)].


        #endregion

        public int Solution(int[] A)
        {
            #region solution 1
            //i think bad solution

            //int n = A.Length;
            //int sumArray = (n + 1) * (n + 2) / 2;
            //int sum = n * (n + 1) / 2;
            //for (int i = 0; i < n; i++)
            //{
            //    sumArray -= A[i];
            //}

            //return sumArray;

            #endregion

            #region solution 2

            int n = A.Length + 1;
            var sumOfAllElements = (n * (1 + n)) / 2;
            var missingElement = sumOfAllElements - A.Sum();    //Select(x => (int)x).Sum()
            return (int)missingElement;

            #endregion


        }
    }
}
