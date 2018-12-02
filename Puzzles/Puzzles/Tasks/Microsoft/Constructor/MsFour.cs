using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puzzles.Tasks.Microsoft.Constructor
{
    class MsFour
    {
        public void MsFourMain()
        {
            TestStatic ts = new TestStatic();
            ts.print();
            Console.ReadLine();
        }
    }

    public class TestStatic
    {
        public static int TestValue { get; set; }

        /// <summary>
        /// Instance Constructor gets called later
        /// </summary>
        public TestStatic()
        {
            if (TestValue == 0)
            {
                TestValue = 5;
            }
        }

        /// <summary>
        /// Static constructor gets called first
        /// </summary>
        static TestStatic()
        {
            if (TestValue == 0)
            {
                TestValue = 10;
            }
        }

        public void print()
        {
            if(TestValue == 5)
            {
                TestValue = 6;
            }

            Console.WriteLine($"Test Value is :{TestValue}");
        }
    }
}
