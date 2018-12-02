using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puzzles.Tasks.Microsoft.Inheritance
{
    class MsThree
    {
        public void MsThreeMain()
        {
            //MsThreeBase b = new MsThreeBase();
            //MsThreeDerived d = new MsThreeDerived();
            MsThreeBase bd = new MsThreeDerived();
            //b.f1();
            //b.f2();
            //b.f3();

            //d.f1();
            //d.f2();
            //d.f3();

            bd.f1();
            bd.f2();
            bd.f3();
            Console.ReadLine();
        }
    }

    class MsThreeBase
    {
        public void f1()
        {
            Console.WriteLine("Base f1");
        }
        public virtual void f2()
        {
            Console.WriteLine("Base f2");
        }
        public virtual void f3()
        {
            Console.WriteLine("Base f3");
        }
    }

    class MsThreeDerived : MsThreeBase
    {
        new public void f1()
        {
            Console.WriteLine("Derived f1");
        }
        public override void f2()
        {
            Console.WriteLine("Derived f2");
        }
        public new void f3()
        {
            Console.WriteLine("Derived f3");
        }
    }
}
