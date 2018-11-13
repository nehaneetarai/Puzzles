using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puzzles.Tasks
{
    public class Anagrams
    {
        static void AnagramsMain(string[] args)
        {

            //declarations
            int noOfTestCases = Convert.ToInt32(Console.ReadLine());
            int n = 0;

            //Creating list to be anagramed from Input
            List<string> toBeAnagramedList = new List<string>();
            List<string> anagramedList = new List<string>();
            for (int i = 0; i < noOfTestCases; i++)
            {
                toBeAnagramedList.Add(Console.ReadLine());
            }

            //fetch output for each item in the list and convert into space seperated single string and add it to output list
            foreach (var anaStr in toBeAnagramedList)
            {
                n = anaStr.Length;
                List<string> rawStrList = new List<string>();
                permute(anaStr, 0, n - 1, rawStrList);
                //rawStrList = rawStrList.OrderBy(x => x).ToList();
                anagramedList.Add(string.Join(" ", rawStrList));
            }


            //printing final list
            foreach (var item in anagramedList)
            {
                Console.WriteLine(item);
            }
        }

        /// <summary>
        /// permutation function
        /// @param str string to
        /// @param l starting index
        /// @param r end index
        /// </summary>
        private static void permute(String str, int l, int r, List<string> rawStrList)
        {
            Console.WriteLine($"Permutations of {str.Substring(0, l + 1)}");

            if (l == r)
            {
                rawStrList.Add(str);
                Console.WriteLine($"string - {str}, sIndex {l}, eIndex {r} Added ");
            }
            else
            {
                for (int i = l; i <= r; i++)
                {
                    str = swap(str, l, i);
                    Console.WriteLine($"1 Swap string - {str}, sIndex {l}, I - {i}, eIndex {r} ");
                    permute(str, l + 1, r, rawStrList);
                    str = swap(str, l, i);
                    Console.WriteLine($"2 Swap string - {str}, sIndex {l}, I - {i}, eIndex {r} ");
                }
            }
        }

        /// <summary>
        /// Swap Characters at position
        /// @param a string value
        /// @param i position 1
        /// @param j position 2
        /// @return swapped string
        /// </summary>
        public static String swap(String a, int i, int j)
        {
            char temp;
            char[] charArray = a.ToCharArray();
            temp = charArray[i];
            charArray[i] = charArray[j];
            charArray[j] = temp;
            string s = new string(charArray);
            return s;
        }
    }
}
