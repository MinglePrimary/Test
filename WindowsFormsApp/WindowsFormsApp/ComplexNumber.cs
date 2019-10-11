using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp
{
    class ComplexNumber
    {
        private int real;
        private int imaginary;
        public ComplexNumber()
        {
        }
        public ComplexNumber(int a, int b)
        {
            Real = a;
            Imaginary = b;
        }

        public int Real
        {
            get { return real; }
            set { real = value; }
        }

        public int Imaginary
        {
            get { return imaginary; }
            set { imaginary = value; }
        }

        // overload operation +
        public static ComplexNumber operator +(
            ComplexNumber x, ComplexNumber y)
        {
            return new ComplexNumber(x.Real + y.Real,
                    x.Imaginary + y.Imaginary);
        }
        // overload operation -
        public static ComplexNumber operator -(
            ComplexNumber x, ComplexNumber y)
        {
            return new ComplexNumber(x.Real - y.Real,
                    x.Imaginary - y.Imaginary);
        }
        // overload operation *
        public static ComplexNumber operator *(
            ComplexNumber x, ComplexNumber y)
        {
            return new ComplexNumber(x.Real * y.Real,
                   x.Imaginary * y.Imaginary);
        }

        public String toString()
        {
            return "(" + Real + " + " + Imaginary + "i)";
        }
    }
}
   