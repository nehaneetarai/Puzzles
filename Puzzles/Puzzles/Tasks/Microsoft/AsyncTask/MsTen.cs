using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puzzles.Tasks.Microsoft.AsyncTask
{
    class MsTen
    {
        private static string result;

        public void MsTenMain()
        {
            SaySomething();
            Console.WriteLine(result);
        }

        static async Task<string> SaySomething()
        {
            await Task.Delay(5);
            result = "Hello World";
            return "something";
        }
    }
}
