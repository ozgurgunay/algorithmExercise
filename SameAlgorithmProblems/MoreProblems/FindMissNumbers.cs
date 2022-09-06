using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeAlgorithmProblems.MoreProblems
{
    
    public class FindMissNumbers
    {
        //Finding all missing numbers from a given sorted array

        public void FindMissingElements(int[] arr)
        {
            int N = arr.Length;
            int tempNum = 0;
            for (int i = arr[0]; i < arr[N -1]; i++)
            {
                if(arr[tempNum] == i)
                {
                    tempNum++;
                }
                else
                {
                    Console.WriteLine(i + " ");
                }

            }

        }
        

    }
}
