using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_August_2
{
    public class LogicalReasoning
    {
        /// <summary>
        /// Encodes given string 'A' into a char int pair which ,when multiplied, equals the place
        /// of the letter in the alphabet. Note that the char in the pair is also represented by its
        /// numerical place in the alphabet.
        /// </summary>
        /// <param name="A"></param>
        public void Solve(string A)
        {
            string output = "";
            Dictionary<char, int> alphabet = new Dictionary<char, int>()
            {
                {'A', 1 }, {'B', 2 }, {'C', 3 }, {'D', 4 }, {'E', 5 }, {'F', 6 }, {'G', 7}, {'H',8}, {'I',9}, {'J',10}, {'K',11},
                {'L',12},{'M',13},{'N',14}, {'O',15}, {'P',16}, {'Q',17}, {'R',18}, {'S',19}, {'T',20}, {'U',21}, {'V',22}, {'W',23},
                {'X',24 },{'Y', 25}, {'Z', 26}
            };
            foreach(char c in A.ToUpper())
            {
                int x , y;
                LCM(alphabet[c], out x, out y);
                output += (char)(x + 64)+ "" + y;
            }

            Console.WriteLine("Given the string '{0}', the encoded output is '{1}'",A, output);
        }
        private void LCM (int i, out int x, out int y)
        {
            x = 0;
            y = 0;
            int min = int.MaxValue;
            for (int n = 1; n <= i; n++)
            {
                if (i%n == 0)
                {
                    if (n + (i / n) < min)
                    {
                        x = i / n;
                        y = n;
                        min = x + y;
                    }
                }
            }
        }
        public LogicalReasoning()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("<-->LogicalReasoningAugust2nd<-->");
            Console.WriteLine("------------------------------");
        }
    }
}
