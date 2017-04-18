using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Administration_System_v2.BL
{
    class BusinessRules 
    {
        public bool checkEligibility(string written, string viva)
        {
            double vivad = Double.Parse(viva);
            double writtend = Double.Parse(written);

            if (vivad >= 80 && writtend >= 80)
            {
                return true;
            }

            return false;
        }
    }
}
