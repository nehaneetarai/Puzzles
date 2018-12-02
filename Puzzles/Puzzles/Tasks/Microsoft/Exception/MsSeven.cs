using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puzzles.Tasks.Microsoft.Exception
{
    class MsSeven
    {
        public void MsSevenMain()
        {
            try
            {
                Console.WriteLine("Exception:"+" "+1/Convert.ToInt32(0));
            }
            catch (ArithmeticException e)
            {
                Console.WriteLine("Divide by Zero error");
            }

            Console.ReadLine();
        }
    }
}
