using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_20
{
    class Program
    {
        delegate double MyDelegate(double r);
        static void Main(string[] args)
        {
            double r = 2;
            MyDelegate myDelegate = Length;
            double n = myDelegate(r);
            Console.WriteLine(n);

            myDelegate = Area;
            n = myDelegate(r);
            Console.WriteLine(n);

            myDelegate = Volume;
            n = myDelegate(r);
            Console.WriteLine(n);

            Console.ReadKey();
            
        }
        static double Length(double r) => (double)2 * Math.PI * r;
        static double Area(double r) => (double)Math.PI * Math.Pow(r, 2);
        static double Volume(double r) => (double)4/3 * Math.PI * Math.Pow(r,3);
    }
}
