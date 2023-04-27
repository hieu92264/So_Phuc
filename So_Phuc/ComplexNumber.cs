using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace So_Phuc
{
    public class ComplexNumber
    {
        int a, b;
        public ComplexNumber(int a, int b)
        {
            this.a = a; this.b = b;
        }
        public int[] add(int c, int d)
        {
            int[] s = new int[2];
            s[0] = a + c;
            s[1] = b + d;
            return s;
        }
        public int[] sub(int c, int d)
        {
            int[] s = new int[2];
            s[0] = a - c;
            s[1] = b - d;
            return s;
        }
    }
}
