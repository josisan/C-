using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            int d = Int32.Parse(Console.ReadLine());
            DateTime then = DateTime.Now.AddDays(d);
            int m = Int32.Parse(Console.ReadLine());
            DateTime then1 = DateTime.Now.AddDays(m);
            int y = Int32.Parse(Console.ReadLine());
            DateTime then2 = DateTime.Now.AddDays(y);

            TimeSpan ts = now - then;
            double diff = ts.TotalDays;

            Console.WriteLine(ts);
        }
    }
}
