using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puzzles.Tasks
{
    public class RollingString
    {
        public void RsMain(string toBeRolled, string direction)
        {

        }

        public string rollingString(string s, List<string> operations)
        {
            //s = "abc";
            //OP -- acc
            //operations.Add("0 0 L");
            //operations.Add("2 2 L");
            //operations.Add("0 2 R");

            //operations.Add("0 1 L");
            //operations.Add("1 2 R");
            //operations.Add("0 2 R");

            int startIndex = 0;
            int endIndex = 0;
            string direction;
            int k = 0;
            string test;
            string cipherStr;
            foreach (var op in operations)
            {
                string opStr = op.Replace(" ", "");
                startIndex = Convert.ToInt32(opStr[0].ToString());
                endIndex = Convert.ToInt32(opStr[1].ToString());
                direction = op[2].ToString();
                k = direction == "R" ? 1 : -1;
                if (startIndex == endIndex)
                {
                    cipherStr = s.Substring(startIndex, 1);
                    test = caesarCipher(cipherStr, k);
                    test = test.Replace('`', 'z');
                    s = s.Replace(cipherStr, test);
                }
                else
                {
                    cipherStr = s.Substring(startIndex, endIndex - startIndex + 1);
                    test = caesarCipher(s.Substring(startIndex, endIndex - startIndex + 1), k);
                    test = test.Replace('`', 'z');
                    s = s.Replace(cipherStr, test);
                }
                Console.WriteLine(s);
            }
            return s;
        }

        public string caesarCipher(String s, int k)
        {
            // Complete this function
            String newString = "";
            int[] carr = new int[s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                if ((int)s[i] >= 65 && (int)s[i] <= 90)
                {
                    carr[i] = ((int)s[i]);
                    if ((carr[i] + (k % 26)) > 90)
                    {
                        newString += (char)(carr[i] - 90 + 64 + (k % 26));
                    }
                    else if ((carr[i] + (k % 26)) <= 90)
                    {
                        newString += (char)(carr[i] + (k % 26));

                    }
                }
                if ((int)s[i] >= 97 && (int)s[i] <= 122)
                {
                    carr[i] = ((int)s[i]);
                    if ((carr[i] + (k % 26)) > 122)
                    {
                        newString += (char)(carr[i] - 122 + 96 + (k % 26));
                    }
                    else if ((carr[i] + (k % 26)) <= 122)
                    {
                        newString += (char)(carr[i] + (k % 26));

                    }
                }
                if ((int)s[i] >= 91 && (int)s[i] <= 96)
                {
                    carr[i] = (int)s[i];
                    newString += (char)(carr[i]);
                }
                if ((int)s[i] < 65 || (int)s[i] > 122)
                {
                    carr[i] = (int)s[i];
                    newString += (char)(carr[i]);
                }


            }
            return newString;
        }
        
        /// <summary>
        /// Geeks for geeks Implementation
        /// </summary>
        public void rollStringRight()
        {
            int noOfTestCases = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < noOfTestCases; i++)
            {
                int arrSize = Convert.ToInt32(Console.ReadLine());
                String s = Console.ReadLine();
                int[] arr = new int[arrSize];
                string arrVal = Console.ReadLine();
                arrVal = arrVal.Replace(" ", "");
                for (int j = 0; j < arrVal.Length; j++)
                {
                    arr[j] = Convert.ToInt32(arrVal[j].ToString());
                }
                char[] a = s.ToCharArray();
                for (int j = 0; j < arrSize; j++)
                {
                    for (int k = 0; k < arr[j]; k++)
                    {
                        if (a[k] == 'z')
                        {
                            int index = (int)a[k] - 25;
                            a[k] = (char)index;
                        }
                        else
                        {
                            int index = (int)a[k] + 1;
                            a[k] = (char)index;
                        }

                    }
                }
                Console.WriteLine(new String(a));
            }

        }

        /// <summary>
        /// Updated One
        /// </summary>
        /// <param name="strActual"></param>
        /// <param name="operations"></param>
        /// <returns></returns>
        public string rollString(string strActual, List<string> operations)
        {
            //Below is the setup
            //Output should be acc for abc, tguc for tfuc for below operations
            strActual = "tfuc";
            
            operations.Add("0 0 L"); //sfuc
            operations.Add("2 2 L"); //sftc
            operations.Add("0 2 R"); //tguc
            
            if (strActual.Length >= 1 && strActual.Length <= 150 && operations.Count >= 1 && operations.Count<=100)
            {
                int startIndex;
                int endIndex;
                string direction;
                foreach (var op in operations)
                {
                    string opStr = op.Replace(" ", "");
                    startIndex = Convert.ToInt32(opStr[0].ToString());
                    endIndex = Convert.ToInt32(opStr[1].ToString());
                    direction = opStr[2].ToString();
                    if (startIndex >= 0 && endIndex >= startIndex && strActual.Length > endIndex)
                    {
                        int strLen = startIndex == endIndex ? 1 : endIndex - startIndex + 1;
                        string strToChng = strActual.Substring(startIndex, strLen);
                        string strModified;
                        if (direction == "R")
                        {
                            strModified = rollRight(strToChng);
                            strActual = strActual.Replace(strToChng, strModified);
                        }
                        else if (direction == "L")
                        {
                            strModified = rollLeft(strToChng);
                            strActual = strActual.Replace(strToChng, strModified);
                        }
                    }
                    //Console.WriteLine(strActual);
                }
            }
            return strActual;
        }

        public string rollRight(string str)
        {
            char[] charArr = str.ToCharArray();
            for (int k = 0; k < charArr.Length; k++)
            {
                if (charArr[k] == 'z')
                {
                    int index = (int)charArr[k] - 25;
                    charArr[k] = (char)index;
                }
                else
                {
                    int index = (int)charArr[k] + 1;
                    charArr[k] = (char)index;
                }
            }
            return new string(charArr);
        }

        public string rollLeft(string str)
        {
            char[] charArr = str.ToCharArray();
            for (int k = 0; k < charArr.Length; k++)
            {
                if (charArr[k] == 'a')
                {
                    int index = (int)charArr[k] + 25;
                    charArr[k] = (char)index;
                }
                else
                {
                    int index = (int)charArr[k] - 1;
                    charArr[k] = (char)index;
                }
            }
            return new string(charArr);
        }

    }
}
