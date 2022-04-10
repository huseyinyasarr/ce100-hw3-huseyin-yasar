using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
* @file ce100_hw3_algo_lib_cs *
* @author huseyin yasar *
* @date 10 April 2022 * 
*
* @brief <b> hw-3 Functions </b> *
*
* HW-3 Sample Lib Functions *
*
* @git clone 
* @see http://bilgisayar.mmf.erdogan.edu.tr/en/
*
*/


namespace ce100_hw3_algo_lib_cs
{
    public class Class1
    {
        // Returns length of LCS for X[0..m-1], Y[0..n-1]
        public static string longestCommonSubsquence(string arrayB, string E, int a, int e)
        {
            int[,] arrayA = new int[a + 1, e + 1];

            // Following steps build arrayA[m+1][n+1] in
            // bottom up fashion. Note that arrayA[i][j]
            // contains length of LCS of X[0..i-1]
            // and Y[0..j-1]
            for (int i = 0; i <= a; i++)
            {
                for (int j = 0; j <= e; j++)
                {
                    if (i == 0 || j == 0)
                    {
                        arrayA[i, j] = 0;
                    }
                    else if (arrayB[i - 1] == E[j - 1])
                    {
                        arrayA[i, j] = arrayA[i - 1, j - 1] + 1;
                    }
                    else
                    {
                        arrayA[i, j] = Math.Max(arrayA[i - 1, j], arrayA[i, j - 1]);
                    }
                }
            }

            // Following code is used to print LCS
            int index = arrayA[a, e];


            // Create a character array
            // to store the lcs string
            string lcs = string.Empty;



            // Start from the right-most-bottom-most corner
            // and one by one store characters in lcs[]
            int b = a, c = e;
            while (b > 0 && c > 0)
            {
                // If current character in X[] and Y
                // are same, then current character
                // is part of LCS
                if (arrayB[b - 1] == E[c - 1])
                {
                    // Put current character in result
                    lcs = arrayB[b - 1] + lcs;

                    // reduce values of i, j and index
                    b--;
                    c--;
                    index--;
                }

                // If not same, then find the larger of two and
                // go in the direction of larger value
                else if (arrayA[b - 1, c] > arrayA[b, c - 1])
                { b--; }
                else
                { c--; }
            }
            return lcs;
        }




        // Matrix Ai has dimension p[i - 1] x p[i]
        // for i = 1..n
        public static int matrixChainOrder(int[] p, int i, int j)
        {

            if (i == j)
                return 0;

            int minimum = int.MaxValue;

            // place parenthesis at different places
            // between first and last matrix, recursively
            // calculate deem of multiplications for each
            // parenthesis placement and return the
            // minimum deem
            for (int k = i; k < j; k++)
            {
                int deem = matrixChainOrder(p, i, k)
                            + matrixChainOrder(p, k + 1, j)
                            + p[i - 1] * p[k] * p[j];

                if (deem < minimum)
                    minimum = deem;
            }

            // Return minimum deem
            return minimum;
        }
    }
}






      
    

