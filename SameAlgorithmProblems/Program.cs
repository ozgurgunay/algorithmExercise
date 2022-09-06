using SomeAlgorithmProblems.CodilitySolutions;
using SomeAlgorithmProblems.MoreProblems;
using System;
using System.Text.RegularExpressions;

namespace SomeAlgorithmProblems
{
    class Program
    {
        
        static void Main(string[] args)
        {
            #region CoTest
            //CoTest coTest = new CoTest();
            //string str = "abababaa";
            //string a = coTest.findDifference(str);
            #endregion

            #region Intersection
            //Intersection intersection = new Intersection();
            //args = new string[] { "1, 3, 4,5, 7, 13", "1, 2,5, 4, 13, 15" };

            //string firstSolution = intersection.FindIntersection(args);
            //string secondSolution = intersection.FindIntersectionWay2(args);
            #endregion

            #region SmallestPositiveInt

            //int[] array = { 2, 3, -7, 6, 8, 1, -10, 15 };
            //int N = array.Length;
            //SmallestPositiveInt smallestPositiveInt = new SmallestPositiveInt();
            //int answer = smallestPositiveInt.FirstMissingPositive(array, N);

            #endregion

            #region CyclicRotation

            //CyclicRotation cyclicRotation = new CyclicRotation();
            //int[] values = { 3, 8, 9, 7, 6 };
            //var k = 3;

            //var solutionCyclic = cyclicRotation.Solution(values, k);


            //foreach (var item in solutionCyclic)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region OddOccurrencesInArray

            //OddOccurrencesInArray oddOccurrencesIn = new OddOccurrencesInArray();
            //int[] array = { 3, 5, 5, 3, 5, 2, 2 ,7};
            //oddOccurrencesIn.Solution(array);

            #endregion

            #region FrogJumpJump

            //FrogJmp frogJmp = new FrogJmp();
            //int count = frogJmp.Solution(10, 85, 30);

            #endregion

            #region PermMissingElement

            //PermMissingElement permMissingElement = new PermMissingElement();

            //int[] array = { 1, 2, 3, 5 };
            //int miss = permMissingElement.Solution(array);

            #endregion

            #region FindMissingNumbers

            //FindMissNumbers findMissNumbers = new FindMissNumbers();
            //int[] arr = { 6, 7, 10, 11, 13 };
            //findMissNumbers.FindMissingElements(arr);

            #endregion

            #region TapeEquilibrium

            //TapeEquilibrium tapeEquilibrium = new TapeEquilibrium();

            //int[] arr = { 3, 1, 2, 4, 3 };
            //int sol = tapeEquilibrium.Solution(arr);

            #endregion

            #region CountConformingBitmasks

            //CountConformingBitmasks countConforming = new CountConformingBitmasks();
            //int sol = countConforming.Solution(1073741727, 1073741631, 1073741679);

            #endregion

            #region SolutionInterview1

            //SolutionInter1 solutionInter = new SolutionInter1();
            //string shoes = "LLRLRLRLRLRLRRlrlr";
            //int answer = solutionInter.Solution(shoes);

            #endregion

            #region SolutionInterview2

            SolutionInter2 solutionInter2 = new SolutionInter2();
            int[] arr = { 1, 5, 2, 4, 3, 3 };
            int sol = solutionInter2.Solution(arr);
            #endregion







            Console.WriteLine(sol);
            Console.ReadLine();
        }


    }
    
}
