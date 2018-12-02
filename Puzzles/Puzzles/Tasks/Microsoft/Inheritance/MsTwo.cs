using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puzzles.Tasks.Microsoft.Inheritance
{
    class MsTwo
    {
        public void MsTwoMain()
        {
            MsTwoC c = new MsTwoC();
            MsTwoA a = new MsTwoA();
            a = c;
            a.Show();
            c.Show();
            Console.ReadLine();
        }
    }

    class MsTwoA
    {
        public virtual void Show()
        {
            Console.WriteLine("A.Show()");
        }
    }

    class MsTwoB : MsTwoA
    {
        public override void Show()
        {
            Console.WriteLine("B.Show()");
        }
    }

    class MsTwoC : MsTwoB
    {
        public override void Show()
        {
            Console.WriteLine("C.Show()");
        }
    }
}
