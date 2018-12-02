using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puzzles.Tasks.Microsoft.Inheritance
{
    class NewModifier
    {
        public void NewModifierMain()
        {
            BaseC bc = new BaseC();
            DerivedC dc = new DerivedC();
            BaseC bcdc = new DerivedC();
            
            bc.sayHello();
            dc.sayHello();
            bcdc.sayHello();

            //Console.WriteLine(dc.x);
            //dc.DerivedCMain();
            Console.ReadLine();
        }
    }
    public class BaseC
    {
        public int x = 55;
        public static int y = 22;

        public void GetX()
        {
            Console.WriteLine("55");
        }

        public void sayHello()
        {
            System.Console.WriteLine("base says hello");
        }

        public void sayHello(string name)
        {
            System.Console.WriteLine("base says hello" + name);
        }
    }

    public class DerivedC : BaseC
    {
        // Hide field 'x'.
        new public int x = 100;

        public void DerivedCMain()
        {
            // Display the new value of x:
            Console.WriteLine(x);

            // Display the hidden value of x:
            //Console.WriteLine(BaseC.x);

            // Display the unhidden member y:
            Console.WriteLine(y);
        }

        new public void sayHello()
        {
            System.Console.WriteLine("derived says hello");
        }
    }
}
