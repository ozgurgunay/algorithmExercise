using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeAlgorithmProblems.MoreProblems
{
    public class CoTest
    {
        #region Find missing odd number array --coensio burgan-intertech
        //static void findMissingNums(int[] odd, int sizeOdd)
        //{
        //    //to store the min and the max
        //    //odd elements from the arrays
        //    int minOdd = odd.Max(); //int.MaxValue;
        //    int maxOdd = odd.Min(); //int.MinValue;

        //    //to store the sum of the array elements
        //    int sumOddArray = 0;

        //    //get the min and the max
        //    //odd elements from the array
        //    for (int i = 0; i < sizeOdd; i++)
        //    {
        //        minOdd = Math.Min(minOdd, odd[i]);
        //        maxOdd = Math.Max(maxOdd, odd[i]);
        //        sumOddArray += odd[i];
        //    }

        //    //to store the total terms in the series 
        //    //and the required sum of the array 
        //    int totalTerms = 0;
        //    int reqSum = 0;

        //    //total terms from 1 to minOdd
        //    totalTerms = (minOdd / 2) + 1;

        //    //sum of all odd numbers
        //    //from 1 to minOdd 
        //    int oddSumMin = totalTerms * totalTerms;

        //    //total terms from 1 to maxOdd 
        //    totalTerms = (maxOdd / 2) + 1;

        //    //sum of all odd numbers
        //    //from 1 to maxOdd
        //    int oddSumMax = totalTerms * totalTerms;

        //    //required sum for the odd array
        //    reqSum = oddSumMax - oddSumMin + minOdd;

        //    Console.WriteLine("Odd = " + (reqSum - sumOddArray));
        //    Console.ReadLine();
        //}


        //static void Main() //string[] args
        //{
        //    int[] odd = { 9, 7, 3 };
        //    int sizeOdd = odd.Length;
        //    findMissingNums(odd, sizeOdd);
        //}

        #endregion


        #region Find the absolute difference between the number of occurences --coensio burgan-intertech

        public string findDifference(string str)
        {
            //string str = "AAAAabbB";
            string charListA = "A" + "a";
            string charListB = "B" + "b";
            int firstCharacter = 0;
            int secondCharacter = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (charListA.Contains(str[i]))
                {
                    firstCharacter++;
                }
                if (charListB.Contains(str[i]))
                {
                    secondCharacter++;
                }
            }
            int solution = Math.Abs(firstCharacter - secondCharacter);

            return solution.ToString();
        }
        //static void Main(string[] args)
        //{
        //    //string str = "AAAAabbB";
        //    //string charListA = "A" + "a";
        //    //string charListB = "B" + "b";
        //    //int firstCharacter = 0;
        //    //int secondCharacter = 0;

        //    //for (int i = 0; i < str.Length; i++)
        //    //{
        //    //    if (charListA.Contains(str[i]))
        //    //    {
        //    //        firstCharacter++;
        //    //    }
        //    //    if (charListB.Contains(str[i]))
        //    //    {
        //    //        secondCharacter++;
        //    //    }
        //    //}
        //    //int solution = Math.Abs(firstCharacter - secondCharacter);
        //    string str = "AAAAabbB";
        //    findDifference(str);
        //}


        #endregion

    }
}
