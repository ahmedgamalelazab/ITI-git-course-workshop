using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI1
{
    internal class Complex
    {
        int real;
        int imagine;
       static int count=0;
        static public int GetCount()
        {
            return count;
        }
        public void setreal(int _real)
        { this.real = _real; }

        public void setimagine(int _imagine)
        { this.imagine = _imagine; }

        public Complex(int real, int imagine)
        {
            this.real = real;
            this.imagine = imagine;
            count++;
        }

        public Complex(int imagine)
        {
            this.imagine = imagine;
            real = 0;
            count++;
        }

        public Complex()
        {
            real = 0;
            imagine = 0;
            count++;
        }

        public void DisplaySum()
        {

            if (imagine > 0)
            Console.WriteLine($"{real}+{imagine}J");

            else if (imagine == 0) Console.WriteLine(real);

            else Console.WriteLine(($"{real}-{imagine}J"));
        }

    }
}
