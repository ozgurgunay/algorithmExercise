using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeAlgorithmProblems.CodilitySolutions
{
    public class SolutionInter1
    {
        public int Solution(string c)
        {
            //question in web site 

            int right = 0;
            int left = 0;
            int employee = 1;
            for (int i = 0; i < c.Length - 1; i++)
            {
                if (c[i] == 'L')
                {
                    left++;
                }
                else if(c[i] == 'R')
                {
                    right++;
                }
                if(left == right)
                {
                    employee++;
                    right = 0;
                    left = 0;
                }
            }
            if(employee == 0)
            {
                return employee;
            }
            return employee + 1;
        }

    }
}
