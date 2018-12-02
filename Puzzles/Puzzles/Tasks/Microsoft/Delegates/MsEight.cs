using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puzzles.Tasks.Microsoft.Delegates
{
    class MsEight
    {
        delegate int del(int i);
        del d;
        public void MsEightMain()
        {
            d = new del(ref MyFun);
            //d = MyFun;
            d(10);
        }

        public int MyFun(int i)
        {
            Console.WriteLine("Welcome to Microsoft.com!");
            return 0;
        }
    }
}
