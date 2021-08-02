using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_August_2
{
    public class LongestCommonSubsequence
    {
        /// <summary>
        /// Finds the longest common sequence between string A and B. 
        /// This is, the sequence found in both A and B such that 
        /// SubstringA == SubstringB && SubstringA > Max(SubstringA(n))
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        public void Solve(string A, string B)
        {
            string result = "";
            for (int a = 0; a < A.Length; a++)
            {
                for (int offset = 0; offset < A.Length - a+1; offset++)
                {
                    string subString = A.Substring(a, offset).ToLower();
                    if (B.ToLower().Contains(subString))
                    {
                        if (subString.Length > result.Length)
                            result = subString;
                        continue;
                    }
                    else
                    {
                        break;
                    }

                }
            }
            Console.WriteLine("StringA: {0}\nStringB: {1}", A, B);
            Console.WriteLine("LCS: " + result);
        }
        public LongestCommonSubsequence()
        {

            Console.WriteLine("------------------------------");
            Console.WriteLine("<-->LongestCommonSubsequence<-->");
            Console.WriteLine("------------------------------");
        }
    }
}
