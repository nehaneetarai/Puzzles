using Puzzles.Tasks;
using Puzzles.Tasks.Microsoft.Constructor;
using Puzzles.Tasks.Microsoft.Delegates;
using Puzzles.Tasks.Microsoft.Exception;
using Puzzles.Tasks.Microsoft.Inheritance;
using Puzzles.Tasks.Microsoft.MainMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puzzles
{
    class Program
    {
        static void Main(string[] args)
        {

            //Ms

            //MsOne m1 = new MsOne();
            //m1.MsOneMain();

            //MsTwo m2 = new MsTwo();
            //m2.MsTwoMain();

            //MsThree m3 = new MsThree();
            //m3.MsThreeMain();

            //MsFour m4 = new MsFour();
            //m4.MsFourMain();

            //NewModifier nm = new NewModifier();
            //nm.NewModifierMain();

            //MsSeven m7 = new MsSeven();
            //m7.MsSevenMain();

            MsEight m8 = new MsEight();
            m8.MsEightMain();

            // Dev Change from GUI to local comment
            ArrayContentCountSorting a = new ArrayContentCountSorting();

        }

        //static int Main(string[] args)
        //{

        //    //Ms

        //    MsFive m5 = new MsFive();
        //    m5.MsFiveMain();
        //    return 0;

        //}
    }
}
