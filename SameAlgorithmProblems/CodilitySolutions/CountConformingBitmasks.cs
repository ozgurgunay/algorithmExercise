using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeAlgorithmProblems.CodilitySolutions
{
    public class CountConformingBitmasks
    {

        #region question: That's a tougher question............




        #endregion

        #region solution 

        public static int count(int d)
        {
            int bits = 0;
            for (int i = 0; i < 30; i++)
            {
                if (((d >> i) & 1) == 0)
                {
                    bits++;
                }
                //if ((d & 1) == 0) bits++;
                //d >>= 1; //shift right
            }
            return (int)Math.Pow(2, bits);
        }

        public int Solution(int A, int B, int C)
        {
            //A = 1073741727;
            //B = 1073741631;
            //C = 1073741679;

            int total = 0;
            total += count(A);
            //Console.WriteLine("total"+total);
            total += count(B);
            //Console.WriteLine("total"+total);
            total += count(C);
            //Console.WriteLine("total"+total);
            //remove duplicates
            total -= count(A | B);
            //Console.WriteLine("total"+total);
            total -= count(B | C);
            //Console.WriteLine("total"+total);
            total -= count(C | A);
            //Console.WriteLine("total"+total);
            total += count(A | B | C);
            //Console.WriteLine("total"+total);
            return total;

        }


        #endregion

    }
}


//A = 11 1111 1111 1111 1111 1111 1001 1111(BIN) = 1,073,741,727
//B = 11 1111 1111 1111 1111 1111 0011 1111(BIN) = 1,073,741,631
//C = 11 1111 1111 1111 1111 1111 0110 1111(BIN) = 1,073,741,679