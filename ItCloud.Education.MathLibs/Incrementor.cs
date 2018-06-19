using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItCloud.Education.MathLibs
{
    public static class Incrementor
    {
        public static int Inc(ref int val1, ref int val2)
        {
            ++val1;
            ++val2;
            return 3;
        }

        public static int Inc(ref int val1, ref int val2, ref int val3)
        {
            ++val1;
            ++val2;
            ++val3;
            return 3;
        }
    }
}
