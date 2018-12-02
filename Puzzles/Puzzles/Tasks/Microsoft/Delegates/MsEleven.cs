using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puzzles.Tasks.Microsoft.Delegates
{
    class MsEleven
    {
        delegate void Printer();
        public void MsElevenMain()
        {
            int i = 0;
            List<Printer> printers = new List<Printer>();
            for (; i < 10; i++)
            {
                printers.Add(delegate { Console.WriteLine(i); });
            }

            foreach (var printer in printers)
            {
                printer();
            }
        }
    }
}
