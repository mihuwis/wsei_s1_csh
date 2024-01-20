using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newProject02
{
    internal class Utils
    {

        public static double abs( double x)
        {
            if (x > 0)
            {
                return x;
            }
            return -x;
        }
    }
}
