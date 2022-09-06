using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeAlgorithmProblems.CodilitySolutions
{
    public class OddOccurrencesInArray
    {

        #region Question

        //A non-empty array A consisting of N integers is given.The array contains an odd number of elements, and each element of the array can be paired with another element that has the same value, except for one element that is left unpaired.

        //For example, in array A such that:

        // A[0] = 9  A[1] = 3  A[2] = 9

        // A[3] = 3  A[4] = 9  A[5] = 7

        // A[6] = 9
        //the elements at indexes 0 and 2 have value 9,
        //the elements at indexes 1 and 3 have value 3,
        //the elements at indexes 4 and 6 have value 9,
        //the element at index 5 has value 7 and is unpaired.
        //Write a function:

        //class Solution { public int solution(int[] A); }

        //        that, given an array A consisting of N integers fulfilling the above conditions, returns the value of the unpaired element.

        //        For example, given array A such that:

        //          A[0] = 9  A[1] = 3  A[2] = 9

        //          A[3] = 3  A[4] = 9  A[5] = 7

        //          A[6] = 9
        //        the function should return 7, as explained in the example above.

        //        Write an efficient algorithm for the following assumptions:

        //        N is an odd integer within the range [1..1,000,000];
        //        each element of array A is an integer within the range[1..1, 000, 000, 000];
        //all but one of the values in A occur an even number of times.

        #endregion

        #region find unpaired number

        public int Solution(int[] A)
        {
            #region solution 1:

            //int arraySize = A.Length;

            //for (int i = 0; i < arraySize; i++)
            //{
            //    int count = 0;

            //    for (int j = 0; j < arraySize; j++)
            //    {
            //        if (A[i] == A[j])
            //        {
            //            count++;
            //        }
            //    }
            //    if (count % 2 != 0)
            //    {
            //        return A[i];
            //    }

            //}
            //return -1;


            #endregion

            #region solution 2:
            //In HashSet, duplicate elements are not allowed.

            var has = new HashSet<int>();
            foreach (var item in A)
            {
                if (has.Contains(item))
                {
                    has.Remove(item);
                }
                else
                {
                    has.Add(item);
                }
            }
            if(has != null)
            {
                foreach (var item in has)
                {
                    return item;                
                }
                
            }
            
            return 0;
            
            #endregion
        }

        #endregion

    }
}
