using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puzzles.Tasks
{
    public class ArrayContentCountSorting
    {
        static void AccsMain(string[] args)
        {
            ArrayContentCountSorting obj = new ArrayContentCountSorting();
            obj.CountContentSort(new int[] { 8, 1, 1, 6, 4, 4, 4, 4, 14, 5, 5, 5, 5 });
        }

        public void CountContentSort(int[] arr)
        {
            int temp;
            for (int i = 0; i < arr.Count()-1; i++)
            {
                for(int j = i+1; j < arr.Count(); j++)
                {
                    if (arr[j] <= arr[i])
                    {
                        temp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
            List<int> arrayCount = new List<int>();
            List<int> arrayContent = new List<int>();
            for(int i = 0; i<arr.Count()-1; i++)
            {
                arrayContent.Add(arr[i]);
                int currCount = 1;
            
                while (arr[i]==arr[i+1])
                {
                    currCount++;
                    i++;
                }
                arrayCount.Add(currCount);
            }
            if(arr[arr.Count()-1] == arr[arr.Count() - 2])
            {
                int newCount = arrayCount.Last() +1 ;
                arrayCount.Remove(arrayCount.Last());
                arrayCount.Add(newCount);
            }
            else
            {
                arrayCount.Add(1);
                arrayContent.Add(arr[arr.Count()-1]);
            }
            for (int i = 0; i < arrayCount.Count() - 1; i++)
            {
                for (int j = i + 1; j < arrayCount.Count(); j++)
                {
                    if (arrayCount[j] < arrayCount[i] || arrayContent[j]<arrayContent[i])
                    {
                        temp = arrayCount[j];
                        arrayCount[j] = arrayCount[i];
                        arrayCount[i] = temp;

                        temp = arrayContent[j];
                        arrayContent[j] = arrayContent[i];
                        arrayContent[i] = temp;
                    }
                }
            }

            for(int i=0; i < arrayCount.Count(); i++)
            {
                int count = arrayCount[i];
                    while (count > 0)
                    {
                        Console.Write(arrayContent[i] + ",");
                    count--;
                    }               
                
            }
            Console.Read();
        }

        public void DoubleThenextRows(int[][] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                int sum = 0;
                for(int j = 0; j < arr.Length; j++)
                {
                    sum += arr[i][j];
                }

                if(sum == arr[i+1][i])
                {
                    arr[i + 1][i] = 2 * arr[i + 1][i];
                }
            }
        }
    }
}
