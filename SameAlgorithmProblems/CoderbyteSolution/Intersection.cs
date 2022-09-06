using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeAlgorithmProblems
{
    public class Intersection
    {
        //Have the function FindIntersection(strArr) read the array of strings stored in strArr which will contain 2 elements:
        //the first element will represent a list of comma-separated numbers sorted in ascending order, the second element will represent a second list of comma-separated numbers (also sorted).
        //Your goal is to return a comma-separated string containing the numbers that occur in elements of strArr in sorted order. If there is no intersection, return the string false.

        public string FindIntersection(string[] strArr)
        {
            var valStr1 = strArr[0].Split(",").ToList().Select(x => x.Trim()).ToList();
            var valStr2 = strArr[1].Split(",").ToList().Select(x => x.Trim()).ToList();

            if (valStr1.Intersect(valStr2).Count() == 0)
            {
                return "false";
            }

            return string.Join(",", valStr1.Intersect(valStr2));
        }

        public string FindIntersectionWay2(string[] strArr)
        {
            string resultString = string.Join(",", strArr[0].Split(',').Select(x => x.Trim()).Intersect(strArr[1].Split(',').Select(x => x.Trim())));

            return string.IsNullOrEmpty(resultString) ? "false" : resultString;
        }


    }
 

}
