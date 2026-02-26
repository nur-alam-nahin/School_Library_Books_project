using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Library_Books_project.service
{
    class Billing
    {
        public static double billing(double price, double maintenance)
        {
            if(price == 0 || maintenance == 0)
            {
                return 0;
            }
            else
            {
                double res = price + maintenance;
                return res;
            }
        }
    }
}
