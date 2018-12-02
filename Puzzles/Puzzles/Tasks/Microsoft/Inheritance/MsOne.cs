using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puzzles.Tasks.Microsoft.Inheritance
{
    class MsOne
    {
        public void MsOneMain()
        {
            MsOneB b = new MsOneB(10);
            Console.ReadLine();
        }
    }

    class MsOneA
    {
        int i;
        public MsOneA(int j)
        {
            i = j;
            Console.WriteLine("Base");
        }
    }

    class MsOneB : MsOneA
    {
        public MsOneB(int j) : base(j)
        {
            Console.WriteLine("Derived");
        }
    }
}
