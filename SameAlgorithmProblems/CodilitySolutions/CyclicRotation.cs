using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeAlgorithmProblems.CodilitySolutions
{
    public class CyclicRotation
    {

        #region Question
        //https://app.codility.com/programmers/lessons/2-arrays/cyclic_rotation/

        #endregion


        #region answer

        public int[] Solution(int[] A, int K)
        {
            int[] values = A;

            for (int i = 0; i < K; i++)
            {
                values = Swap(values);
            }

            return values;
        }

        private int[] Swap(int[] intArray)
        {
            int[] newArray = new int[intArray.Length];

            if (newArray.Length == 0)
            {
                return newArray;
            }
            else
            {
                newArray[0] = intArray[intArray.Length - 1];

                for (int i = 0; i < intArray.Length - 1; i++)
                {
                    newArray[i + 1] = intArray[i];
                }

                return newArray;
            }
        }

        #endregion


    }
}
