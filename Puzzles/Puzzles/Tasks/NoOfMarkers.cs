using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puzzles.Tasks
{
    public class NoOfMarkers
    {
        static void MarkersMain(string[] args)
        {
            int noOfTestCases = Convert.ToInt32(Console.ReadLine());
            if (noOfTestCases < 1000 && noOfTestCases > 0)
            {
                List<int> results = new List<int>();
                for (int c = 0; c < noOfTestCases; c++)
                {
                    int noOfPoints = Convert.ToInt32(Console.ReadLine());
                    if (noOfPoints > 0 && noOfPoints < 10000)
                    {
                        HashSet<int> noOfMarkers = new HashSet<int>();
                        for (int i = 0; i < noOfPoints; i++)
                        {
                            string[] pointRange = Console.ReadLine().Split();
                            int x = int.Parse(pointRange[0]);
                            int y = int.Parse(pointRange[1]);
                            if (x < 32767 && x > -326768 && y < 32767 && y > -32768)
                            {
                                for (int z = x; z <= y; z++)
                                {
                                    noOfMarkers.Add(z);
                                }
                            }
                        }

                        results.Add(noOfMarkers.Count);
                    }

                }

                foreach (var item in results)
                {
                    Console.WriteLine(item);
                }
            }

        }
    }
}
