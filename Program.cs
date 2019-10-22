using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string bob = "Hello Bob";
            string eva = "Hello Eva";
            Console.WriteLine(bob);
            Console.WriteLine(eva);
            string userName;
            Console.WriteLine("Name please!:");
            userName = Console.ReadLine();
            Console.WriteLine("Hello " + userName);

            /*int a, b;
            int sum, roz, mno;
            float dzi;
            console.writeline("podaj a:");
            a = convert.toint32(console.readline());
            console.writeline("podaj b:");
            b = convert.toint32(console.readline());
            console.writeline("a = " + a);
            console.writeline("b = " + b);
            sum = a + b;
            roz = a - b;
            mno = a * b;
            dzi = a / b;
            console.writeline("a + b = " + sum);
            console.writeline("a - b = " + roz);
            console.writeline("a * b = " + mno);
            console.writeline("a / b = " + dzi);*/

            int x = 1, y = 2, z = 3;
            bool wynik;
            wynik = (x == 1 || y != 5 && z < 1);
            Console.WriteLine(wynik);


            Console.ReadKey();
        }
    }
}
