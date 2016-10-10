using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ext
{
    public static class Whatsup
    {

        public static int Looking(this string find)
        {
            int where = 0;
            foreach (char c in find)
            {
                if (c == 'a')
                    where++;
            }
            return where;
        }

        public static int Plus(this int add)
        {
            int grow = add + 2;
            return grow;
        }

        public static double Money(this double pay)
        {
            double grow = pay + .50;
            return grow;
        }

        public static bool WhatsUpYo(this bool thesky)
        {
            if (thesky == false)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool Maybe(this char myb)
        {
            if (myb == 'n')
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static float Div(this float product)
        {
            float flt = product / 3;
            return flt;
        }
    }
}
